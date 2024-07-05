using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using LabJack.LabJackUD;
using Peltarion.Deployed;
using Peltarion.Maths;
using PMatrix = Peltarion.Maths.Matrix;


namespace WindowsForms
{
    public static class CCM
    {     
        public static bool RGB2HSI(Bitmap SourceImage, int Camno, int Threshold,out int Nozzle_1, out int Nozzle_2)
        {
            Rectangle rect = new Rectangle(0, 0, SourceImage.Width, SourceImage.Height);
            BitmapData bmpData = SourceImage.LockBits(rect, ImageLockMode.ReadWrite, SourceImage.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            byte[] byteColor = new byte[bmpData.Stride * SourceImage.Height];
            byte[] byteHue = new byte[bmpData.Stride * SourceImage.Height];
            byte[] byteSat = new byte[bmpData.Stride * SourceImage.Height];
            double[,] coocH1 = new double[256, 256];
            double[,] coocH2 = new double[256, 256];
            double[,] coocH3 = new double[256, 256];
            double[,] coocH4 = new double[256, 256];
            double[,] coocH5 = new double[256, 256];
            double[,] coocH6 = new double[256, 256];
            double[,] coocS1 = new double[256, 256];
            double[,] coocS2 = new double[256, 256];
            double[,] coocS3 = new double[256, 256];
            double[,] coocS4 = new double[256, 256];
            double[,] coocS5 = new double[256, 256];
            double[,] coocS6 = new double[256, 256];
            // G_Ratio Algorithm Variables
            byte[] byteG_ratio = new byte[bmpData.Stride * SourceImage.Height]; // Complete 768*128 image
            double[,] G_Ratio1 = new double[128, 128];
            double[,] G_Ratio2 = new double[128, 128];
            double[,] G_Ratio3 = new double[128, 128];
            double[,] G_Ratio4 = new double[128, 128];
            double[,] G_Ratio5 = new double[128, 128];
            double[,] G_Ratio6 = new double[128, 128];
            double[] gcount = new double[6];
            //LabJackUDException exc;
            System.Runtime.InteropServices.Marshal.Copy(ptr, byteColor, 0, byteColor.Length);
            // For Converting RGB to HSI
            int i, j, k, K1;
            for (k = 0; k < byteColor.Length; k += 3)
            {
                double G_ratio = 0;
                byte R, G, B;
                double Theta, Saturation; ;
                B = byteColor[k];
                G = byteColor[k + 1];
                R = byteColor[k + 2];
                Theta = Math.Acos(0.5 * ((R - G) + (R - B)) / (Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B)) + 0.0000001));
                if (B > G)
                {
                    byteHue[k] = byteHue[k + 1] = byteHue[k + 2] = (byte)((360.0 - Theta) / 360.0 * 255);
                }

                else if (B <= G)
                {
                    byteHue[k] = byteHue[k + 1] = byteHue[k + 2] = (byte)(Theta / 360 * 255);

                }
                Saturation = 255 * (1 - 3 / (R + G + B + 0.000000001) * Math.Min(R, Math.Min(G, B)));

                byteSat[k] = byteSat[k + 1] = byteSat[k + 2] = (byte)Saturation;

                G_ratio = (255 * G) / (R + G + B + 0.0000001);
                if (G_ratio > Threshold)
                {
                    byteG_ratio[k] = byteG_ratio[k + 1] = byteG_ratio[k + 2] = 255;
                }
                else
                {
                    byteG_ratio[k] = byteG_ratio[k + 1] = byteG_ratio[k + 2] = 0;
                }
            }
            // Coocurance matrix intialization
            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    coocH1[i, j] = coocH2[i, j] = coocH3[i, j] = coocH4[i, j] = coocH5[i, j] = coocH6[i, j] = 0;
                    coocS1[i, j] = coocS2[i, j] = coocS3[i, j] = coocS4[i, j] = coocS5[i, j] = coocS6[i, j] = 0;
                }
            }
            for (i = 0; i < 128; i++)   // first 128 by 128 part of image (0 to 127)
            {

                for (j = 0; j < 127; j++)
                {
                    coocH1[byteHue[i * 768 * 3 + j * 3], byteHue[i * 768 * 3 + j * 3 + 3]] = coocH1[byteHue[i * 768 * 3 + j * 3], byteHue[i * 768 * 3 + j * 3 + 3]] + 1;
                    coocH1[byteHue[i * 768 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + j * 3]] = coocH1[byteHue[i * 768 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + j * 3]] + 1;
                    coocS1[byteSat[i * 768 * 3 + j * 3], byteSat[i * 768 * 3 + j * 3 + 3]] = coocS1[byteSat[i * 768 * 3 + j * 3], byteSat[i * 768 * 3 + j * 3 + 3]] + 1;
                    coocS1[byteSat[i * 768 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + j * 3]] = coocS1[byteSat[i * 768 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + j * 3]] + 1;
                    // First 128 by 128 part of G_ratio image
                    G_Ratio1[i, j] = byteG_ratio[i * 768 * 3 + j * 3];
                    if (G_Ratio1[i, j] == 255)
                    {
                        gcount[0]++;
                    }
                }
            }
            for (i = 0; i < 128; i++)   // Second 128 by 128 part of image (128 to 255)
            {
                for (j = 0; j < 127; j++)
                {
                    coocH2[byteHue[i * 768 * 3 + 128 * 3 + j * 3], byteHue[i * 768 * 3 + 128 * 3 + j * 3 + 3]] = coocH2[byteHue[i * 768 * 3 + 128 * 3 + j * 3], byteHue[i * 768 * 3 + 128 * 3 + j * 3 + 3]] + 1;
                    coocH2[byteHue[i * 768 * 3 + 128 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 128 * 3 + j * 3]] = coocH2[byteHue[i * 768 * 3 + 128 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 128 * 3 + j * 3]] + 1;
                    coocS2[byteSat[i * 768 * 3 + 128 * 3 + j * 3], byteSat[i * 768 * 3 + 128 * 3 + j * 3 + 3]] = coocS2[byteSat[i * 768 * 3 + 128 * 3 + j * 3], byteSat[i * 768 * 3 + 128 * 3 + j * 3 + 3]] + 1;
                    coocS2[byteSat[i * 768 * 3 + 128 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 128 * 3 + j * 3]] = coocS2[byteSat[i * 768 * 3 + 128 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 128 * 3 + j * 3]] + 1;
                    // Second 128 by 128 part of G_Ratio Image
                    G_Ratio2[i, j] = byteG_ratio[i * 768 * 3 + 128 * 3 + j * 3];
                    if (G_Ratio2[i, j] == 255)
                    {
                        gcount[1]++;
                    }
                }
            }
            for (i = 0; i < 128; i++)   // Third 128 by 128 part of image (255 to 383)
            {

                for (j = 0; j < 127; j++)
                {
                    coocH3[byteHue[i * 768 * 3 + 256 * 3 + j * 3], byteHue[i * 768 * 3 + 256 * 3 + j * 3 + 3]] = coocH3[byteHue[i * 768 * 3 + 256 * 3 + j * 3], byteHue[i * 768 * 3 + 256 * 3 + j * 3 + 3]] + 1;
                    coocH3[byteHue[i * 768 * 3 + 256 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 256 * 3 + j * 3]] = coocH3[byteHue[i * 768 * 3 + 256 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 256 * 3 + j * 3]] + 1;
                    coocS3[byteSat[i * 768 * 3 + 256 * 3 + j * 3], byteSat[i * 768 * 3 + 256 * 3 + j * 3 + 3]] = coocS3[byteSat[i * 768 * 3 + 256 * 3 + j * 3], byteSat[i * 768 * 3 + 256 * 3 + j * 3 + 3]] + 1;
                    coocS3[byteSat[i * 768 * 3 + 256 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 256 * 3 + j * 3]] = coocS3[byteSat[i * 768 * 3 + 256 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 256 * 3 + j * 3]] + 1;
                    // Third 128 by 128 part of G_Ratio Image
                    G_Ratio3[i, j] = byteG_ratio[i * 768 * 3 + 256 * 3 + j * 3];
                    if (G_Ratio3[i, j] == 255)
                    {
                        gcount[2]++;
                    }
                }
            }
            for (i = 0; i < 128; i++)   // Fourth 128 by 128 part of image (383 to 511)
            {

                for (j = 0; j < 127; j++)
                {
                    coocH4[byteHue[i * 768 * 3 + 384 * 3 + j * 3], byteHue[i * 768 * 3 + 384 * 3 + j * 3 + 3]] = coocH4[byteHue[i * 768 * 3 + 384 * 3 + j * 3], byteHue[i * 768 * 3 + 384 * 3 + j * 3 + 3]] + 1;
                    coocH4[byteHue[i * 768 * 3 + 384 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 384 * 3 + j * 3]] = coocH4[byteHue[i * 768 * 3 + 384 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 384 * 3 + j * 3]] + 1;
                    coocS4[byteSat[i * 768 * 3 + 384 * 3 + j * 3], byteSat[i * 768 * 3 + 384 * 3 + j * 3 + 3]] = coocS4[byteSat[i * 768 * 3 + 384 * 3 + j * 3], byteSat[i * 768 * 3 + 384 * 3 + j * 3 + 3]] + 1;
                    coocS4[byteSat[i * 768 * 3 + 384 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 384 * 3 + j * 3]] = coocS4[byteSat[i * 768 * 3 + 384 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 384 * 3 + j * 3]] + 1;
                    // Fourth 128 by 128 part of G_ratio Image
                    G_Ratio4[i, j] = byteG_ratio[i * 768 * 3 + 384 * 3 + j * 3];
                    if (G_Ratio4[i, j] == 255)
                    {
                        gcount[3]++;
                    }
                }
            }
            for (i = 0; i < 128; i++)   // Fifth 128 by 128 part of image (383 to 511)
            {
                for (j = 0; j < 127; j++)
                {
                    coocH5[byteHue[i * 768 * 3 + 512 * 3 + j * 3], byteHue[i * 768 * 3 + 512 * 3 + j * 3 + 3]] = coocH5[byteHue[i * 768 * 3 + 512 * 3 + j * 3], byteHue[i * 768 * 3 + 512 * 3 + j * 3 + 3]] + 1;
                    coocH5[byteHue[i * 768 * 3 + 512 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 512 * 3 + j * 3]] = coocH5[byteHue[i * 768 * 3 + 512 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 512 * 3 + j * 3]] + 1;
                    coocS5[byteSat[i * 768 * 3 + 512 * 3 + j * 3], byteSat[i * 768 * 3 + 512 * 3 + j * 3 + 3]] = coocS5[byteSat[i * 768 * 3 + 512 * 3 + j * 3], byteSat[i * 768 * 3 + 512 * 3 + j * 3 + 3]] + 1;
                    coocS5[byteSat[i * 768 * 3 + 512 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 512 * 3 + j * 3]] = coocS5[byteSat[i * 768 * 3 + 512 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 512 * 3 + j * 3]] + 1;
                    // Fifth 128 by 128 part of G_Ratio image
                    G_Ratio5[i, j] = byteG_ratio[i * 768 * 3 + 512 * 3 + j * 3];
                    if (G_Ratio5[i, j] == 255)
                    {
                        gcount[4]++;
                    }
                }
            }
            for (i = 0; i < 128; i++)   // Sixth 128 by 128 part of image (383 to 511)
            {
                for (j = 0; j < 127; j++)
                {
                    coocH6[byteHue[i * 768 * 3 + 640 * 3 + j * 3], byteHue[i * 768 * 3 + 640 * 3 + j * 3 + 3]] = coocH6[byteHue[i * 768 * 3 + 640 * 3 + j * 3], byteHue[i * 768 * 3 + 640 * 3 + j * 3 + 3]] + 1;
                    coocH6[byteHue[i * 768 * 3 + 640 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 640 * 3 + j * 3]] = coocH6[byteHue[i * 768 * 3 + 640 * 3 + j * 3 + 3], byteHue[i * 768 * 3 + 640 * 3 + j * 3]] + 1;
                    coocS6[byteSat[i * 768 * 3 + 640 * 3 + j * 3], byteSat[i * 768 * 3 + 640 * 3 + j * 3 + 3]] = coocS6[byteSat[i * 768 * 3 + 640 * 3 + j * 3], byteSat[i * 768 * 3 + 640 * 3 + j * 3 + 3]] + 1;
                    coocS6[byteSat[i * 768 * 3 + 640 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 640 * 3 + j * 3]] = coocS6[byteSat[i * 768 * 3 + 640 * 3 + j * 3 + 3], byteSat[i * 768 * 3 + 640 * 3 + j * 3]] + 1;
                    // Sixth 128 by 128 part of G_Ratio Image
                    G_Ratio6[i, j] = byteG_ratio[i * 768 * 3 + 640 * 3 + j * 3];

                    if (G_Ratio6[i, j] == 255)
                    {
                        gcount[5]++;
                    }
                }
            }
            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {   // Total No . of pairs formed by 768*128 image are 196352. However, total number of pairs formed by 128*128 image are 32512
                    coocH1[i, j] = (coocH1[i, j] / 32512);
                    coocH2[i, j] = (coocH2[i, j] / 32512);
                    coocH3[i, j] = (coocH3[i, j] / 32512);
                    coocH4[i, j] = (coocH4[i, j] / 32512);
                    coocH5[i, j] = (coocH5[i, j] / 32512);
                    coocH6[i, j] = (coocH6[i, j] / 32512);
                    coocS1[i, j] = (coocS1[i, j] / 32512);
                    coocS2[i, j] = (coocS2[i, j] / 32512);
                    coocS3[i, j] = (coocS3[i, j] / 32512);
                    coocS4[i, j] = (coocS4[i, j] / 32512);
                    coocS5[i, j] = (coocS5[i, j] / 32512);
                    coocS6[i, j] = (coocS6[i, j] / 32512);
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(byteHue, 0, ptr, byteHue.Length);
            SourceImage.UnlockBits(bmpData);
            bmpData = null;
            byteColor = null;
            byteHue = null;
            // Textural features calculation
            double[] Px_H1 = new double[256];   // Marginal Probability matrices
            double[] Px_H2 = new double[256];
            double[] Px_H3 = new double[256];
            double[] Px_H4 = new double[256];
            double[] Px_H5 = new double[256];
            double[] Px_H6 = new double[256];
            double[] Px_S1 = new double[256];
            double[] Px_S2 = new double[256];
            double[] Px_S3 = new double[256];
            double[] Px_S4 = new double[256];
            double[] Px_S5 = new double[256];
            double[] Px_S6 = new double[256];

            double[] Psum_S1 = new double[511];  // Sum Matrix P(i+j)=P(255+255)
            double[] Psum_S2 = new double[511];
            double[] Psum_S3 = new double[511];
            double[] Psum_S4 = new double[511];
            double[] Psum_S5 = new double[511];
            double[] Psum_S6 = new double[511];
            double Hxy2_S1, Hxy2_S2, Hxy2_S3, Hxy2_S4, Hxy2_S5, Hxy2_S6;

            // features variables;
            double[,] hf = new double[6, 3];
            double[,] sf = new double[6, 7];
            // Peltarion Synpse Deployment
            WorkArea0 net = new WorkArea0();
            Matrix sample = new Matrix(6, 10);   // Make new Matrix

            int[] dis_unit = new int[6];           // Decision Unit for indvidual unit image 
            int[] g_dis_unit = new int[6];         // Decision Unit for indvidual unit image using G_ratio 
            int count1 = 0;                        // Counter for first three unit images to control first nozzle
            int g_count1 = 0;                      // Counter for the first three G_ratio Images for first three nozzle
            int count2 = 0;                        // Counter for second three unit images to control second nozzle
            int g_count2 = 0;                      // Counter for the first three G_ratio Images for first three nozzle

            // Marginal probability array intialization 
            for (i = 0; i < 256; i++)
            {
                Px_H1[i] = Px_H2[i] = Px_H3[i] = Px_H4[i] = Px_H5[i] = Px_H6[i] = 0;
                Px_S1[i] = Px_S2[i] = Px_S3[i] = Px_S4[i] = Px_S5[i] = Px_S6[i] = 0;
            }

            for (i = 0; i < 511; i++) // Sum Matrix Intialization
            {

                Psum_S1[i] = Psum_S2[i] = Psum_S3[i] = Psum_S4[i] = Psum_S5[i] = Psum_S6[i] = 0;
            }

            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    Px_H1[i] = Px_H1[i] + coocH1[i, j];
                    Px_H2[i] = Px_H2[i] + coocH2[i, j];
                    Px_H3[i] = Px_H3[i] + coocH3[i, j];
                    Px_H4[i] = Px_H4[i] + coocH4[i, j];
                    Px_H5[i] = Px_H5[i] + coocH5[i, j];
                    Px_H6[i] = Px_H6[i] + coocH6[i, j];
                    Px_S1[i] = Px_S1[i] + coocS1[i, j];
                    Px_S2[i] = Px_S2[i] + coocS2[i, j];
                    Px_S3[i] = Px_S3[i] + coocS3[i, j];
                    Px_S4[i] = Px_S4[i] + coocS4[i, j];
                    Px_S5[i] = Px_S5[i] + coocS5[i, j];
                    Px_S6[i] = Px_S6[i] + coocS6[i, j];
                    K1 = i + j;
                    Psum_S1[K1] = Psum_S1[K1] + coocS1[i, j];
                    Psum_S2[K1] = Psum_S2[K1] + coocS2[i, j];
                    Psum_S3[K1] = Psum_S3[K1] + coocS3[i, j];
                    Psum_S4[K1] = Psum_S4[K1] + coocS4[i, j];
                    Psum_S5[K1] = Psum_S5[K1] + coocS5[i, j];
                    Psum_S6[K1] = Psum_S6[K1] + coocS6[i, j];
                }
            }
            // Contrast Intializtion for six saturation images
            sf[0, 0] = 0;
            sf[1, 0] = 0;
            sf[2, 0] = 0;
            sf[3, 0] = 0;
            sf[4, 0] = 0;
            sf[5, 0] = 0;
            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    sf[0, 0] = sf[0, 0] + (i - j) * (i - j) * coocS1[i, j];
                    sf[1, 0] = sf[1, 0] + (i - j) * (i - j) * coocS2[i, j];
                    sf[2, 0] = sf[2, 0] + (i - j) * (i - j) * coocS3[i, j];
                    sf[3, 0] = sf[3, 0] + (i - j) * (i - j) * coocS4[i, j];
                    sf[4, 0] = sf[4, 0] + (i - j) * (i - j) * coocS5[i, j];
                    sf[5, 0] = sf[5, 0] + (i - j) * (i - j) * coocS6[i, j];
                }
            }
            // IDM Intialization of Hue Six images
            hf[0, 0] = 0;
            hf[1, 0] = 0;
            hf[2, 0] = 0;
            hf[3, 0] = 0;
            hf[4, 0] = 0;
            hf[5, 0] = 0;

            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    hf[0, 0] = hf[0, 0] + coocH1[i, j] / (1 + (i - j) * (i - j));
                    hf[1, 0] = hf[1, 0] + coocH2[i, j] / (1 + (i - j) * (i - j));
                    hf[2, 0] = hf[2, 0] + coocH3[i, j] / (1 + (i - j) * (i - j));
                    hf[3, 0] = hf[3, 0] + coocH4[i, j] / (1 + (i - j) * (i - j));
                    hf[4, 0] = hf[4, 0] + coocH5[i, j] / (1 + (i - j) * (i - j));
                    hf[5, 0] = hf[5, 0] + coocH6[i, j] / (1 + (i - j) * (i - j));
                }
            }
            // Homogeneity Initialization of Hue six images only
            hf[0, 1] = 0;
            hf[1, 1] = 0;
            hf[2, 1] = 0;
            hf[3, 1] = 0;
            hf[4, 1] = 0;
            hf[5, 1] = 0;

            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    hf[0, 1] = hf[0, 1] + coocH1[i, j] / (1 + Math.Abs(i - j));
                    hf[1, 1] = hf[1, 1] + coocH2[i, j] / (1 + Math.Abs(i - j));
                    hf[2, 1] = hf[2, 1] + coocH3[i, j] / (1 + Math.Abs(i - j));
                    hf[3, 1] = hf[3, 1] + coocH4[i, j] / (1 + Math.Abs(i - j));
                    hf[4, 1] = hf[4, 1] + coocH5[i, j] / (1 + Math.Abs(i - j));
                    hf[5, 1] = hf[5, 1] + coocH6[i, j] / (1 + Math.Abs(i - j));
                }
            }
            // Averge Initialization for Six hue and Six saturation Images 
            hf[0, 2] = 0;
            hf[1, 2] = 0;
            hf[2, 2] = 0;
            hf[3, 2] = 0;
            hf[4, 2] = 0;
            hf[5, 2] = 0;
            sf[0, 1] = 0;
            sf[1, 1] = 0;
            sf[2, 1] = 0;
            sf[3, 1] = 0;
            sf[4, 1] = 0;
            sf[5, 1] = 0;

            for (i = 0; i < 256; i++)
            {
                hf[0, 2] = hf[0, 2] + i * Px_H1[i];
                hf[1, 2] = hf[1, 2] + i * Px_H2[i];
                hf[2, 2] = hf[2, 2] + i * Px_H3[i];
                hf[3, 2] = hf[3, 2] + i * Px_H4[i];
                hf[4, 2] = hf[4, 2] + i * Px_H5[i];
                hf[5, 2] = hf[5, 2] + i * Px_H6[i];
                sf[0, 1] = sf[0, 1] + i * Px_S1[i];
                sf[1, 1] = sf[1, 1] + i * Px_S2[i];
                sf[2, 1] = sf[2, 1] + i * Px_S3[i];
                sf[3, 1] = sf[3, 1] + i * Px_S4[i];
                sf[4, 1] = sf[4, 1] + i * Px_S5[i];
                sf[5, 1] = sf[5, 1] + i * Px_S6[i];
            }
            // Variance Intialization of six saturation Images
            sf[0, 2] = 0;
            sf[1, 2] = 0;
            sf[2, 2] = 0;
            sf[3, 2] = 0;
            sf[4, 2] = 0;
            sf[5, 2] = 0;

            for (i = 0; i < 256; i++)
            {
                sf[0, 2] = sf[0, 2] + (i - sf[0, 1]) * (i - sf[0, 1]) * Px_S1[i];
                sf[1, 2] = sf[1, 2] + (i - sf[1, 1]) * (i - sf[1, 1]) * Px_S2[i];
                sf[2, 2] = sf[2, 2] + (i - sf[2, 1]) * (i - sf[2, 1]) * Px_S3[i];
                sf[3, 2] = sf[3, 2] + (i - sf[3, 1]) * (i - sf[3, 1]) * Px_S4[i];
                sf[4, 2] = sf[4, 2] + (i - sf[4, 1]) * (i - sf[4, 1]) * Px_S5[i];
                sf[5, 2] = sf[5, 2] + (i - sf[5, 1]) * (i - sf[5, 1]) * Px_S6[i];
            }
            // Correlation Intilaization for six saturation images
            sf[0, 3] = 0;
            sf[1, 3] = 0;
            sf[2, 3] = 0;
            sf[3, 3] = 0;
            sf[4, 3] = 0;
            sf[5, 3] = 0;

            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    sf[0, 3] = sf[0, 3] + i * j * coocS1[i, j];
                    sf[1, 3] = sf[1, 3] + i * j * coocS2[i, j];
                    sf[2, 3] = sf[2, 3] + i * j * coocS3[i, j];
                    sf[3, 3] = sf[3, 3] + i * j * coocS4[i, j];
                    sf[4, 3] = sf[4, 3] + i * j * coocS5[i, j];
                    sf[5, 3] = sf[5, 3] + i * j * coocS6[i, j];
                }
            }

            sf[0, 3] = (sf[0, 3] - sf[0, 1] * sf[0, 1]) / (sf[0, 2] + 0.0000001);     // 0.00000001 is used to prevent division by 0
            sf[1, 3] = (sf[1, 3] - sf[1, 1] * sf[1, 1]) / (sf[1, 2] + 0.0000001);
            sf[2, 3] = (sf[2, 3] - sf[2, 1] * sf[2, 1]) / (sf[2, 2] + 0.0000001);
            sf[3, 3] = (sf[3, 3] - sf[3, 1] * sf[3, 1]) / (sf[3, 2] + 0.0000001);
            sf[4, 3] = (sf[4, 3] - sf[4, 1] * sf[4, 1]) / (sf[4, 2] + 0.0000001);
            sf[5, 3] = (sf[5, 3] - sf[5, 1] * sf[5, 1]) / (sf[5, 2] + 0.0000001);

            // Intializing Entropy for six saturation imges
            sf[0, 4] = 0;
            sf[1, 4] = 0;
            sf[2, 4] = 0;
            sf[3, 4] = 0;
            sf[4, 4] = 0;
            sf[5, 4] = 0;
            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    sf[0, 4] = sf[0, 4] - coocS1[i, j] * Math.Log(coocS1[i, j] + 0.0000001);
                    sf[1, 4] = sf[1, 4] - coocS2[i, j] * Math.Log(coocS2[i, j] + 0.0000001);
                    sf[2, 4] = sf[2, 4] - coocS3[i, j] * Math.Log(coocS3[i, j] + 0.0000001);
                    sf[3, 4] = sf[3, 4] - coocS4[i, j] * Math.Log(coocS4[i, j] + 0.0000001);
                    sf[4, 4] = sf[4, 4] - coocS5[i, j] * Math.Log(coocS5[i, j] + 0.0000001);
                    sf[5, 4] = sf[5, 4] - coocS6[i, j] * Math.Log(coocS6[i, j] + 0.0000001);
                }
            }
            // Intializing Sum Entropy for six saturation images
            sf[0, 5] = 0;
            sf[1, 5] = 0;
            sf[2, 5] = 0;
            sf[3, 5] = 0;
            sf[4, 5] = 0;
            sf[5, 5] = 0;

            for (i = 0; i < 511; i++)
            {

                sf[0, 5] = sf[0, 5] - Psum_S1[i] * Math.Log(Psum_S1[i] + 0.0000001);
                sf[1, 5] = sf[1, 5] - Psum_S2[i] * Math.Log(Psum_S2[i] + 0.0000001);
                sf[2, 5] = sf[2, 5] - Psum_S3[i] * Math.Log(Psum_S3[i] + 0.0000001);
                sf[3, 5] = sf[3, 5] - Psum_S4[i] * Math.Log(Psum_S4[i] + 0.0000001);
                sf[4, 5] = sf[4, 5] - Psum_S5[i] * Math.Log(Psum_S5[i] + 0.0000001);
                sf[5, 5] = sf[5, 5] - Psum_S6[i] * Math.Log(Psum_S6[i] + 0.0000001);
            }

            // Initialization of Hxy-2 for six saturation images             
            Hxy2_S1 = 0; Hxy2_S2 = 0; Hxy2_S3 = 0; Hxy2_S4 = 0; Hxy2_S5 = 0; Hxy2_S6 = 0;
            for (i = 0; i < 256; i++)
            {
                for (j = 0; j < 256; j++)
                {
                    Hxy2_S1 = Hxy2_S1 - Px_S1[i] * Px_S1[j] * Math.Log(Px_S1[i] * Px_S1[j] + 0.0000001);
                    Hxy2_S2 = Hxy2_S2 - Px_S2[i] * Px_S2[j] * Math.Log(Px_S2[i] * Px_S2[j] + 0.0000001);
                    Hxy2_S3 = Hxy2_S3 - Px_S3[i] * Px_S3[j] * Math.Log(Px_S3[i] * Px_S3[j] + 0.0000001);
                    Hxy2_S4 = Hxy2_S4 - Px_S4[i] * Px_S4[j] * Math.Log(Px_S4[i] * Px_S4[j] + 0.0000001);
                    Hxy2_S5 = Hxy2_S5 - Px_S5[i] * Px_S5[j] * Math.Log(Px_S5[i] * Px_S5[j] + 0.0000001);
                    Hxy2_S6 = Hxy2_S6 - Px_S6[i] * Px_S6[j] * Math.Log(Px_S6[i] * Px_S6[j] + 0.0000001);
                }
            }
            // Six Saturation images and their information correlation-2
            sf[0, 6] = Math.Sqrt(1 - Math.Exp(-2.0 * (Hxy2_S1 - sf[0, 4])));
            sf[1, 6] = Math.Sqrt(1 - Math.Exp(-2.0 * (Hxy2_S2 - sf[1, 4])));
            sf[2, 6] = Math.Sqrt(1 - Math.Exp(-2.0 * (Hxy2_S3 - sf[2, 4])));
            sf[3, 6] = Math.Sqrt(1 - Math.Exp(-2.0 * (Hxy2_S4 - sf[3, 4])));
            sf[4, 6] = Math.Sqrt(1 - Math.Exp(-2.0 * (Hxy2_S5 - sf[4, 4])));
            sf[5, 6] = Math.Sqrt(1 - Math.Exp(-2.0 * (Hxy2_S6 - sf[5, 4])));

            // Peltarion based program begins from here
            for (i = 0; i < 6; i++)
            {
                //Transfer the outputs of CCM to Peltarion input Matrix
                sample[i, 0] = 1;
                sample[i, 1] = 0;
                sample[i, 2] = hf[i, 0];
                sample[i, 3] = hf[i, 1];
                sample[i, 4] = hf[i, 2];
                sample[i, 5] = sf[i, 0];
                sample[i, 6] = sf[i, 1];
                sample[i, 7] = sf[i, 3];
                sample[i, 8] = sf[i, 5];
                sample[i, 9] = sf[i, 6];
            }
            net.Input_CSV = sample;        // set the data
            net.StepEpoch();                    // run system

            Matrix output = net.FunctionLayer4_Port0; // Store results

            // Reset every decision Unit to 0
            for (i = 0; i < 6; i++)
            {
                dis_unit[i] = 0;
                g_dis_unit[i] = 0;
            }

            // Comparision statement to find Goldenrod
            for (i = 0; i < 6; i++)
            {

                if (output[i, 0] > output[i, 1])
                {
                    dis_unit[i] = 1;
                }
                else
                {
                    dis_unit[i] = 0;
                }
            }
            // Comparision statement to find Goldenrod using G_ratio Algorithm
            for (i = 0; i < 6; i++)
            {
                if (gcount[i] > Threshold + 6200)
                {
                    g_dis_unit[i] = 1;
                }
                else
                {
                    g_dis_unit[i] = 0;
                }
            }

            // counter for first three unit images
            for (i = 0; i < 3; i++)
            {
                if (dis_unit[i] == 1)
                {
                    count1++;
                }
            }
            // counter for second three unit images
            for (i = 3; i < 6; i++)
            {
                if (dis_unit[i] == 1)
                {
                    count2++;
                }
            }
            // counter for first three unit images
            for (i = 0; i < 3; i++)
            {
                if (g_dis_unit[i] == 1)
                {
                    g_count1++;
                }
            }
            // counter for second three unit images
            for (i = 3; i < 6; i++)
            {
                if (g_dis_unit[i] == 1)
                {
                    g_count2++;
                }
            }
            // Opening of the Labjack 
            U3 u3 = new U3(LJUD.CONNECTION.USB, "1", true);

            // Nozzle No:1
            if (count1 > 0|| g_count1 > 0)
            {
                // open the nozzle by using labjack program
                LJUD.eDO(u3.ljhandle, Camno * 2 + 6, 0);
                Nozzle_1 = 1;
            }
            else
            {
                // Keep the nozzle to close condition
                LJUD.eDO(u3.ljhandle, Camno * 2 + 6, 1);
                Nozzle_1 = 0;
            }
            // Nozzle No:2
            if (count2 >0 || g_count2 > 0)
            {
                // open the nozzle by using labjack program
                LJUD.eDO(u3.ljhandle, Camno * 2 + 7, 0);
                Nozzle_2 = 1;
            }
            else
            {
                // Keep the nozzle to close condition
                LJUD.eDO(u3.ljhandle, Camno * 2 + 7, 1);
                Nozzle_2 = 0;
            }
            return true;
            }
        }
    }