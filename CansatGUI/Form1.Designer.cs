namespace CansatGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Data = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            progressBar = new ProgressBar();
            State_box = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox7 = new GroupBox();
            groupBox6 = new GroupBox();
            AccZ_box = new TextBox();
            AccY_box = new TextBox();
            AccX_box = new TextBox();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            groupBox5 = new GroupBox();
            Parachute2_status = new TextBox();
            label24 = new Label();
            label23 = new Label();
            Parachute1_status = new TextBox();
            groupBox3 = new GroupBox();
            Yaw_box = new TextBox();
            label18 = new Label();
            label16 = new Label();
            Roll_box = new TextBox();
            Pitch_box = new TextBox();
            label17 = new Label();
            groupBox4 = new GroupBox();
            Temp_sensor_box = new TextBox();
            label22 = new Label();
            Pressure_sensor_box = new TextBox();
            label21 = new Label();
            label19 = new Label();
            RTC_sensor_box = new TextBox();
            IMU_sensor_box = new TextBox();
            label20 = new Label();
            groupBox2 = new GroupBox();
            textBox14 = new TextBox();
            groupBox1 = new GroupBox();
            GNSS_time_box = new TextBox();
            label12 = new Label();
            GNSS_alt_box = new TextBox();
            label13 = new Label();
            GNSS_long_box = new TextBox();
            label14 = new Label();
            GNSS_lat_box = new TextBox();
            label15 = new Label();
            GNSS_spin_box = new TextBox();
            label5 = new Label();
            GNSS_sat_box = new TextBox();
            label9 = new Label();
            Voltage_box = new TextBox();
            label10 = new Label();
            Temp_box = new TextBox();
            label11 = new Label();
            Pressure_box = new TextBox();
            label8 = new Label();
            Altitude_box = new TextBox();
            label7 = new Label();
            Packet_count_box = new TextBox();
            label6 = new Label();
            Mission_time_box = new TextBox();
            Mission_time_label = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            Loadmapbtn = new Button();
            gmaplong_txt = new TextBox();
            gmaplong = new Label();
            gmaplat_txt = new TextBox();
            gmaplat = new Label();
            splitter1 = new Splitter();
            gMap = new GMap.NET.WindowsForms.GMapControl();
            tabPage4 = new TabPage();
            Data.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // Data
            // 
            Data.Controls.Add(tabPage1);
            Data.Controls.Add(tabPage2);
            Data.Controls.Add(tabPage3);
            Data.Controls.Add(tabPage4);
            Data.Location = new Point(-2, 0);
            Data.Name = "Data";
            Data.SelectedIndex = 0;
            Data.Size = new Size(1904, 983);
            Data.TabIndex = 0;
            Data.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1896, 950);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Data";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DimGray;
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(progressBar);
            splitContainer1.Panel1.Controls.Add(State_box);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Center;
            splitContainer1.Panel2.Controls.Add(groupBox7);
            splitContainer1.Panel2.Controls.Add(groupBox6);
            splitContainer1.Panel2.Controls.Add(groupBox5);
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox4);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.ForeColor = SystemColors.ActiveCaption;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1888, 942);
            splitContainer1.SplitterDistance = 209;
            splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateGray;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Elephant", 14F);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(3, 340);
            label4.MinimumSize = new Size(203, 60);
            label4.Name = "label4";
            label4.Size = new Size(203, 60);
            label4.TabIndex = 3;
            label4.Text = "Progress Bar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.DarkSlateGray;
            progressBar.Location = new Point(3, 403);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(203, 29);
            progressBar.TabIndex = 0;
            // 
            // State_box
            // 
            State_box.BackColor = SystemColors.ButtonFace;
            State_box.Font = new Font("Cooper Black", 14F);
            State_box.Location = new Point(3, 263);
            State_box.Name = "State_box";
            State_box.Size = new Size(203, 34);
            State_box.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Elephant", 14F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(3, 200);
            label3.MinimumSize = new Size(203, 60);
            label3.Name = "label3";
            label3.Size = new Size(203, 60);
            label3.TabIndex = 2;
            label3.Text = "STATE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(3, 66);
            label2.MinimumSize = new Size(203, 60);
            label2.Name = "label2";
            label2.Size = new Size(203, 60);
            label2.TabIndex = 1;
            label2.Text = "2024ASI-CANSAT";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Elephant", 14F);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(3, 3);
            label1.MinimumSize = new Size(203, 60);
            label1.Name = "label1";
            label1.Size = new Size(203, 60);
            label1.TabIndex = 0;
            label1.Text = "TEAM ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            groupBox7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox7.Location = new Point(986, 316);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(679, 545);
            groupBox7.TabIndex = 51;
            groupBox7.TabStop = false;
            groupBox7.Text = "Real Time Position";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(AccZ_box);
            groupBox6.Controls.Add(AccY_box);
            groupBox6.Controls.Add(AccX_box);
            groupBox6.Controls.Add(label27);
            groupBox6.Controls.Add(label26);
            groupBox6.Controls.Add(label25);
            groupBox6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox6.Location = new Point(496, 674);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(470, 187);
            groupBox6.TabIndex = 52;
            groupBox6.TabStop = false;
            groupBox6.Text = "Gyro - Acceleration";
            // 
            // AccZ_box
            // 
            AccZ_box.BackColor = SystemColors.ButtonFace;
            AccZ_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccZ_box.Location = new Point(311, 117);
            AccZ_box.Name = "AccZ_box";
            AccZ_box.Size = new Size(140, 45);
            AccZ_box.TabIndex = 62;
            AccZ_box.TextAlign = HorizontalAlignment.Center;
            // 
            // AccY_box
            // 
            AccY_box.BackColor = SystemColors.ButtonFace;
            AccY_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccY_box.Location = new Point(165, 117);
            AccY_box.Name = "AccY_box";
            AccY_box.Size = new Size(140, 45);
            AccY_box.TabIndex = 61;
            AccY_box.TextAlign = HorizontalAlignment.Center;
            // 
            // AccX_box
            // 
            AccX_box.BackColor = SystemColors.ButtonFace;
            AccX_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccX_box.Location = new Point(19, 117);
            AccX_box.Name = "AccX_box";
            AccX_box.Size = new Size(140, 45);
            AccX_box.TabIndex = 60;
            AccX_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.DarkSlateGray;
            label27.BorderStyle = BorderStyle.Fixed3D;
            label27.Font = new Font("Elephant", 12F);
            label27.ForeColor = SystemColors.HighlightText;
            label27.Location = new Point(311, 42);
            label27.MinimumSize = new Size(140, 45);
            label27.Name = "label27";
            label27.Size = new Size(140, 45);
            label27.TabIndex = 59;
            label27.Text = "Acc Z";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.DarkSlateGray;
            label26.BorderStyle = BorderStyle.Fixed3D;
            label26.Font = new Font("Elephant", 12F);
            label26.ForeColor = SystemColors.HighlightText;
            label26.Location = new Point(165, 42);
            label26.MinimumSize = new Size(140, 45);
            label26.Name = "label26";
            label26.Size = new Size(140, 45);
            label26.TabIndex = 58;
            label26.Text = "Acc Y";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.DarkSlateGray;
            label25.BorderStyle = BorderStyle.Fixed3D;
            label25.Font = new Font("Elephant", 12F);
            label25.ForeColor = SystemColors.HighlightText;
            label25.Location = new Point(19, 42);
            label25.MinimumSize = new Size(140, 45);
            label25.Name = "label25";
            label25.Size = new Size(140, 45);
            label25.TabIndex = 57;
            label25.Text = "Acc X";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Parachute2_status);
            groupBox5.Controls.Add(label24);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(Parachute1_status);
            groupBox5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox5.Location = new Point(9, 674);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(470, 187);
            groupBox5.TabIndex = 51;
            groupBox5.TabStop = false;
            groupBox5.Text = "Parachute status";
            // 
            // Parachute2_status
            // 
            Parachute2_status.BackColor = Color.Firebrick;
            Parachute2_status.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Parachute2_status.Location = new Point(258, 122);
            Parachute2_status.Name = "Parachute2_status";
            Parachute2_status.Size = new Size(160, 45);
            Parachute2_status.TabIndex = 61;
            Parachute2_status.TextAlign = HorizontalAlignment.Center;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.DarkSlateGray;
            label24.BorderStyle = BorderStyle.Fixed3D;
            label24.Font = new Font("Elephant", 12F);
            label24.ForeColor = SystemColors.HighlightText;
            label24.Location = new Point(52, 42);
            label24.MinimumSize = new Size(200, 45);
            label24.Name = "label24";
            label24.Size = new Size(200, 45);
            label24.TabIndex = 60;
            label24.Text = "Parachute 1";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.DarkSlateGray;
            label23.BorderStyle = BorderStyle.Fixed3D;
            label23.Font = new Font("Elephant", 12F);
            label23.ForeColor = SystemColors.HighlightText;
            label23.Location = new Point(52, 122);
            label23.MinimumSize = new Size(200, 45);
            label23.Name = "label23";
            label23.Size = new Size(200, 45);
            label23.TabIndex = 62;
            label23.Text = "Parachute 2";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Parachute1_status
            // 
            Parachute1_status.BackColor = Color.ForestGreen;
            Parachute1_status.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Parachute1_status.Location = new Point(258, 42);
            Parachute1_status.Name = "Parachute1_status";
            Parachute1_status.Size = new Size(160, 45);
            Parachute1_status.TabIndex = 59;
            Parachute1_status.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Yaw_box);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(Roll_box);
            groupBox3.Controls.Add(Pitch_box);
            groupBox3.Controls.Add(label17);
            groupBox3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(496, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 352);
            groupBox3.TabIndex = 50;
            groupBox3.TabStop = false;
            groupBox3.Text = "3D Data";
            // 
            // Yaw_box
            // 
            Yaw_box.BackColor = SystemColors.ButtonFace;
            Yaw_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Yaw_box.Location = new Point(257, 253);
            Yaw_box.Name = "Yaw_box";
            Yaw_box.Size = new Size(160, 45);
            Yaw_box.TabIndex = 55;
            Yaw_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.DarkSlateGray;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Font = new Font("Elephant", 12F);
            label18.ForeColor = SystemColors.HighlightText;
            label18.Location = new Point(51, 71);
            label18.MinimumSize = new Size(200, 45);
            label18.Name = "label18";
            label18.Size = new Size(200, 45);
            label18.TabIndex = 52;
            label18.Text = "Roll";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkSlateGray;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Font = new Font("Elephant", 12F);
            label16.ForeColor = SystemColors.HighlightText;
            label16.Location = new Point(51, 253);
            label16.MinimumSize = new Size(200, 45);
            label16.Name = "label16";
            label16.Size = new Size(200, 45);
            label16.TabIndex = 56;
            label16.Text = "Yaw";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Roll_box
            // 
            Roll_box.BackColor = SystemColors.ButtonFace;
            Roll_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Roll_box.Location = new Point(257, 71);
            Roll_box.Name = "Roll_box";
            Roll_box.Size = new Size(160, 45);
            Roll_box.TabIndex = 51;
            Roll_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Pitch_box
            // 
            Pitch_box.BackColor = SystemColors.ButtonFace;
            Pitch_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pitch_box.Location = new Point(257, 160);
            Pitch_box.Name = "Pitch_box";
            Pitch_box.Size = new Size(160, 45);
            Pitch_box.TabIndex = 53;
            Pitch_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.DarkSlateGray;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Font = new Font("Elephant", 12F);
            label17.ForeColor = SystemColors.HighlightText;
            label17.Location = new Point(51, 160);
            label17.MinimumSize = new Size(200, 45);
            label17.Name = "label17";
            label17.Size = new Size(200, 45);
            label17.TabIndex = 54;
            label17.Text = "Pitch";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Temp_sensor_box);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(Pressure_sensor_box);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(RTC_sensor_box);
            groupBox4.Controls.Add(IMU_sensor_box);
            groupBox4.Controls.Add(label20);
            groupBox4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox4.Location = new Point(9, 316);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(470, 352);
            groupBox4.TabIndex = 49;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sensor Status";
            // 
            // Temp_sensor_box
            // 
            Temp_sensor_box.BackColor = Color.ForestGreen;
            Temp_sensor_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Temp_sensor_box.Location = new Point(258, 278);
            Temp_sensor_box.Name = "Temp_sensor_box";
            Temp_sensor_box.Size = new Size(160, 45);
            Temp_sensor_box.TabIndex = 57;
            Temp_sensor_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.DarkSlateGray;
            label22.BorderStyle = BorderStyle.Fixed3D;
            label22.Font = new Font("Elephant", 12F);
            label22.ForeColor = SystemColors.HighlightText;
            label22.Location = new Point(52, 278);
            label22.MinimumSize = new Size(200, 45);
            label22.Name = "label22";
            label22.Size = new Size(200, 45);
            label22.TabIndex = 58;
            label22.Text = "Temperature";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pressure_sensor_box
            // 
            Pressure_sensor_box.BackColor = Color.ForestGreen;
            Pressure_sensor_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pressure_sensor_box.Location = new Point(258, 198);
            Pressure_sensor_box.Name = "Pressure_sensor_box";
            Pressure_sensor_box.Size = new Size(160, 45);
            Pressure_sensor_box.TabIndex = 55;
            Pressure_sensor_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.DarkSlateGray;
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Font = new Font("Elephant", 12F);
            label21.ForeColor = SystemColors.HighlightText;
            label21.Location = new Point(52, 39);
            label21.MinimumSize = new Size(200, 45);
            label21.Name = "label21";
            label21.Size = new Size(200, 45);
            label21.TabIndex = 52;
            label21.Text = "RTC";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.DarkSlateGray;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Font = new Font("Elephant", 12F);
            label19.ForeColor = SystemColors.HighlightText;
            label19.Location = new Point(52, 198);
            label19.MinimumSize = new Size(200, 45);
            label19.Name = "label19";
            label19.Size = new Size(200, 45);
            label19.TabIndex = 56;
            label19.Text = "Pressure";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RTC_sensor_box
            // 
            RTC_sensor_box.BackColor = Color.ForestGreen;
            RTC_sensor_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RTC_sensor_box.Location = new Point(258, 39);
            RTC_sensor_box.Name = "RTC_sensor_box";
            RTC_sensor_box.Size = new Size(160, 45);
            RTC_sensor_box.TabIndex = 51;
            RTC_sensor_box.TextAlign = HorizontalAlignment.Center;
            // 
            // IMU_sensor_box
            // 
            IMU_sensor_box.BackColor = Color.ForestGreen;
            IMU_sensor_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IMU_sensor_box.Location = new Point(258, 117);
            IMU_sensor_box.Name = "IMU_sensor_box";
            IMU_sensor_box.Size = new Size(160, 45);
            IMU_sensor_box.TabIndex = 53;
            IMU_sensor_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.DarkSlateGray;
            label20.BorderStyle = BorderStyle.Fixed3D;
            label20.Font = new Font("Elephant", 12F);
            label20.ForeColor = SystemColors.HighlightText;
            label20.Location = new Point(52, 117);
            label20.MinimumSize = new Size(200, 45);
            label20.Name = "label20";
            label20.Size = new Size(200, 45);
            label20.TabIndex = 54;
            label20.Text = "IMU";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(textBox14);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 867);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1668, 71);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Telemetry";
            // 
            // textBox14
            // 
            textBox14.BackColor = SystemColors.ButtonFace;
            textBox14.Font = new Font("Copperplate Gothic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox14.Location = new Point(6, 27);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(1656, 38);
            textBox14.TabIndex = 48;
            textBox14.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(GNSS_time_box);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(GNSS_alt_box);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(GNSS_long_box);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(GNSS_lat_box);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(GNSS_spin_box);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(GNSS_sat_box);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(Voltage_box);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Temp_box);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(Pressure_box);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(Altitude_box);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Packet_count_box);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Mission_time_box);
            groupBox1.Controls.Add(Mission_time_label);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1669, 307);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Telemetry data values";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // GNSS_time_box
            // 
            GNSS_time_box.BackColor = SystemColors.ButtonFace;
            GNSS_time_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GNSS_time_box.Location = new Point(1482, 226);
            GNSS_time_box.Name = "GNSS_time_box";
            GNSS_time_box.Size = new Size(160, 45);
            GNSS_time_box.TabIndex = 49;
            GNSS_time_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkSlateGray;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Elephant", 12F);
            label12.ForeColor = SystemColors.HighlightText;
            label12.Location = new Point(1276, 226);
            label12.MinimumSize = new Size(200, 45);
            label12.Name = "label12";
            label12.Size = new Size(200, 45);
            label12.TabIndex = 50;
            label12.Text = "GNSS Time";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GNSS_alt_box
            // 
            GNSS_alt_box.BackColor = SystemColors.ButtonFace;
            GNSS_alt_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GNSS_alt_box.Location = new Point(1066, 226);
            GNSS_alt_box.Name = "GNSS_alt_box";
            GNSS_alt_box.Size = new Size(160, 45);
            GNSS_alt_box.TabIndex = 47;
            GNSS_alt_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkSlateGray;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Font = new Font("Elephant", 12F);
            label13.ForeColor = SystemColors.HighlightText;
            label13.Location = new Point(860, 226);
            label13.MinimumSize = new Size(200, 45);
            label13.Name = "label13";
            label13.Size = new Size(200, 45);
            label13.TabIndex = 48;
            label13.Text = "GNSS Altitude";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GNSS_long_box
            // 
            GNSS_long_box.BackColor = SystemColors.ButtonFace;
            GNSS_long_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GNSS_long_box.Location = new Point(650, 226);
            GNSS_long_box.Name = "GNSS_long_box";
            GNSS_long_box.Size = new Size(160, 45);
            GNSS_long_box.TabIndex = 45;
            GNSS_long_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.DarkSlateGray;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Font = new Font("Elephant", 12F);
            label14.ForeColor = SystemColors.HighlightText;
            label14.Location = new Point(444, 226);
            label14.MinimumSize = new Size(200, 45);
            label14.Name = "label14";
            label14.Size = new Size(200, 45);
            label14.TabIndex = 46;
            label14.Text = "GNSS Longitude";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GNSS_lat_box
            // 
            GNSS_lat_box.BackColor = SystemColors.ButtonFace;
            GNSS_lat_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GNSS_lat_box.Location = new Point(234, 226);
            GNSS_lat_box.Name = "GNSS_lat_box";
            GNSS_lat_box.Size = new Size(160, 45);
            GNSS_lat_box.TabIndex = 43;
            GNSS_lat_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.DarkSlateGray;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Font = new Font("Elephant", 12F);
            label15.ForeColor = SystemColors.HighlightText;
            label15.Location = new Point(28, 226);
            label15.MinimumSize = new Size(200, 45);
            label15.Name = "label15";
            label15.Size = new Size(200, 45);
            label15.TabIndex = 44;
            label15.Text = "GNSS Latitude";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GNSS_spin_box
            // 
            GNSS_spin_box.BackColor = SystemColors.ButtonFace;
            GNSS_spin_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GNSS_spin_box.Location = new Point(1482, 133);
            GNSS_spin_box.Name = "GNSS_spin_box";
            GNSS_spin_box.Size = new Size(160, 45);
            GNSS_spin_box.TabIndex = 41;
            GNSS_spin_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSlateGray;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Elephant", 12F);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(1276, 133);
            label5.MinimumSize = new Size(200, 45);
            label5.Name = "label5";
            label5.Size = new Size(200, 45);
            label5.TabIndex = 42;
            label5.Text = "GNSS Spin rate";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GNSS_sat_box
            // 
            GNSS_sat_box.BackColor = SystemColors.ButtonFace;
            GNSS_sat_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GNSS_sat_box.Location = new Point(1066, 133);
            GNSS_sat_box.Name = "GNSS_sat_box";
            GNSS_sat_box.Size = new Size(160, 45);
            GNSS_sat_box.TabIndex = 39;
            GNSS_sat_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkSlateGray;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Elephant", 12F);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(860, 133);
            label9.MinimumSize = new Size(200, 45);
            label9.Name = "label9";
            label9.Size = new Size(200, 45);
            label9.TabIndex = 40;
            label9.Text = "GNSS Satellite";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Voltage_box
            // 
            Voltage_box.BackColor = SystemColors.ButtonFace;
            Voltage_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Voltage_box.Location = new Point(650, 133);
            Voltage_box.Name = "Voltage_box";
            Voltage_box.Size = new Size(160, 45);
            Voltage_box.TabIndex = 37;
            Voltage_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkSlateGray;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Elephant", 12F);
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(444, 133);
            label10.MinimumSize = new Size(200, 45);
            label10.Name = "label10";
            label10.Size = new Size(200, 45);
            label10.TabIndex = 38;
            label10.Text = "Voltage";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Temp_box
            // 
            Temp_box.BackColor = SystemColors.ButtonFace;
            Temp_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Temp_box.Location = new Point(234, 133);
            Temp_box.Name = "Temp_box";
            Temp_box.Size = new Size(160, 45);
            Temp_box.TabIndex = 35;
            Temp_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkSlateGray;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Elephant", 12F);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(28, 133);
            label11.MinimumSize = new Size(200, 45);
            label11.Name = "label11";
            label11.Size = new Size(200, 45);
            label11.TabIndex = 36;
            label11.Text = "Temperature";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pressure_box
            // 
            Pressure_box.BackColor = SystemColors.ButtonFace;
            Pressure_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pressure_box.Location = new Point(1482, 44);
            Pressure_box.Name = "Pressure_box";
            Pressure_box.Size = new Size(160, 45);
            Pressure_box.TabIndex = 33;
            Pressure_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkSlateGray;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Elephant", 12F);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(1276, 44);
            label8.MinimumSize = new Size(200, 45);
            label8.Name = "label8";
            label8.Size = new Size(200, 45);
            label8.TabIndex = 34;
            label8.Text = "Pressure";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Altitude_box
            // 
            Altitude_box.BackColor = SystemColors.ButtonFace;
            Altitude_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Altitude_box.Location = new Point(1066, 44);
            Altitude_box.Name = "Altitude_box";
            Altitude_box.Size = new Size(160, 45);
            Altitude_box.TabIndex = 31;
            Altitude_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkSlateGray;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Elephant", 12F);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(860, 44);
            label7.MinimumSize = new Size(200, 45);
            label7.Name = "label7";
            label7.Size = new Size(200, 45);
            label7.TabIndex = 32;
            label7.Text = "Altitude";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Packet_count_box
            // 
            Packet_count_box.BackColor = SystemColors.ButtonFace;
            Packet_count_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Packet_count_box.Location = new Point(650, 44);
            Packet_count_box.Name = "Packet_count_box";
            Packet_count_box.Size = new Size(160, 45);
            Packet_count_box.TabIndex = 29;
            Packet_count_box.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkSlateGray;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Elephant", 12F);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(444, 44);
            label6.MinimumSize = new Size(200, 45);
            label6.Name = "label6";
            label6.Size = new Size(200, 45);
            label6.TabIndex = 30;
            label6.Text = "Packet  Count";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Mission_time_box
            // 
            Mission_time_box.BackColor = SystemColors.ButtonFace;
            Mission_time_box.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mission_time_box.Location = new Point(234, 44);
            Mission_time_box.Name = "Mission_time_box";
            Mission_time_box.Size = new Size(160, 45);
            Mission_time_box.TabIndex = 27;
            Mission_time_box.TextAlign = HorizontalAlignment.Center;
            Mission_time_box.TextChanged += textBox2_TextChanged;
            // 
            // Mission_time_label
            // 
            Mission_time_label.AutoSize = true;
            Mission_time_label.BackColor = Color.DarkSlateGray;
            Mission_time_label.BorderStyle = BorderStyle.Fixed3D;
            Mission_time_label.Font = new Font("Elephant", 12F);
            Mission_time_label.ForeColor = SystemColors.HighlightText;
            Mission_time_label.Location = new Point(28, 44);
            Mission_time_label.MinimumSize = new Size(200, 45);
            Mission_time_label.Name = "Mission_time_label";
            Mission_time_label.Size = new Size(200, 45);
            Mission_time_label.TabIndex = 28;
            Mission_time_label.Text = "Mission Time";
            Mission_time_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkSlateGray;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1896, 950);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Graph";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.DarkOliveGreen;
            tabPage3.Controls.Add(Loadmapbtn);
            tabPage3.Controls.Add(gmaplong_txt);
            tabPage3.Controls.Add(gmaplong);
            tabPage3.Controls.Add(gmaplat_txt);
            tabPage3.Controls.Add(gmaplat);
            tabPage3.Controls.Add(splitter1);
            tabPage3.Controls.Add(gMap);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1896, 950);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Map";
            // 
            // Loadmapbtn
            // 
            Loadmapbtn.BackColor = Color.CadetBlue;
            Loadmapbtn.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loadmapbtn.ForeColor = SystemColors.HighlightText;
            Loadmapbtn.Location = new Point(10, 451);
            Loadmapbtn.Name = "Loadmapbtn";
            Loadmapbtn.Size = new Size(203, 59);
            Loadmapbtn.TabIndex = 7;
            Loadmapbtn.Text = "Load MAP";
            Loadmapbtn.UseVisualStyleBackColor = false;
            Loadmapbtn.Click += Loadmapbtn_Click;
            // 
            // gmaplong_txt
            // 
            gmaplong_txt.BackColor = SystemColors.ButtonFace;
            gmaplong_txt.Font = new Font("Cooper Black", 14F);
            gmaplong_txt.Location = new Point(10, 377);
            gmaplong_txt.Name = "gmaplong_txt";
            gmaplong_txt.Size = new Size(203, 34);
            gmaplong_txt.TabIndex = 5;
            // 
            // gmaplong
            // 
            gmaplong.AutoSize = true;
            gmaplong.BackColor = Color.DarkSlateGray;
            gmaplong.BorderStyle = BorderStyle.Fixed3D;
            gmaplong.Font = new Font("Elephant", 14F);
            gmaplong.ForeColor = SystemColors.HighlightText;
            gmaplong.Location = new Point(10, 314);
            gmaplong.MinimumSize = new Size(203, 60);
            gmaplong.Name = "gmaplong";
            gmaplong.Size = new Size(203, 60);
            gmaplong.TabIndex = 6;
            gmaplong.Text = "Longitude";
            gmaplong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gmaplat_txt
            // 
            gmaplat_txt.BackColor = SystemColors.ButtonFace;
            gmaplat_txt.Font = new Font("Cooper Black", 14F);
            gmaplat_txt.Location = new Point(10, 245);
            gmaplat_txt.Name = "gmaplat_txt";
            gmaplat_txt.Size = new Size(203, 34);
            gmaplat_txt.TabIndex = 3;
            // 
            // gmaplat
            // 
            gmaplat.AutoSize = true;
            gmaplat.BackColor = Color.DarkSlateGray;
            gmaplat.BorderStyle = BorderStyle.Fixed3D;
            gmaplat.Font = new Font("Elephant", 14F);
            gmaplat.ForeColor = SystemColors.HighlightText;
            gmaplat.Location = new Point(10, 182);
            gmaplat.MinimumSize = new Size(203, 60);
            gmaplat.Name = "gmaplat";
            gmaplat.Size = new Size(203, 60);
            gmaplat.TabIndex = 4;
            gmaplat.Text = "Latitude";
            gmaplat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.DarkSeaGreen;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(223, 950);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // gMap
            // 
            gMap.Bearing = 0F;
            gMap.CanDragMap = true;
            gMap.EmptyTileColor = Color.Navy;
            gMap.GrayScaleMode = false;
            gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMap.LevelsKeepInMemory = 5;
            gMap.Location = new Point(243, 18);
            gMap.MarkersEnabled = true;
            gMap.MaxZoom = 2;
            gMap.MinZoom = 2;
            gMap.MouseWheelZoomEnabled = true;
            gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMap.Name = "gMap";
            gMap.NegativeMode = false;
            gMap.PolygonsEnabled = true;
            gMap.RetryLoadTile = 0;
            gMap.RoutesEnabled = true;
            gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMap.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMap.ShowTileGridLines = false;
            gMap.Size = new Size(1637, 912);
            gMap.TabIndex = 0;
            gMap.Zoom = 0D;
            gMap.Load += gMap_Load;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.AntiqueWhite;
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1896, 950);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 983);
            Controls.Add(Data);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Data.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Data;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox State_box;
        private ProgressBar progressBar;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox Mission_time_box;
        private Label Mission_time_label;
        private GroupBox groupBox2;
        private TextBox Pressure_box;
        private Label label8;
        private TextBox Altitude_box;
        private Label label7;
        private TextBox Packet_count_box;
        private Label label6;
        private TextBox GNSS_time_box;
        private Label label12;
        private TextBox GNSS_alt_box;
        private Label label13;
        private TextBox GNSS_long_box;
        private Label label14;
        private TextBox GNSS_lat_box;
        private Label label15;
        private TextBox GNSS_spin_box;
        private Label label5;
        private TextBox GNSS_sat_box;
        private Label label9;
        private TextBox Voltage_box;
        private Label label10;
        private TextBox Temp_box;
        private Label label11;
        private TextBox textBox14;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox7;
        private TextBox Yaw_box;
        private Label label18;
        private Label label16;
        private TextBox Roll_box;
        private TextBox Pitch_box;
        private Label label17;
        private TextBox Temp_sensor_box;
        private Label label22;
        private TextBox Pressure_sensor_box;
        private Label label21;
        private Label label19;
        private TextBox RTC_sensor_box;
        private TextBox IMU_sensor_box;
        private Label label20;
        private TextBox Parachute2_status;
        private Label label24;
        private Label label23;
        private TextBox Parachute1_status;
        private TextBox AccZ_box;
        private TextBox AccY_box;
        private TextBox AccX_box;
        private Label label27;
        private Label label26;
        private Label label25;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private Splitter splitter1;
        private Button Loadmapbtn;
        private TextBox gmaplong_txt;
        private Label gmaplong;
        private TextBox gmaplat_txt;
        private Label gmaplat;
    }
}
