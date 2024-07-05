namespace WindowsForms
{
    partial class uEye_DotNet_Simple_Live
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uEye_DotNet_Simple_Live));
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.GPSCommunication = new System.Windows.Forms.GroupBox();
            this.GPS_Speed = new System.Windows.Forms.GroupBox();
            this.Text_Box_Velocity = new System.Windows.Forms.TextBox();
            this.GPS_Status_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Port_Names_List = new System.Windows.Forms.Button();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.Label_Port_Name = new System.Windows.Forms.Label();
            this.Label_Baudrate = new System.Windows.Forms.Label();
            this.ComboBox_Baud_Rate = new System.Windows.Forms.ComboBox();
            this.Label_GPS_Selection = new System.Windows.Forms.Label();
            this.CheckBox_GPS = new System.Windows.Forms.CheckBox();
            this.ComboBox_GPS_Collection = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_Velocity = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Group_Box_Error_Report = new System.Windows.Forms.GroupBox();
            this.Enable_Error_Report = new System.Windows.Forms.CheckBox();
            this.Timer_Velocity_Updating = new System.Windows.Forms.Timer(this.components);
            this.Rich_Text_Box_CamCount = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cam4 = new System.Windows.Forms.CheckBox();
            this.Cam3 = new System.Windows.Forms.CheckBox();
            this.Cam2 = new System.Windows.Forms.CheckBox();
            this.Cam1 = new System.Windows.Forms.CheckBox();
            this.Button_Camera = new System.Windows.Forms.Button();
            this.Button_Exit_Prog = new System.Windows.Forms.Button();
            this.Button_Save_Image = new System.Windows.Forms.Button();
            this.Sensor_Data_Display = new System.Windows.Forms.GroupBox();
            this.Save_Images = new System.Windows.Forms.GroupBox();
            this.Image_Save_Control = new System.Windows.Forms.CheckBox();
            this.Camera_Control = new System.Windows.Forms.GroupBox();
            this.Button_Stop_Video = new System.Windows.Forms.Button();
            this.GPS_Display = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Acquired_images_display = new System.Windows.Forms.GroupBox();
            this.Camera4_SerialNum = new System.Windows.Forms.TextBox();
            this.Camera3_SerialNum = new System.Windows.Forms.TextBox();
            this.Camera2_SerialNum = new System.Windows.Forms.TextBox();
            this.Camera1_SerialNum = new System.Windows.Forms.TextBox();
            this.DisplayWindow1 = new System.Windows.Forms.PictureBox();
            this.TextBox_CamID2 = new System.Windows.Forms.TextBox();
            this.DisplayWindow0 = new System.Windows.Forms.PictureBox();
            this.DisplayWindow2 = new System.Windows.Forms.PictureBox();
            this.TextBox_CamID3 = new System.Windows.Forms.TextBox();
            this.TextBox_CamID1 = new System.Windows.Forms.TextBox();
            this.DisplayWindow3 = new System.Windows.Forms.PictureBox();
            this.TextBox_CamID0 = new System.Windows.Forms.TextBox();
            this.Processed_Images = new System.Windows.Forms.GroupBox();
            this.Camera4_SerialNum_Processed = new System.Windows.Forms.TextBox();
            this.Camera3_SerialNum_Processed = new System.Windows.Forms.TextBox();
            this.Camera2_SerialNum_Processed = new System.Windows.Forms.TextBox();
            this.Camera1_SerialNum_Processed = new System.Windows.Forms.TextBox();
            this.DisplayWindow5 = new System.Windows.Forms.PictureBox();
            this.TextBox_CamID2_Processed = new System.Windows.Forms.TextBox();
            this.DisplayWindow4 = new System.Windows.Forms.PictureBox();
            this.DisplayWindow6 = new System.Windows.Forms.PictureBox();
            this.TextBox_CamID3_Processed = new System.Windows.Forms.TextBox();
            this.TextBox_CamID1_Processed = new System.Windows.Forms.TextBox();
            this.DisplayWindow7 = new System.Windows.Forms.PictureBox();
            this.TextBox_CamID0_Processed = new System.Windows.Forms.TextBox();
            this.ButtonsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageAcquisitionGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPSDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GPS_StatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nozzleStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GPSCommunication.SuspendLayout();
            this.GPS_Speed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Group_Box_Error_Report.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Sensor_Data_Display.SuspendLayout();
            this.Save_Images.SuspendLayout();
            this.Camera_Control.SuspendLayout();
            this.GPS_Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Acquired_images_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow3)).BeginInit();
            this.Processed_Images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPSCommunication
            // 
            this.GPSCommunication.BackColor = System.Drawing.Color.Silver;
            this.GPSCommunication.Controls.Add(this.GPS_Speed);
            this.GPSCommunication.Controls.Add(this.GPS_Status_Label);
            this.GPSCommunication.Controls.Add(this.label1);
            this.GPSCommunication.Controls.Add(this.groupBox1);
            this.GPSCommunication.Controls.Add(this.Label_Baudrate);
            this.GPSCommunication.Controls.Add(this.ComboBox_Baud_Rate);
            this.GPSCommunication.Controls.Add(this.Label_GPS_Selection);
            this.GPSCommunication.Controls.Add(this.CheckBox_GPS);
            this.GPSCommunication.Controls.Add(this.ComboBox_GPS_Collection);
            this.GPSCommunication.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPSCommunication.Location = new System.Drawing.Point(13, 31);
            this.GPSCommunication.Margin = new System.Windows.Forms.Padding(4);
            this.GPSCommunication.Name = "GPSCommunication";
            this.GPSCommunication.Padding = new System.Windows.Forms.Padding(4);
            this.GPSCommunication.Size = new System.Drawing.Size(242, 673);
            this.GPSCommunication.TabIndex = 13;
            this.GPSCommunication.TabStop = false;
            this.GPSCommunication.Text = "GPS Configure";
            // 
            // GPS_Speed
            // 
            this.GPS_Speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GPS_Speed.Controls.Add(this.Text_Box_Velocity);
            this.GPS_Speed.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPS_Speed.Location = new System.Drawing.Point(12, 432);
            this.GPS_Speed.Name = "GPS_Speed";
            this.GPS_Speed.Size = new System.Drawing.Size(208, 184);
            this.GPS_Speed.TabIndex = 13;
            this.GPS_Speed.TabStop = false;
            this.GPS_Speed.Text = "Speed (Km/hr)";
            // 
            // Text_Box_Velocity
            // 
            this.Text_Box_Velocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Text_Box_Velocity.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Box_Velocity.Location = new System.Drawing.Point(7, 25);
            this.Text_Box_Velocity.Multiline = true;
            this.Text_Box_Velocity.Name = "Text_Box_Velocity";
            this.Text_Box_Velocity.ReadOnly = true;
            this.Text_Box_Velocity.Size = new System.Drawing.Size(189, 153);
            this.Text_Box_Velocity.TabIndex = 0;
            this.Text_Box_Velocity.Text = "5.612";
            this.Text_Box_Velocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPS_Status_Label
            // 
            this.GPS_Status_Label.AutoSize = true;
            this.GPS_Status_Label.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPS_Status_Label.Location = new System.Drawing.Point(125, 623);
            this.GPS_Status_Label.Name = "GPS_Status_Label";
            this.GPS_Status_Label.Size = new System.Drawing.Size(37, 27);
            this.GPS_Status_Label.TabIndex = 12;
            this.GPS_Status_Label.Text = "Ok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "GPS Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select RS232 Port";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.Port_Names_List);
            this.groupBox2.Controls.Add(this.ComboBox_COM);
            this.groupBox2.Controls.Add(this.Label_Port_Name);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 170);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM";
            // 
            // Port_Names_List
            // 
            this.Port_Names_List.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_Names_List.Location = new System.Drawing.Point(6, 26);
            this.Port_Names_List.Name = "Port_Names_List";
            this.Port_Names_List.Size = new System.Drawing.Size(168, 65);
            this.Port_Names_List.TabIndex = 56;
            this.Port_Names_List.Text = "Get Ports Name";
            this.ButtonsToolTip.SetToolTip(this.Port_Names_List, "Enables You to Get the Names of All Serial Ports Available on Your Computer");
            this.Port_Names_List.UseVisualStyleBackColor = true;
            this.Port_Names_List.Click += new System.EventHandler(this.Port_Names_List_Click);
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Location = new System.Drawing.Point(7, 132);
            this.ComboBox_COM.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(168, 22);
            this.ComboBox_COM.TabIndex = 2;
            this.ComboBox_COM.SelectedIndexChanged += new System.EventHandler(this.ComboBox_COM_SelectedIndexChanged);
            // 
            // Label_Port_Name
            // 
            this.Label_Port_Name.AutoSize = true;
            this.Label_Port_Name.Location = new System.Drawing.Point(7, 106);
            this.Label_Port_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Port_Name.Name = "Label_Port_Name";
            this.Label_Port_Name.Size = new System.Drawing.Size(167, 22);
            this.Label_Port_Name.TabIndex = 4;
            this.Label_Port_Name.Text = "Available Ports List";
            // 
            // Label_Baudrate
            // 
            this.Label_Baudrate.AutoSize = true;
            this.Label_Baudrate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Baudrate.Location = new System.Drawing.Point(8, 294);
            this.Label_Baudrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Baudrate.Name = "Label_Baudrate";
            this.Label_Baudrate.Size = new System.Drawing.Size(80, 19);
            this.Label_Baudrate.TabIndex = 6;
            this.Label_Baudrate.Text = "Baud Rate";
            // 
            // ComboBox_Baud_Rate
            // 
            this.ComboBox_Baud_Rate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Baud_Rate.FormattingEnabled = true;
            this.ComboBox_Baud_Rate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.ComboBox_Baud_Rate.Location = new System.Drawing.Point(116, 289);
            this.ComboBox_Baud_Rate.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Baud_Rate.Name = "ComboBox_Baud_Rate";
            this.ComboBox_Baud_Rate.Size = new System.Drawing.Size(105, 27);
            this.ComboBox_Baud_Rate.TabIndex = 5;
            this.ComboBox_Baud_Rate.Text = "9600";
            this.ComboBox_Baud_Rate.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Baud_Rate_SelectedIndexChanged);
            // 
            // Label_GPS_Selection
            // 
            this.Label_GPS_Selection.AutoSize = true;
            this.Label_GPS_Selection.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GPS_Selection.Location = new System.Drawing.Point(8, 257);
            this.Label_GPS_Selection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_GPS_Selection.Name = "Label_GPS_Selection";
            this.Label_GPS_Selection.Size = new System.Drawing.Size(106, 19);
            this.Label_GPS_Selection.TabIndex = 3;
            this.Label_GPS_Selection.Text = "GPS Selection";
            // 
            // CheckBox_GPS
            // 
            this.CheckBox_GPS.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckBox_GPS.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_GPS.Location = new System.Drawing.Point(12, 348);
            this.CheckBox_GPS.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_GPS.Name = "CheckBox_GPS";
            this.CheckBox_GPS.Size = new System.Drawing.Size(208, 77);
            this.CheckBox_GPS.TabIndex = 0;
            this.CheckBox_GPS.Text = "GPS Connected";
            this.CheckBox_GPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonsToolTip.SetToolTip(this.CheckBox_GPS, "Enables You to Connect the GPS Receiver and Intitate the Speed Display Prrotocols" +
        "");
            this.CheckBox_GPS.UseVisualStyleBackColor = true;
            this.CheckBox_GPS.CheckedChanged += new System.EventHandler(this.CheckBox_GPS_Checked);
            // 
            // ComboBox_GPS_Collection
            // 
            this.ComboBox_GPS_Collection.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_GPS_Collection.FormattingEnabled = true;
            this.ComboBox_GPS_Collection.Items.AddRange(new object[] {
            "Garmin USB"});
            this.ComboBox_GPS_Collection.Location = new System.Drawing.Point(116, 257);
            this.ComboBox_GPS_Collection.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_GPS_Collection.Name = "ComboBox_GPS_Collection";
            this.ComboBox_GPS_Collection.Size = new System.Drawing.Size(104, 24);
            this.ComboBox_GPS_Collection.TabIndex = 1;
            this.ComboBox_GPS_Collection.Text = "Garmin USB";
            this.ComboBox_GPS_Collection.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GPS_Collection_SelectedIndexChanges);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Field_Image";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label_Velocity
            // 
            this.Label_Velocity.AutoSize = true;
            this.Label_Velocity.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Velocity.Location = new System.Drawing.Point(12, 131);
            this.Label_Velocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Velocity.Name = "Label_Velocity";
            this.Label_Velocity.Size = new System.Drawing.Size(158, 22);
            this.Label_Velocity.TabIndex = 8;
            this.Label_Velocity.Text = "Comment for Data";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 300;
            // 
            // Group_Box_Error_Report
            // 
            this.Group_Box_Error_Report.Controls.Add(this.Enable_Error_Report);
            this.Group_Box_Error_Report.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Box_Error_Report.Location = new System.Drawing.Point(7, 333);
            this.Group_Box_Error_Report.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Box_Error_Report.Name = "Group_Box_Error_Report";
            this.Group_Box_Error_Report.Padding = new System.Windows.Forms.Padding(4);
            this.Group_Box_Error_Report.Size = new System.Drawing.Size(163, 57);
            this.Group_Box_Error_Report.TabIndex = 22;
            this.Group_Box_Error_Report.TabStop = false;
            this.Group_Box_Error_Report.Text = "Error Report";
            // 
            // Enable_Error_Report
            // 
            this.Enable_Error_Report.Checked = true;
            this.Enable_Error_Report.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Enable_Error_Report.Location = new System.Drawing.Point(8, 27);
            this.Enable_Error_Report.Margin = new System.Windows.Forms.Padding(4);
            this.Enable_Error_Report.Name = "Enable_Error_Report";
            this.Enable_Error_Report.Size = new System.Drawing.Size(114, 22);
            this.Enable_Error_Report.TabIndex = 23;
            this.Enable_Error_Report.Text = "Enable";
            this.Enable_Error_Report.UseVisualStyleBackColor = true;
            this.Enable_Error_Report.CheckedChanged += new System.EventHandler(this.Enable_Error_Report_Checked);
            // 
            // Timer_Velocity_Updating
            // 
            this.Timer_Velocity_Updating.Tick += new System.EventHandler(this.Timer_Velocity_Updating_Tick);
            // 
            // Rich_Text_Box_CamCount
            // 
            this.Rich_Text_Box_CamCount.Location = new System.Drawing.Point(7, 398);
            this.Rich_Text_Box_CamCount.Margin = new System.Windows.Forms.Padding(4);
            this.Rich_Text_Box_CamCount.Name = "Rich_Text_Box_CamCount";
            this.Rich_Text_Box_CamCount.ReadOnly = true;
            this.Rich_Text_Box_CamCount.Size = new System.Drawing.Size(163, 32);
            this.Rich_Text_Box_CamCount.TabIndex = 25;
            this.Rich_Text_Box_CamCount.Text = "Connected Cameras: 4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cam4);
            this.groupBox3.Controls.Add(this.Cam3);
            this.groupBox3.Controls.Add(this.Cam2);
            this.groupBox3.Controls.Add(this.Cam1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(163, 64);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera Selection";
            // 
            // Cam4
            // 
            this.Cam4.AutoSize = true;
            this.Cam4.Checked = true;
            this.Cam4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cam4.Location = new System.Drawing.Point(112, 33);
            this.Cam4.Margin = new System.Windows.Forms.Padding(4);
            this.Cam4.Name = "Cam4";
            this.Cam4.Size = new System.Drawing.Size(36, 23);
            this.Cam4.TabIndex = 3;
            this.Cam4.Text = "4";
            this.Cam4.UseVisualStyleBackColor = true;
            // 
            // Cam3
            // 
            this.Cam3.AutoSize = true;
            this.Cam3.Checked = true;
            this.Cam3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cam3.Location = new System.Drawing.Point(68, 33);
            this.Cam3.Margin = new System.Windows.Forms.Padding(4);
            this.Cam3.Name = "Cam3";
            this.Cam3.Size = new System.Drawing.Size(36, 23);
            this.Cam3.TabIndex = 2;
            this.Cam3.Text = "3";
            this.Cam3.UseVisualStyleBackColor = true;
            // 
            // Cam2
            // 
            this.Cam2.AutoSize = true;
            this.Cam2.Checked = true;
            this.Cam2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cam2.Location = new System.Drawing.Point(36, 33);
            this.Cam2.Margin = new System.Windows.Forms.Padding(4);
            this.Cam2.Name = "Cam2";
            this.Cam2.Size = new System.Drawing.Size(36, 23);
            this.Cam2.TabIndex = 1;
            this.Cam2.Text = "2";
            this.Cam2.UseVisualStyleBackColor = true;
            // 
            // Cam1
            // 
            this.Cam1.AutoSize = true;
            this.Cam1.Checked = true;
            this.Cam1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cam1.Location = new System.Drawing.Point(3, 33);
            this.Cam1.Margin = new System.Windows.Forms.Padding(4);
            this.Cam1.Name = "Cam1";
            this.Cam1.Size = new System.Drawing.Size(36, 23);
            this.Cam1.TabIndex = 0;
            this.Cam1.Text = "1";
            this.Cam1.UseVisualStyleBackColor = true;
            // 
            // Button_Camera
            // 
            this.Button_Camera.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Button_Camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Camera.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Camera.FlatAppearance.BorderSize = 2;
            this.Button_Camera.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Camera.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Camera.ForeColor = System.Drawing.Color.Black;
            this.Button_Camera.Location = new System.Drawing.Point(7, 17);
            this.Button_Camera.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Camera.Name = "Button_Camera";
            this.Button_Camera.Size = new System.Drawing.Size(163, 77);
            this.Button_Camera.TabIndex = 0;
            this.Button_Camera.Text = "Camera";
            this.ButtonsToolTip.SetToolTip(this.Button_Camera, "Enables You to Connect All the Cameras With this Application and Initiates the Im" +
        "age Acquisition Process");
            this.Button_Camera.UseVisualStyleBackColor = false;
            this.Button_Camera.Click += new System.EventHandler(this.Button_Camera_Click);
            // 
            // Button_Exit_Prog
            // 
            this.Button_Exit_Prog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Exit_Prog.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit_Prog.Location = new System.Drawing.Point(7, 185);
            this.Button_Exit_Prog.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Exit_Prog.Name = "Button_Exit_Prog";
            this.Button_Exit_Prog.Size = new System.Drawing.Size(163, 77);
            this.Button_Exit_Prog.TabIndex = 4;
            this.Button_Exit_Prog.Text = "Exit";
            this.ButtonsToolTip.SetToolTip(this.Button_Exit_Prog, "Enables You to Exit the Application");
            this.Button_Exit_Prog.UseVisualStyleBackColor = true;
            this.Button_Exit_Prog.Click += new System.EventHandler(this.Button_Exit_Prog_Click);
            // 
            // Button_Save_Image
            // 
            this.Button_Save_Image.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Save_Image.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save_Image.Location = new System.Drawing.Point(10, 48);
            this.Button_Save_Image.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Save_Image.Name = "Button_Save_Image";
            this.Button_Save_Image.Size = new System.Drawing.Size(163, 77);
            this.Button_Save_Image.TabIndex = 6;
            this.Button_Save_Image.Text = "Save Image";
            this.ButtonsToolTip.SetToolTip(this.Button_Save_Image, "Enables You to Save the Image Streams from the Multiple Cameras");
            this.Button_Save_Image.UseVisualStyleBackColor = false;
            // 
            // Sensor_Data_Display
            // 
            this.Sensor_Data_Display.BackColor = System.Drawing.Color.Silver;
            this.Sensor_Data_Display.Controls.Add(this.Save_Images);
            this.Sensor_Data_Display.Controls.Add(this.Camera_Control);
            this.Sensor_Data_Display.Location = new System.Drawing.Point(262, 31);
            this.Sensor_Data_Display.Name = "Sensor_Data_Display";
            this.Sensor_Data_Display.Size = new System.Drawing.Size(226, 673);
            this.Sensor_Data_Display.TabIndex = 55;
            this.Sensor_Data_Display.TabStop = false;
            this.Sensor_Data_Display.Text = "Camera Configure";
            // 
            // Save_Images
            // 
            this.Save_Images.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_Images.Controls.Add(this.Image_Save_Control);
            this.Save_Images.Controls.Add(this.Button_Save_Image);
            this.Save_Images.Controls.Add(this.Label_Velocity);
            this.Save_Images.Controls.Add(this.textBox1);
            this.Save_Images.Location = new System.Drawing.Point(19, 466);
            this.Save_Images.Name = "Save_Images";
            this.Save_Images.Size = new System.Drawing.Size(188, 192);
            this.Save_Images.TabIndex = 27;
            this.Save_Images.TabStop = false;
            this.Save_Images.Text = "Save Images";
            // 
            // Image_Save_Control
            // 
            this.Image_Save_Control.AutoSize = true;
            this.Image_Save_Control.Location = new System.Drawing.Point(7, 25);
            this.Image_Save_Control.Name = "Image_Save_Control";
            this.Image_Save_Control.Size = new System.Drawing.Size(174, 23);
            this.Image_Save_Control.TabIndex = 56;
            this.Image_Save_Control.Tag = "";
            this.Image_Save_Control.Text = "Activate Save Control";
            this.Image_Save_Control.UseVisualStyleBackColor = true;
            this.Image_Save_Control.CheckedChanged += new System.EventHandler(this.Image_Save_Mode_CheckedChanged);
            // 
            // Camera_Control
            // 
            this.Camera_Control.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Camera_Control.Controls.Add(this.Button_Stop_Video);
            this.Camera_Control.Controls.Add(this.Rich_Text_Box_CamCount);
            this.Camera_Control.Controls.Add(this.Button_Exit_Prog);
            this.Camera_Control.Controls.Add(this.groupBox3);
            this.Camera_Control.Controls.Add(this.Button_Camera);
            this.Camera_Control.Controls.Add(this.Group_Box_Error_Report);
            this.Camera_Control.Location = new System.Drawing.Point(19, 25);
            this.Camera_Control.Name = "Camera_Control";
            this.Camera_Control.Size = new System.Drawing.Size(188, 435);
            this.Camera_Control.TabIndex = 26;
            this.Camera_Control.TabStop = false;
            this.Camera_Control.Text = "Camera Control";
            // 
            // Button_Stop_Video
            // 
            this.Button_Stop_Video.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Stop_Video.Location = new System.Drawing.Point(7, 101);
            this.Button_Stop_Video.Name = "Button_Stop_Video";
            this.Button_Stop_Video.Size = new System.Drawing.Size(163, 77);
            this.Button_Stop_Video.TabIndex = 56;
            this.Button_Stop_Video.Text = "Stop";
            this.ButtonsToolTip.SetToolTip(this.Button_Stop_Video, "Enables You to Stop the Re-Initiate the Image Acquisition Process");
            this.Button_Stop_Video.UseVisualStyleBackColor = true;
            this.Button_Stop_Video.Click += new System.EventHandler(this.Button_Stop_Video_Click_1);
            // 
            // GPS_Display
            // 
            this.GPS_Display.BackColor = System.Drawing.Color.Silver;
            this.GPS_Display.Controls.Add(this.button1);
            this.GPS_Display.Controls.Add(this.pictureBox1);
            this.GPS_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPS_Display.Location = new System.Drawing.Point(0, 27);
            this.GPS_Display.Name = "GPS_Display";
            this.GPS_Display.Size = new System.Drawing.Size(1320, 693);
            this.GPS_Display.TabIndex = 57;
            this.GPS_Display.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "DISCONNECT GPS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1291, 603);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Acquired_images_display
            // 
            this.Acquired_images_display.BackColor = System.Drawing.Color.Silver;
            this.Acquired_images_display.Controls.Add(this.Camera4_SerialNum);
            this.Acquired_images_display.Controls.Add(this.Camera3_SerialNum);
            this.Acquired_images_display.Controls.Add(this.Camera2_SerialNum);
            this.Acquired_images_display.Controls.Add(this.Camera1_SerialNum);
            this.Acquired_images_display.Controls.Add(this.DisplayWindow1);
            this.Acquired_images_display.Controls.Add(this.TextBox_CamID2);
            this.Acquired_images_display.Controls.Add(this.DisplayWindow0);
            this.Acquired_images_display.Controls.Add(this.DisplayWindow2);
            this.Acquired_images_display.Controls.Add(this.TextBox_CamID3);
            this.Acquired_images_display.Controls.Add(this.TextBox_CamID1);
            this.Acquired_images_display.Controls.Add(this.DisplayWindow3);
            this.Acquired_images_display.Controls.Add(this.TextBox_CamID0);
            this.Acquired_images_display.Location = new System.Drawing.Point(494, 31);
            this.Acquired_images_display.Name = "Acquired_images_display";
            this.Acquired_images_display.Size = new System.Drawing.Size(405, 673);
            this.Acquired_images_display.TabIndex = 54;
            this.Acquired_images_display.TabStop = false;
            this.Acquired_images_display.Text = "Camera Display";
            // 
            // Camera4_SerialNum
            // 
            this.Camera4_SerialNum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera4_SerialNum.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera4_SerialNum.Location = new System.Drawing.Point(109, 510);
            this.Camera4_SerialNum.Margin = new System.Windows.Forms.Padding(4);
            this.Camera4_SerialNum.Name = "Camera4_SerialNum";
            this.Camera4_SerialNum.ReadOnly = true;
            this.Camera4_SerialNum.Size = new System.Drawing.Size(124, 22);
            this.Camera4_SerialNum.TabIndex = 38;
            this.Camera4_SerialNum.Text = "SN: 4102670878";
            // 
            // Camera3_SerialNum
            // 
            this.Camera3_SerialNum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera3_SerialNum.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera3_SerialNum.Location = new System.Drawing.Point(100, 344);
            this.Camera3_SerialNum.Margin = new System.Windows.Forms.Padding(4);
            this.Camera3_SerialNum.Name = "Camera3_SerialNum";
            this.Camera3_SerialNum.ReadOnly = true;
            this.Camera3_SerialNum.Size = new System.Drawing.Size(124, 22);
            this.Camera3_SerialNum.TabIndex = 39;
            this.Camera3_SerialNum.Text = "SN: 4102900151";
            // 
            // Camera2_SerialNum
            // 
            this.Camera2_SerialNum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera2_SerialNum.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera2_SerialNum.Location = new System.Drawing.Point(100, 181);
            this.Camera2_SerialNum.Margin = new System.Windows.Forms.Padding(4);
            this.Camera2_SerialNum.Name = "Camera2_SerialNum";
            this.Camera2_SerialNum.ReadOnly = true;
            this.Camera2_SerialNum.Size = new System.Drawing.Size(124, 22);
            this.Camera2_SerialNum.TabIndex = 36;
            this.Camera2_SerialNum.Text = "SN: 4102647390";
            // 
            // Camera1_SerialNum
            // 
            this.Camera1_SerialNum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera1_SerialNum.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera1_SerialNum.Location = new System.Drawing.Point(109, 26);
            this.Camera1_SerialNum.Margin = new System.Windows.Forms.Padding(4);
            this.Camera1_SerialNum.Name = "Camera1_SerialNum";
            this.Camera1_SerialNum.ReadOnly = true;
            this.Camera1_SerialNum.Size = new System.Drawing.Size(124, 22);
            this.Camera1_SerialNum.TabIndex = 35;
            this.Camera1_SerialNum.Text = "SN: 4102864841";
            // 
            // DisplayWindow1
            // 
            this.DisplayWindow1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow1.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow1.Image")));
            this.DisplayWindow1.Location = new System.Drawing.Point(12, 210);
            this.DisplayWindow1.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayWindow1.Name = "DisplayWindow1";
            this.DisplayWindow1.Size = new System.Drawing.Size(386, 126);
            this.DisplayWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow1.TabIndex = 14;
            this.DisplayWindow1.TabStop = false;
            // 
            // TextBox_CamID2
            // 
            this.TextBox_CamID2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID2.Location = new System.Drawing.Point(12, 344);
            this.TextBox_CamID2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID2.Name = "TextBox_CamID2";
            this.TextBox_CamID2.ReadOnly = true;
            this.TextBox_CamID2.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID2.TabIndex = 27;
            this.TextBox_CamID2.Text = "ID: 3";
            // 
            // DisplayWindow0
            // 
            this.DisplayWindow0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow0.Enabled = false;
            this.DisplayWindow0.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow0.Image")));
            this.DisplayWindow0.Location = new System.Drawing.Point(12, 52);
            this.DisplayWindow0.Margin = new System.Windows.Forms.Padding(15);
            this.DisplayWindow0.Name = "DisplayWindow0";
            this.DisplayWindow0.Size = new System.Drawing.Size(386, 126);
            this.DisplayWindow0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow0.TabIndex = 5;
            this.DisplayWindow0.TabStop = false;
            // 
            // DisplayWindow2
            // 
            this.DisplayWindow2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow2.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow2.Image")));
            this.DisplayWindow2.Location = new System.Drawing.Point(12, 374);
            this.DisplayWindow2.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayWindow2.Name = "DisplayWindow2";
            this.DisplayWindow2.Size = new System.Drawing.Size(386, 126);
            this.DisplayWindow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow2.TabIndex = 15;
            this.DisplayWindow2.TabStop = false;
            // 
            // TextBox_CamID3
            // 
            this.TextBox_CamID3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID3.Location = new System.Drawing.Point(12, 510);
            this.TextBox_CamID3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID3.Name = "TextBox_CamID3";
            this.TextBox_CamID3.ReadOnly = true;
            this.TextBox_CamID3.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID3.TabIndex = 34;
            this.TextBox_CamID3.Text = "ID: 4";
            // 
            // TextBox_CamID1
            // 
            this.TextBox_CamID1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID1.Location = new System.Drawing.Point(12, 180);
            this.TextBox_CamID1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID1.Name = "TextBox_CamID1";
            this.TextBox_CamID1.ReadOnly = true;
            this.TextBox_CamID1.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID1.TabIndex = 26;
            this.TextBox_CamID1.Text = "ID: 2";
            // 
            // DisplayWindow3
            // 
            this.DisplayWindow3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow3.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow3.Image")));
            this.DisplayWindow3.Location = new System.Drawing.Point(12, 540);
            this.DisplayWindow3.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayWindow3.Name = "DisplayWindow3";
            this.DisplayWindow3.Size = new System.Drawing.Size(386, 126);
            this.DisplayWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow3.TabIndex = 16;
            this.DisplayWindow3.TabStop = false;
            // 
            // TextBox_CamID0
            // 
            this.TextBox_CamID0.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID0.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID0.Location = new System.Drawing.Point(12, 25);
            this.TextBox_CamID0.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID0.Name = "TextBox_CamID0";
            this.TextBox_CamID0.ReadOnly = true;
            this.TextBox_CamID0.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID0.TabIndex = 0;
            this.TextBox_CamID0.Text = "ID: 1";
            // 
            // Processed_Images
            // 
            this.Processed_Images.BackColor = System.Drawing.Color.Silver;
            this.Processed_Images.Controls.Add(this.Camera4_SerialNum_Processed);
            this.Processed_Images.Controls.Add(this.Camera3_SerialNum_Processed);
            this.Processed_Images.Controls.Add(this.Camera2_SerialNum_Processed);
            this.Processed_Images.Controls.Add(this.Camera1_SerialNum_Processed);
            this.Processed_Images.Controls.Add(this.DisplayWindow5);
            this.Processed_Images.Controls.Add(this.TextBox_CamID2_Processed);
            this.Processed_Images.Controls.Add(this.DisplayWindow4);
            this.Processed_Images.Controls.Add(this.DisplayWindow6);
            this.Processed_Images.Controls.Add(this.TextBox_CamID3_Processed);
            this.Processed_Images.Controls.Add(this.TextBox_CamID1_Processed);
            this.Processed_Images.Controls.Add(this.DisplayWindow7);
            this.Processed_Images.Controls.Add(this.TextBox_CamID0_Processed);
            this.Processed_Images.Location = new System.Drawing.Point(905, 31);
            this.Processed_Images.Name = "Processed_Images";
            this.Processed_Images.Size = new System.Drawing.Size(405, 673);
            this.Processed_Images.TabIndex = 57;
            this.Processed_Images.TabStop = false;
            this.Processed_Images.Text = "Processed Images";
            // 
            // Camera4_SerialNum_Processed
            // 
            this.Camera4_SerialNum_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera4_SerialNum_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera4_SerialNum_Processed.Location = new System.Drawing.Point(109, 510);
            this.Camera4_SerialNum_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.Camera4_SerialNum_Processed.Name = "Camera4_SerialNum_Processed";
            this.Camera4_SerialNum_Processed.ReadOnly = true;
            this.Camera4_SerialNum_Processed.Size = new System.Drawing.Size(124, 22);
            this.Camera4_SerialNum_Processed.TabIndex = 38;
            this.Camera4_SerialNum_Processed.Text = "SN: 4102670878";
            // 
            // Camera3_SerialNum_Processed
            // 
            this.Camera3_SerialNum_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera3_SerialNum_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera3_SerialNum_Processed.Location = new System.Drawing.Point(100, 344);
            this.Camera3_SerialNum_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.Camera3_SerialNum_Processed.Name = "Camera3_SerialNum_Processed";
            this.Camera3_SerialNum_Processed.ReadOnly = true;
            this.Camera3_SerialNum_Processed.Size = new System.Drawing.Size(124, 22);
            this.Camera3_SerialNum_Processed.TabIndex = 39;
            this.Camera3_SerialNum_Processed.Text = "SN: 4102900151";
            // 
            // Camera2_SerialNum_Processed
            // 
            this.Camera2_SerialNum_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera2_SerialNum_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera2_SerialNum_Processed.Location = new System.Drawing.Point(100, 181);
            this.Camera2_SerialNum_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.Camera2_SerialNum_Processed.Name = "Camera2_SerialNum_Processed";
            this.Camera2_SerialNum_Processed.ReadOnly = true;
            this.Camera2_SerialNum_Processed.Size = new System.Drawing.Size(124, 22);
            this.Camera2_SerialNum_Processed.TabIndex = 36;
            this.Camera2_SerialNum_Processed.Text = "SN: 4102647390";
            // 
            // Camera1_SerialNum_Processed
            // 
            this.Camera1_SerialNum_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Camera1_SerialNum_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera1_SerialNum_Processed.Location = new System.Drawing.Point(100, 26);
            this.Camera1_SerialNum_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.Camera1_SerialNum_Processed.Name = "Camera1_SerialNum_Processed";
            this.Camera1_SerialNum_Processed.ReadOnly = true;
            this.Camera1_SerialNum_Processed.Size = new System.Drawing.Size(124, 22);
            this.Camera1_SerialNum_Processed.TabIndex = 35;
            this.Camera1_SerialNum_Processed.Text = "SN: 4102864841";
            // 
            // DisplayWindow5
            // 
            this.DisplayWindow5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow5.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow5.Image")));
            this.DisplayWindow5.Location = new System.Drawing.Point(12, 210);
            this.DisplayWindow5.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayWindow5.Name = "DisplayWindow5";
            this.DisplayWindow5.Size = new System.Drawing.Size(380, 126);
            this.DisplayWindow5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow5.TabIndex = 14;
            this.DisplayWindow5.TabStop = false;
            // 
            // TextBox_CamID2_Processed
            // 
            this.TextBox_CamID2_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID2_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID2_Processed.Location = new System.Drawing.Point(12, 344);
            this.TextBox_CamID2_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID2_Processed.Name = "TextBox_CamID2_Processed";
            this.TextBox_CamID2_Processed.ReadOnly = true;
            this.TextBox_CamID2_Processed.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID2_Processed.TabIndex = 27;
            this.TextBox_CamID2_Processed.Text = "ID: 3";
            // 
            // DisplayWindow4
            // 
            this.DisplayWindow4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow4.Enabled = false;
            this.DisplayWindow4.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow4.Image")));
            this.DisplayWindow4.Location = new System.Drawing.Point(12, 52);
            this.DisplayWindow4.Margin = new System.Windows.Forms.Padding(15);
            this.DisplayWindow4.Name = "DisplayWindow4";
            this.DisplayWindow4.Size = new System.Drawing.Size(380, 126);
            this.DisplayWindow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow4.TabIndex = 5;
            this.DisplayWindow4.TabStop = false;
            // 
            // DisplayWindow6
            // 
            this.DisplayWindow6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow6.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow6.Image")));
            this.DisplayWindow6.Location = new System.Drawing.Point(12, 374);
            this.DisplayWindow6.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayWindow6.Name = "DisplayWindow6";
            this.DisplayWindow6.Size = new System.Drawing.Size(380, 126);
            this.DisplayWindow6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow6.TabIndex = 15;
            this.DisplayWindow6.TabStop = false;
            // 
            // TextBox_CamID3_Processed
            // 
            this.TextBox_CamID3_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID3_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID3_Processed.Location = new System.Drawing.Point(12, 510);
            this.TextBox_CamID3_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID3_Processed.Name = "TextBox_CamID3_Processed";
            this.TextBox_CamID3_Processed.ReadOnly = true;
            this.TextBox_CamID3_Processed.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID3_Processed.TabIndex = 34;
            this.TextBox_CamID3_Processed.Text = "ID: 4";
            // 
            // TextBox_CamID1_Processed
            // 
            this.TextBox_CamID1_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID1_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID1_Processed.Location = new System.Drawing.Point(12, 180);
            this.TextBox_CamID1_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID1_Processed.Name = "TextBox_CamID1_Processed";
            this.TextBox_CamID1_Processed.ReadOnly = true;
            this.TextBox_CamID1_Processed.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID1_Processed.TabIndex = 26;
            this.TextBox_CamID1_Processed.Text = "ID: 2";
            // 
            // DisplayWindow7
            // 
            this.DisplayWindow7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayWindow7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayWindow7.Image = ((System.Drawing.Image)(resources.GetObject("DisplayWindow7.Image")));
            this.DisplayWindow7.Location = new System.Drawing.Point(12, 540);
            this.DisplayWindow7.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayWindow7.Name = "DisplayWindow7";
            this.DisplayWindow7.Size = new System.Drawing.Size(380, 126);
            this.DisplayWindow7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DisplayWindow7.TabIndex = 16;
            this.DisplayWindow7.TabStop = false;
            // 
            // TextBox_CamID0_Processed
            // 
            this.TextBox_CamID0_Processed.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_CamID0_Processed.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CamID0_Processed.Location = new System.Drawing.Point(12, 25);
            this.TextBox_CamID0_Processed.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CamID0_Processed.Name = "TextBox_CamID0_Processed";
            this.TextBox_CamID0_Processed.ReadOnly = true;
            this.TextBox_CamID0_Processed.Size = new System.Drawing.Size(80, 22);
            this.TextBox_CamID0_Processed.TabIndex = 0;
            this.TextBox_CamID0_Processed.Text = "ID: 1";
            // 
            // ButtonsToolTip
            // 
            this.ButtonsToolTip.ShowAlways = true;
            this.ButtonsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageAcquisitionGUIToolStripMenuItem,
            this.gPSDisplayToolStripMenuItem,
            this.GPS_StatusToolStripMenuItem,
            this.nozzleStatusToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1320, 27);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageAcquisitionGUIToolStripMenuItem
            // 
            this.imageAcquisitionGUIToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageAcquisitionGUIToolStripMenuItem.Name = "imageAcquisitionGUIToolStripMenuItem";
            this.imageAcquisitionGUIToolStripMenuItem.Size = new System.Drawing.Size(159, 23);
            this.imageAcquisitionGUIToolStripMenuItem.Text = "Image Acquisition GUI";
            this.imageAcquisitionGUIToolStripMenuItem.Click += new System.EventHandler(this.imageAcquisitionGUIToolStripMenuItem_Click);
            // 
            // gPSDisplayToolStripMenuItem
            // 
            this.gPSDisplayToolStripMenuItem.Name = "gPSDisplayToolStripMenuItem";
            this.gPSDisplayToolStripMenuItem.Size = new System.Drawing.Size(12, 23);
            // 
            // GPS_StatusToolStripMenuItem
            // 
            this.GPS_StatusToolStripMenuItem.Name = "GPS_StatusToolStripMenuItem";
            this.GPS_StatusToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.GPS_StatusToolStripMenuItem.Text = "GPS Display";
            this.GPS_StatusToolStripMenuItem.Click += new System.EventHandler(this.GPS_StatusToolStripMenuItem_Click);
            // 
            // nozzleStatusToolStripMenuItem1
            // 
            this.nozzleStatusToolStripMenuItem1.Name = "nozzleStatusToolStripMenuItem1";
            this.nozzleStatusToolStripMenuItem1.Size = new System.Drawing.Size(104, 23);
            this.nozzleStatusToolStripMenuItem1.Text = "Nozzle Status";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // uEye_DotNet_Simple_Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1320, 720);
            this.Controls.Add(this.GPS_Display);
            this.Controls.Add(this.Processed_Images);
            this.Controls.Add(this.GPSCommunication);
            this.Controls.Add(this.Sensor_Data_Display);
            this.Controls.Add(this.Acquired_images_display);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "uEye_DotNet_Simple_Live";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goldenrod Vision System (GRVIS) by TR";
            this.Load += new System.EventHandler(this.uEye_DotNet_Simple_Live_Load);
            this.GPSCommunication.ResumeLayout(false);
            this.GPSCommunication.PerformLayout();
            this.GPS_Speed.ResumeLayout(false);
            this.GPS_Speed.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Group_Box_Error_Report.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Sensor_Data_Display.ResumeLayout(false);
            this.Save_Images.ResumeLayout(false);
            this.Save_Images.PerformLayout();
            this.Camera_Control.ResumeLayout(false);
            this.GPS_Display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Acquired_images_display.ResumeLayout(false);
            this.Acquired_images_display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow3)).EndInit();
            this.Processed_Images.ResumeLayout(false);
            this.Processed_Images.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.GroupBox GPSCommunication;
        private System.Windows.Forms.CheckBox CheckBox_GPS;
        private System.Windows.Forms.ComboBox ComboBox_GPS_Collection;
        private System.Windows.Forms.Label Label_GPS_Selection;
        private System.Windows.Forms.ComboBox ComboBox_COM;
        private System.Windows.Forms.Label Label_Baudrate;
        private System.Windows.Forms.ComboBox ComboBox_Baud_Rate;
        private System.Windows.Forms.Label Label_Port_Name;
        public System.Windows.Forms.Label Label_Velocity;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox Group_Box_Error_Report;
        private System.Windows.Forms.CheckBox Enable_Error_Report;
        private System.Windows.Forms.Timer Timer_Velocity_Updating;
        private System.Windows.Forms.RichTextBox Rich_Text_Box_CamCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Cam1;
        private System.Windows.Forms.CheckBox Cam2;
        private System.Windows.Forms.CheckBox Cam3;
        private System.Windows.Forms.CheckBox Cam4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label GPS_Status_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Camera;
        private System.Windows.Forms.Button Button_Exit_Prog;
        private System.Windows.Forms.Button Button_Save_Image;
        private System.Windows.Forms.GroupBox Sensor_Data_Display;
        private System.Windows.Forms.GroupBox Acquired_images_display;
        private System.Windows.Forms.TextBox Camera4_SerialNum;
        private System.Windows.Forms.TextBox Camera3_SerialNum;
        private System.Windows.Forms.TextBox Camera2_SerialNum;
        private System.Windows.Forms.TextBox Camera1_SerialNum;
        private System.Windows.Forms.PictureBox DisplayWindow1;
        private System.Windows.Forms.TextBox TextBox_CamID2;
        private System.Windows.Forms.PictureBox DisplayWindow0;
        private System.Windows.Forms.PictureBox DisplayWindow2;
        private System.Windows.Forms.TextBox TextBox_CamID3;
        private System.Windows.Forms.TextBox TextBox_CamID1;
        private System.Windows.Forms.PictureBox DisplayWindow3;
        private System.Windows.Forms.TextBox TextBox_CamID0;
        private System.Windows.Forms.GroupBox Camera_Control;
        private System.Windows.Forms.GroupBox Save_Images;
        private System.Windows.Forms.CheckBox Image_Save_Control;
        private System.Windows.Forms.Button Port_Names_List;
        private System.Windows.Forms.GroupBox GPS_Speed;
        private System.Windows.Forms.TextBox Text_Box_Velocity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_Stop_Video;
        private System.Windows.Forms.ToolTip ButtonsToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageAcquisitionGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPSDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GPS_StatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nozzleStatusToolStripMenuItem1;
        private System.Windows.Forms.Panel GPS_Display;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Processed_Images;
        private System.Windows.Forms.TextBox Camera4_SerialNum_Processed;
        private System.Windows.Forms.TextBox Camera3_SerialNum_Processed;
        private System.Windows.Forms.TextBox Camera2_SerialNum_Processed;
        private System.Windows.Forms.TextBox Camera1_SerialNum_Processed;
        private System.Windows.Forms.PictureBox DisplayWindow5;
        private System.Windows.Forms.TextBox TextBox_CamID2_Processed;
        private System.Windows.Forms.PictureBox DisplayWindow4;
        private System.Windows.Forms.PictureBox DisplayWindow6;
        private System.Windows.Forms.TextBox TextBox_CamID3_Processed;
        private System.Windows.Forms.TextBox TextBox_CamID1_Processed;
        private System.Windows.Forms.PictureBox DisplayWindow7;
        private System.Windows.Forms.TextBox TextBox_CamID0_Processed;
    }
}

