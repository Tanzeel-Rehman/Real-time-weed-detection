using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;


namespace WindowsForms
{
    public partial class uEye_DotNet_Simple_Live : Form
    {

        delegate void CT_Delegate();
        const int MAX_CAM = 4;              // Maximum Number of Cameras.
        public Int32[] s32CamID = new int[MAX_CAM];   // Array of Max Camera ID handelers.
        public IntPtr[] displayHandle = new IntPtr[MAX_CAM];   // Array of Max Display Window Handelers.
        public Int32[] s32MemId = new Int32[MAX_CAM];
        public Int32[] s32Height = new Int32[MAX_CAM];
        public Int32[] s32Width = new Int32[MAX_CAM];
        public uEye.Camera[] Camera_Handler = new uEye.Camera[MAX_CAM];
        public bool[] bLive = new bool[MAX_CAM];     // Image Acquisition,Memory handling and Camera Initilaization
        public bool bStop;
        public bool bEnable;             // Enable, Disable Error Report
        public int m_CamCount;          // Number of Active Cameras
        public int Value;              //  To count the Number of Cameras Coneected to PC
        public Int32 ID;
        public bool bCam1, bCam2, bCam3, bCam4 = true;
        public string Field_Name;
        public double exposure_Time;

        // Variable Intialization for the Communication Control and Velocity
        public bool bGPS_Com = false;
        public char[] GPS_array = new char[512];
        public Double Current_Velocity;
        public Double m_vel;
        double bearing = 0;
        double lat,longi=0.0;

        // Variable Intialization for Nozzle status
        int[] Nozzle_Status = new int[8];

        public uEye_DotNet_Simple_Live()
        {
            InitializeComponent();

            displayHandle[0] = DisplayWindow0.Handle;    //Display Handeler for 1st Picture Box (Camera)
            displayHandle[1] = DisplayWindow1.Handle;    //Display Handeler for 2nd Picture Box (Camera)
            displayHandle[2] = DisplayWindow2.Handle;    //Display Handeler for 3rd Picture Box (Camera)
            displayHandle[3] = DisplayWindow3.Handle;    //Display Handeler for 4th Picture Box (Camera)
        }

        private void Button_Camera_Click(object sender, EventArgs e)
        {
            uEye.Defines.Status status_Return = 0;
            // Counting the number of devices counnected to PC
            status_Return = uEye.Info.Camera.GetNumberOfDevices(out Value);
            if (status_Return != uEye.Defines.Status.Success)
            {
                string message = "Can not count number of devices connected to the PC";
                string caption = "Error Occured";
                MessageBoxButtons Buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult = MessageBox.Show(message, caption, Buttons, MessageBoxIcon.Error);
                if (DialogResult == DialogResult.Abort || DialogResult == DialogResult.Retry || DialogResult == DialogResult.Ignore)
                {
                    Environment.Exit(-1);
                }
            }
            else
            {
                m_CamCount = Value;
                Rich_Text_Box_CamCount.Text += m_CamCount;
            }
            if (m_CamCount > MAX_CAM)
            {
                string message = "More than 4 Cameras are Connected. Maximum 4 Can be Used with this System.\nDo You Want to Continue?";
                string Caption = "Extra Cameras Found";
                MessageBoxButtons Buttons = MessageBoxButtons.YesNoCancel;
                DialogResult = MessageBox.Show(message, Caption, Buttons, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.No || DialogResult == DialogResult.Cancel)
                {
                    Environment.Exit(-1);
                }
            }
            //Open Camera and Start Live Video
            for (int i = 0; i < m_CamCount; i++)
            {
                Camera_Handler[i] = new uEye.Camera();
                s32CamID[i] = i + 1;
                status_Return = Camera_Handler[i].Init(s32CamID[i]);
                if (status_Return != uEye.Defines.Status.Success)
                {
                    // Pop up with box Showing this message

                    DialogResult = MessageBox.Show("Camera Initialization Failed", "Error Occured", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    if (DialogResult == DialogResult.Retry || DialogResult == DialogResult.Cancel)
                    {
                        Environment.Exit(-1);
                    }
                }
                // Allocate Memory
                s32Width[i] = (768);
                s32Height[i] = (128);
                Camera_Handler[i].Size.AOI.Set(200, 200, s32Width[i], s32Height[i]);
                status_Return = Camera_Handler[i].Memory.Allocate(s32Width[i], s32Height[i], 24, out s32MemId[i]);
                Camera_Handler[i].Memory.SetActive(s32MemId[i]);
                if (status_Return != uEye.Defines.Status.Success)
                {
                    DialogResult = MessageBox.Show("Memory Allocation Failed.", "Error Occured", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    if (DialogResult == DialogResult.Retry || DialogResult == DialogResult.Cancel)
                    {
                        Environment.Exit(-1);
                    }
                }
                // Image Acquisition and Timer event raising
                if (Camera_Handler[i].Acquisition.Freeze() == uEye.Defines.Status.Success)
                {
                    bLive[i] = true;
                    Timer.Tick += new System.EventHandler(Timer_Tick);
                }
                // Error Report Generator
                status_Return = Camera_Handler[i].Information.GetEnableErrorReport(out bEnable);
                if (status_Return != uEye.Defines.Status.Success)
                {
                    MessageBox.Show("ERROR: Can not Enable the automaic uEye error report");
                }
                else
                {
                    bEnable = true;
                }
            }
            // To Prevent the Camera initialization again if user pressed it again 
            Button_Camera.Enabled = false;
            // List of Text Boxes for Displaying the Cam ID for indvidual window.
            TextBox_CamID0.Text = TextBox_CamID0_Processed.Text += "ID:" + s32CamID[0];
            TextBox_CamID1.Text = TextBox_CamID1_Processed.Text += "ID:" + s32CamID[1];
            TextBox_CamID2.Text = TextBox_CamID2_Processed.Text += "ID:" + s32CamID[2];
            TextBox_CamID3.Text = TextBox_CamID3_Processed.Text += "ID:" + s32CamID[3];

            // Serial Information Display
            uEye.Types.CameraInformation[] SerialNumber = new uEye.Types.CameraInformation[MAX_CAM];
            uEye.Info.Camera.GetCameraList(out SerialNumber);
            foreach (uEye.Types.CameraInformation info in SerialNumber)
            {
                Camera1_SerialNum.Text = Camera1_SerialNum_Processed.Text = "SN:" + info.SerialNumber;
                Camera2_SerialNum.Text = Camera2_SerialNum_Processed .Text = "SN:" + info.SerialNumber;
                Camera3_SerialNum.Text = Camera3_SerialNum_Processed.Text = "SN:" + info.SerialNumber;
                Camera4_SerialNum.Text = Camera4_SerialNum_Processed.Text ="SN:" + info.SerialNumber;
            }

            // Control to Handel Limited number of cameras and to raise the display event accordingly
            if (s32CamID[0] == 1)
            {
                Camera_Handler[0].EventFrame += FrameEvent0;

            }
            else
            {
                MessageBox.Show("Can not find Camera 1");
            }
            if (s32CamID[1] == 2)
            {
                Camera_Handler[1].EventFrame += FrameEvent1;
            }
            else
            {
                MessageBox.Show("Can not find Camera 2");

            }
            if (s32CamID[2] == 3)
            {
                Camera_Handler[2].EventFrame += FrameEvent2;
            }
            else
            {
                MessageBox.Show("Can not find Camera 3");
            }
            if (s32CamID[3] == 4)
            {
                Camera_Handler[3].EventFrame += FrameEvent3;
            }
            else
            {
                MessageBox.Show("Can not find Camera 4");

            }

        }
        public void FrameEvent0(object sender, EventArgs e)
        {
            Bitmap bitmap_Image = new Bitmap(s32Width[0], s32Height[0], PixelFormat.Format24bppRgb);
            Camera_Handler[0] = sender as uEye.Camera;
            Camera_Handler[0].Display.Mode.Set(uEye.Defines.DisplayMode.DiB);
            Camera_Handler[0].AutoFeatures.Software.Gain.SetMax(50);
            Camera_Handler[0].AutoFeatures.Software.Shutter.SetMax(2);
            Camera_Handler[0].AutoFeatures.Software.Gain.SetEnable(true);
            Camera_Handler[0].AutoFeatures.Software.Shutter.SetEnable(true);
            Camera_Handler[0].AutoFeatures.Software.WhiteBalance.SetEnable(true);
            Camera_Handler[0].Timing.Exposure.Get(out exposure_Time); // TO extract the informaton about the current exposure time, Use this exposure time for deciding about the sunny or cloudy conditions
            Console.WriteLine(exposure_Time);
            if (exposure_Time > 1.5)
            {
                Camera_Handler[0].AutoFeatures.Software.Reference.Set(90);    // Sunny Conditions 
            }
            else
            {
                Camera_Handler[0].AutoFeatures.Software.Reference.Set(128);  // Cloudy Conditions  
            }
            Camera_Handler[0].Display.Render(s32MemId[0], displayHandle[0], uEye.Defines.DisplayRenderMode.FitToWindow); // Statement for displaying the image in Picture BOX (DisplayWindow)   
            Camera_Handler[0].Memory.ToBitmap(s32MemId[0], out bitmap_Image);
            CCM.RGB2HSI(bitmap_Image, 1, 128,out Nozzle_Status[0],out Nozzle_Status[1]);
            DisplayWindow4.Image = bitmap_Image;
            Console.WriteLine(Nozzle_Status[0]);
            Console.WriteLine(Nozzle_Status[1]);
            if (SerialPort1.IsOpen)
            {
                GPSData(out lat, out longi, out m_vel, out bearing);
                Console.WriteLine(lat);
                Console.WriteLine(longi);
                Console.WriteLine(bearing);
            }
           
        }
        public void FrameEvent1(object sender, EventArgs e)
        {
            Bitmap bitmap_Image1 = new Bitmap(s32Width[1], s32Height[1], PixelFormat.Format24bppRgb);
            Camera_Handler[1] = sender as uEye.Camera;
            Camera_Handler[1].Display.Mode.Set(uEye.Defines.DisplayMode.DiB);
            Camera_Handler[1].AutoFeatures.Software.Gain.SetMax(50);
            Camera_Handler[1].AutoFeatures.Software.Shutter.SetMax(2);
            Camera_Handler[1].AutoFeatures.Software.Gain.SetEnable(true);
            Camera_Handler[1].AutoFeatures.Software.Shutter.SetEnable(true);
            Camera_Handler[1].AutoFeatures.Software.WhiteBalance.SetEnable(true);
            Camera_Handler[1].AutoFeatures.Software.Reference.Set(128);
            Camera_Handler[1].Display.Render(s32MemId[1], displayHandle[1], uEye.Defines.DisplayRenderMode.FitToWindow); // Statement for displaying the image in Picture BOX (DisplayWindow)
            Camera_Handler[1].Memory.ToBitmap(s32MemId[1], out bitmap_Image1);
            CCM.RGB2HSI(bitmap_Image1, 2, 128,out Nozzle_Status[2], out Nozzle_Status[3]);
            DisplayWindow5.Image = bitmap_Image1;
           if (SerialPort1.IsOpen)
            {
               // GPSData(out lat, out longi, out m_vel, out bearing);
                Console.WriteLine(lat);
                Console.WriteLine(longi);
                Console.WriteLine(bearing);
            }
        }
        public void FrameEvent2(object sender, EventArgs e)
        {
            Bitmap bitmap_Image2 = new Bitmap(s32Width[2], s32Height[2], PixelFormat.Format24bppRgb);
            Camera_Handler[2] = sender as uEye.Camera;
            Camera_Handler[2].Display.Mode.Set(uEye.Defines.DisplayMode.DiB);
            Camera_Handler[2].AutoFeatures.Software.Gain.SetMax(50);
            Camera_Handler[2].AutoFeatures.Software.Shutter.SetMax(2);
            Camera_Handler[2].AutoFeatures.Software.Gain.SetEnable(true);
            Camera_Handler[2].AutoFeatures.Software.Shutter.SetEnable(true);
            Camera_Handler[2].AutoFeatures.Software.WhiteBalance.SetEnable(true);
            Camera_Handler[2].AutoFeatures.Software.Reference.Set(128);
            Camera_Handler[2].Display.Render(s32MemId[2], displayHandle[2], uEye.Defines.DisplayRenderMode.FitToWindow); // Statement for displaying the image in Picture BOX (DisplayWindow)
            Camera_Handler[2].Memory.ToBitmap(s32MemId[2], out bitmap_Image2);
            CCM.RGB2HSI(bitmap_Image2, 3, 128, out Nozzle_Status[4], out Nozzle_Status[5]);
            DisplayWindow6.Image = bitmap_Image2;

        }
        public void FrameEvent3(object sender, EventArgs e)
        {
            Bitmap bitmap_Image3 = new Bitmap(s32Width[3], s32Height[3], PixelFormat.Format24bppRgb);
            Camera_Handler[3] = sender as uEye.Camera;
            Camera_Handler[3].Display.Mode.Set(uEye.Defines.DisplayMode.DiB);
            Camera_Handler[3].AutoFeatures.Software.Gain.SetMax(50);
            Camera_Handler[3].AutoFeatures.Software.Shutter.SetMax(2);
            Camera_Handler[3].AutoFeatures.Software.Gain.SetEnable(true);
            Camera_Handler[3].AutoFeatures.Software.Shutter.SetEnable(true);
            Camera_Handler[3].AutoFeatures.Software.WhiteBalance.SetEnable(true);
            Camera_Handler[3].AutoFeatures.Software.Reference.Set(128);
            Camera_Handler[3].Display.Render(s32MemId[3], displayHandle[3], uEye.Defines.DisplayRenderMode.FitToWindow); // Statement for displaying the image in Picture BOX (DisplayWindow)
            Camera_Handler[3].Memory.ToBitmap(s32MemId[1], out bitmap_Image3);
            CCM.RGB2HSI(bitmap_Image3, 4, 128, out Nozzle_Status[6], out Nozzle_Status[7]);
            DisplayWindow7.Image = bitmap_Image3;
        }
        private void Enable_Error_Report_Checked(object sender, EventArgs e)
        {
            for (int i = 0; i < m_CamCount; i++)
            {
                if (bEnable == false)
                {
                    Camera_Handler[i].Information.GetEnableErrorReport(out bEnable);
                    bEnable = true;
                }
                else
                {
                    Camera_Handler[i].Information.GetEnableErrorReport(out bEnable);
                    bEnable = false;
                }
            }
        }

        private void Port_Names_List_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = null;
            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                ComboBox_COM.Items.Add(port);
                //  Console.WriteLine(port);
            }
            if (ports.Length > 0)
            {
             SerialPort1.PortName = ports[0];  // By default select the 2nd port available on particular computer
            }
            else
            {
                DialogResult = MessageBox.Show("No COMs Found on This Computer", "Error in GPS Connecton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (DialogResult == DialogResult.OK)
                {
                    Environment.Exit(1);
                }
            }
        }

        private void CheckBox_GPS_Checked(object sender, EventArgs e)
        {
            if (!bGPS_Com)
            {
                try
                {
                    SerialPort1.Open();
                    this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
                     bGPS_Com = true;
                    Port_Names_List.Enabled = false;
                }
                catch (Exception ex)
                {
                    DialogResult = MessageBox.Show(ex.Message, "Error In GPS Connecton", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (DialogResult == DialogResult.Cancel)
                    {
                        Environment.Exit(1);
                    }
                }
            }
            else
            {
                SerialPort1.Close();
                this.SerialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
                CheckBox_GPS.Text = "CONNECT GPS";
                bGPS_Com = false;
                Port_Names_List.Enabled = true;
                Text_Box_Velocity.Clear();
                GPS_Status_Label.Text = "Not Fixed";
            }
        }

        public void ComboBox_GPS_Collection_SelectedIndexChanges(object sender, EventArgs e)
        {
            // TODO: Add your code for GPS Selection Here
        }


        private void ComboBox_COM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(SerialPort1.PortName.ToLower()).StartsWith("com"))  // In case if the user entered the port name with small alphabets
            {
                SerialPort1.PortName = "COM1";
            }
            if (SerialPort1.IsOpen)
            {
                MessageBox.Show("Can Not Change the Port While Port is Open");

            }
            else
            {
                SerialPort1.PortName = ComboBox_COM.Text;
            }
        }

        private void ComboBox_Baud_Rate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //strings often contain data like integers or times.
            // like int.Parse, we convert strings into low-level types (like ints). 
            //We call Parse, TryParse and Convert.ToInt32. For times, we can use DateTime.Parse.
            SerialPort1.BaudRate = int.Parse(ComboBox_Baud_Rate.Text);
        }
        // create a reuseable method for multiple usage
        public void GPSData(out double lat, out double longi, out double measured_velocity, out double bearing)
        {
            lat = longi = measured_velocity = bearing = 0.0;
            if (SerialPort1.IsOpen)
            {
                string data = SerialPort1.ReadLine();
                string[] strArr = data.Split('$');
                for (int i = 0; i < strArr.Length; i++)
                {
                    string strTemp = strArr[i];
                    string[] NMEA = strTemp.Split(',');
                    if (NMEA[0] == "GPRMC" && NMEA[2] == "A")
                    {

                        if (!String.IsNullOrEmpty(NMEA[3]))
                        {
                            lat = Convert.ToDouble(NMEA[3]);
                            lat = lat / 100;
                            int degree = (int)lat;
                            double minutes = ((lat - degree) * 100) / 60.0;
                            lat = degree + minutes;

                        }
                        if (!String.IsNullOrEmpty(NMEA[5]))
                        {
                            longi = Convert.ToDouble(NMEA[5]);
                            longi = longi / 100;
                            int degree = (int)longi;
                            double minutes = ((longi - degree) * 100) / 60.0;
                            longi = degree + minutes;

                        }
                        if (!String.IsNullOrEmpty(NMEA[7]))
                        {
                            measured_velocity = Convert.ToDouble(NMEA[7]);
                            measured_velocity = 1.852 * measured_velocity;
                        }

                        if (!String.IsNullOrEmpty(NMEA[8]))
                        {
                            bearing = Convert.ToDouble(NMEA[8]); // Collect Directional Data
                        }
                    }
                }
            }
        }

        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Double speed_less = 0.00;
            if (SerialPort1.IsOpen)
            {
                CT_Delegate dt = delegate()
                {
                    //string data = SerialPort1.ReadLine();
                    
                    GPS_Status_Label.Text = "Ok";
                    CheckBox_GPS.Text = "GPS CONNECTED";
                    // check and filter limited speed
                    if (m_vel < 0.015)
                    {
                        Text_Box_Velocity.Text = speed_less.ToString();
                    }
                    else
                    {
                        Text_Box_Velocity.Text = m_vel.ToString();
                    }
                    
                   /* Console.WriteLine(lat);
                    Console.WriteLine(longi);
                    Console.WriteLine(bearing);*/
                    double pitch = 0.0;
                    double tilt=0.0;
                   // pictureBox1.Image = Compass.DrawCompass(bearing, pitch, 80, tilt, 80, pictureBox1.Size);
                };
                this.Invoke(dt);
            }
        }
        public void uEye_DotNet_Simple_Live_Load(object sender, EventArgs e)
        {
            double time = 300;  // Need to comment this timer for real time case 
            double New_Velocity;
            Timer_Velocity_Updating.Interval = 200;  // Velocity data will be updated after every 200 milliseconds
            Timer_Velocity_Updating.Start();
            New_Velocity = ((1000 * Current_Velocity) / 3600);
            // time = ((1000 * 0.27 / New_Velocity) - 51);      // Velocity data for real time case 
            Timer.Interval = (int)time;  // Interval in milliseconds
            // 0.27m 0f the ground surface is covered by 128 pixels of uEYE camera with 3.5mm lens from 1.22m height.
            //Trevelling speed is New_Velocity coming from GPS receiver. 51 milliseconds are subtracted in order to provide 0.102 m buffer. 
            //(Obselete function)where travelling speed is taken as 1.66m/s (i.e. 6km/hr) and 0.9 m of image width is taken as ground foot prints
            // in order to buffer 0.1m distance. 
            Timer.Start();
        }
        private void Timer_Velocity_Updating_Tick(object sender, EventArgs e)
        {            
            /*  Current_Velocity = (1.852 * m_vel);    //1knot= 0.51444 m/s
             // Current_Velocity = (3.6 * Current_Velocity);     // 1 m/s= 3.6km/hr
              Text_Box_Velocity.Text += Current_Velocity.ToString();
              Text_Box_Velocity.Clear();
              Text_Box_Velocity.Text += Current_Velocity.ToString();*/
        }
        // Timer function for acquiring the timed images 
        private void Timer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < m_CamCount; i++)
            {
                Camera_Handler[i].Acquisition.Freeze();
                bLive[i] = true;
            }
            if (bLive[0] == true)
            {
                Cam1.Checked = true;
            }
            if (bLive[1] == true)
            {
                Cam2.Checked = true;
            }
            if (bLive[2] == true)
            {
                Cam3.Checked = true;
            }
            if (bLive[3] == true)
            {
                Cam4.Checked = true;
            }
        }
        public void Button_Save_Image_Click(object sender, EventArgs e)
        {
            string _defaultDir = null;
            if (_defaultDir == null)
            {
                _defaultDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);      // Searching for Special Location(Desktop) adress on any PC
                _defaultDir += @"\uEye Camera Images";     // Name of the Defult directory
            }
            Directory.CreateDirectory(_defaultDir);   // Creating a new directory, if the default directory did not exist.

            long image_count = 00000000;

            for (int i = 0; i < m_CamCount; i++)
            {
                string Savepath = Path.Combine(_defaultDir, "Field_Image_{0}_{1}.bmp");
                string FileName = String.Format(Savepath, s32CamID[i], image_count.ToString());
                while (File.Exists(FileName))
                {
                    FileName = String.Format(Savepath, s32CamID[i], image_count.ToString());
                    image_count++;
                }
                Camera_Handler[i].Image.Save(FileName, s32MemId[i], ImageFormat.Bmp, 24);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Field_Name = textBox1.Text;
        }


        private void Image_Save_Mode_CheckedChanged(object sender, EventArgs e)
        {
            if (Image_Save_Control.Checked == true)
            {
                Timer.Tick += new System.EventHandler(Button_Save_Image_Click);
                Button_Save_Image.Enabled = false;
            }
            else
            {
                Timer.Tick -= new System.EventHandler(Button_Save_Image_Click);
                Button_Save_Image.Enabled = true;
            }
        }
        private void Button_Stop_Video_Click_1(object sender, EventArgs e)
        {
            if (bStop == false)
            {
                for (int i = 0; i < m_CamCount; i++)
                {
                    bLive[i] = false;
                    Timer.Tick -= new System.EventHandler(Timer_Tick);
                    bStop = true;
                    Button_Stop_Video.Text = "Start Again";
                }
            }
            else
            {
                Timer.Tick += new System.EventHandler(Timer_Tick);
                bStop = false;
                Button_Stop_Video.Text = "Stop";
            }
        }
        public void Button_Exit_Prog_Click(object sender, EventArgs e)
        {
            // Close the Camera_Handler[i]
            for (int i = 0; i < m_CamCount; i++)
            {
                Camera_Handler[i].Exit();
            }
            Close();
            Timer.Dispose();
            Timer_Velocity_Updating.Dispose();
            SerialPort1.Close();
            SerialPort1.Dispose();
        }

        private void imageAcquisitionGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
           GPS_Display.Visible = false;
        }

        private void GPS_StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GPS_Display.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort1.Close();
            this.SerialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            CheckBox_GPS.Text = "CONNECT GPS";
            bGPS_Com = false;
            Port_Names_List.Enabled = true;
            Text_Box_Velocity.Clear();
            GPS_Status_Label.Text = "Not Fixed";
        }
    }
}

    
        




    

