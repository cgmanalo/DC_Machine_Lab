namespace Computer_Based_DC_Machinery_Laboratory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Command = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.IncomingText = new System.Windows.Forms.TextBox();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.rtfData = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnPorts = new System.Windows.Forms.Button();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chkN1 = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkI2 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkI1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkE2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkE1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReadE2C = new System.Windows.Forms.Button();
            this.btnReadE1C = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtN1Reading = new System.Windows.Forms.TextBox();
            this.btnReadN1C = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtI2Reading = new System.Windows.Forms.TextBox();
            this.btnReadI2C = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtI1Reading = new System.Windows.Forms.TextBox();
            this.btnReadI1C = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtE2Reading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtE1Reading = new System.Windows.Forms.TextBox();
            this.selectExperimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLaboratoryManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Command
            // 
            this.Command.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Command.FormattingEnabled = true;
            this.Command.Items.AddRange(new object[] {
            "~~~LIGHT1|ON^^^",
            "~~~LIGHT1|OFF^^^",
            "~~~LIGHT1|TOG^^^",
            "~~~ACU1A|ON^^^",
            "~~~ACU1A|OFF^^^",
            "~~~ACU1A|TOG^^^",
            "~~~ACU1B|ON^^^",
            "~~~ACU1B|OFF^^^",
            "~~~ACU1B|TOG^^^",
            "~~~PA1|VOLT^^^",
            "~~~PA1|CURR^^^",
            "~~~PA2|VOLT^^^",
            "~~~PA2|CURR^^^",
            "~~~PA3|VOLT^^^",
            "~~~PA3|CURR^^^",
            "~~~XR^^^",
            "~~~XBT^^^"});
            this.Command.Location = new System.Drawing.Point(157, 72);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(202, 21);
            this.Command.TabIndex = 8;
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Send.Location = new System.Drawing.Point(34, 72);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(105, 23);
            this.Send.TabIndex = 7;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // PortList
            // 
            this.PortList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(157, 32);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(202, 21);
            this.PortList.TabIndex = 6;
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.Lime;
            this.Connect.Location = new System.Drawing.Point(34, 32);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(105, 23);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // IncomingText
            // 
            this.IncomingText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IncomingText.Location = new System.Drawing.Point(1107, 74);
            this.IncomingText.Multiline = true;
            this.IncomingText.Name = "IncomingText";
            this.IncomingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IncomingText.Size = new System.Drawing.Size(229, 63);
            this.IncomingText.TabIndex = 9;
            // 
            // TimerMain
            // 
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // rtfData
            // 
            this.rtfData.AcceptsTab = true;
            this.rtfData.AutoWordSelection = true;
            this.rtfData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtfData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfData.EnableAutoDragDrop = true;
            this.rtfData.Location = new System.Drawing.Point(34, 171);
            this.rtfData.Name = "rtfData";
            this.rtfData.Size = new System.Drawing.Size(1302, 509);
            this.rtfData.TabIndex = 11;
            this.rtfData.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(31, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Experiment Title: ";
            // 
            // lblExpTitle
            // 
            this.lblExpTitle.AutoSize = true;
            this.lblExpTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblExpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpTitle.ForeColor = System.Drawing.Color.Green;
            this.lblExpTitle.Location = new System.Drawing.Point(165, 150);
            this.lblExpTitle.Name = "lblExpTitle";
            this.lblExpTitle.Size = new System.Drawing.Size(0, 16);
            this.lblExpTitle.TabIndex = 13;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(1109, 37);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 20);
            this.lblDateTime.TabIndex = 29;
            // 
            // btnPorts
            // 
            this.btnPorts.AutoEllipsis = true;
            this.btnPorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorts.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.square_wave3;
            this.btnPorts.Location = new System.Drawing.Point(365, 30);
            this.btnPorts.Name = "btnPorts";
            this.btnPorts.Size = new System.Drawing.Size(23, 23);
            this.btnPorts.TabIndex = 30;
            this.btnPorts.UseVisualStyleBackColor = true;
            this.btnPorts.Click += new System.EventHandler(this.btnPorts_Click);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trkSpeed);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.chkN1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.chkI2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.chkI1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.chkE2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.chkE1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnReadE2C);
            this.groupBox1.Controls.Add(this.btnReadE1C);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtN1Reading);
            this.groupBox1.Controls.Add(this.btnReadN1C);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtI2Reading);
            this.groupBox1.Controls.Add(this.btnReadI2C);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtI1Reading);
            this.groupBox1.Controls.Add(this.btnReadI1C);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtE2Reading);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtE1Reading);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(418, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 107);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instrument and Control Panel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(246, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "|----------- DC Ammeter ---------|";
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(586, 15);
            this.trkSpeed.Maximum = 100;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkSpeed.Size = new System.Drawing.Size(45, 86);
            this.trkSpeed.TabIndex = 58;
            this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox5.Location = new System.Drawing.Point(526, 47);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 18);
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // chkN1
            // 
            this.chkN1.AutoSize = true;
            this.chkN1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkN1.Location = new System.Drawing.Point(511, 47);
            this.chkN1.Name = "chkN1";
            this.chkN1.Size = new System.Drawing.Size(15, 14);
            this.chkN1.TabIndex = 56;
            this.chkN1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox4.Location = new System.Drawing.Point(417, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 18);
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // chkI2
            // 
            this.chkI2.AutoSize = true;
            this.chkI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkI2.Enabled = false;
            this.chkI2.Location = new System.Drawing.Point(402, 47);
            this.chkI2.Name = "chkI2";
            this.chkI2.Size = new System.Drawing.Size(15, 14);
            this.chkI2.TabIndex = 54;
            this.chkI2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox3.Location = new System.Drawing.Point(309, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 18);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // chkI1
            // 
            this.chkI1.AutoSize = true;
            this.chkI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkI1.Location = new System.Drawing.Point(294, 47);
            this.chkI1.Name = "chkI1";
            this.chkI1.Size = new System.Drawing.Size(15, 14);
            this.chkI1.TabIndex = 52;
            this.chkI1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox2.Location = new System.Drawing.Point(202, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 18);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // chkE2
            // 
            this.chkE2.AutoSize = true;
            this.chkE2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkE2.Enabled = false;
            this.chkE2.Location = new System.Drawing.Point(187, 47);
            this.chkE2.Name = "chkE2";
            this.chkE2.Size = new System.Drawing.Size(15, 14);
            this.chkE2.TabIndex = 50;
            this.chkE2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(94, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // chkE1
            // 
            this.chkE1.AutoSize = true;
            this.chkE1.Location = new System.Drawing.Point(79, 47);
            this.chkE1.Name = "chkE1";
            this.chkE1.Size = new System.Drawing.Size(15, 14);
            this.chkE1.TabIndex = 47;
            this.chkE1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "|----------- DC Voltmeter ---------|";
            // 
            // btnReadE2C
            // 
            this.btnReadE2C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReadE2C.Enabled = false;
            this.btnReadE2C.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadE2C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReadE2C.Location = new System.Drawing.Point(140, 42);
            this.btnReadE2C.Name = "btnReadE2C";
            this.btnReadE2C.Size = new System.Drawing.Size(41, 23);
            this.btnReadE2C.TabIndex = 45;
            this.btnReadE2C.Text = "E2";
            this.btnReadE2C.UseVisualStyleBackColor = true;
            this.btnReadE2C.Click += new System.EventHandler(this.btnReadE2C_Click);
            // 
            // btnReadE1C
            // 
            this.btnReadE1C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReadE1C.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadE1C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReadE1C.Location = new System.Drawing.Point(32, 43);
            this.btnReadE1C.Name = "btnReadE1C";
            this.btnReadE1C.Size = new System.Drawing.Size(41, 23);
            this.btnReadE1C.TabIndex = 44;
            this.btnReadE1C.Text = "E1";
            this.btnReadE1C.UseVisualStyleBackColor = true;
            this.btnReadE1C.Click += new System.EventHandler(this.btnReadE1C_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(542, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "RPM";
            // 
            // txtN1Reading
            // 
            this.txtN1Reading.BackColor = System.Drawing.Color.Black;
            this.txtN1Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1Reading.ForeColor = System.Drawing.Color.Lime;
            this.txtN1Reading.Location = new System.Drawing.Point(465, 73);
            this.txtN1Reading.Name = "txtN1Reading";
            this.txtN1Reading.Size = new System.Drawing.Size(75, 22);
            this.txtN1Reading.TabIndex = 42;
            this.txtN1Reading.Text = "00.00";
            // 
            // btnReadN1C
            // 
            this.btnReadN1C.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadN1C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReadN1C.Location = new System.Drawing.Point(465, 43);
            this.btnReadN1C.Name = "btnReadN1C";
            this.btnReadN1C.Size = new System.Drawing.Size(40, 24);
            this.btnReadN1C.TabIndex = 41;
            this.btnReadN1C.Text = "N1";
            this.btnReadN1C.UseVisualStyleBackColor = true;
            this.btnReadN1C.Click += new System.EventHandler(this.btnReadN1C_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(434, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "A";
            // 
            // txtI2Reading
            // 
            this.txtI2Reading.BackColor = System.Drawing.Color.Black;
            this.txtI2Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtI2Reading.ForeColor = System.Drawing.Color.Lime;
            this.txtI2Reading.Location = new System.Drawing.Point(357, 71);
            this.txtI2Reading.Name = "txtI2Reading";
            this.txtI2Reading.Size = new System.Drawing.Size(75, 22);
            this.txtI2Reading.TabIndex = 39;
            this.txtI2Reading.Text = "00.00";
            // 
            // btnReadI2C
            // 
            this.btnReadI2C.Enabled = false;
            this.btnReadI2C.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadI2C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReadI2C.Location = new System.Drawing.Point(357, 42);
            this.btnReadI2C.Name = "btnReadI2C";
            this.btnReadI2C.Size = new System.Drawing.Size(40, 23);
            this.btnReadI2C.TabIndex = 38;
            this.btnReadI2C.Text = "I2";
            this.btnReadI2C.UseVisualStyleBackColor = true;
            this.btnReadI2C.Click += new System.EventHandler(this.btnReadI2C_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(326, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "A";
            // 
            // txtI1Reading
            // 
            this.txtI1Reading.BackColor = System.Drawing.Color.Black;
            this.txtI1Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtI1Reading.ForeColor = System.Drawing.Color.Lime;
            this.txtI1Reading.Location = new System.Drawing.Point(249, 71);
            this.txtI1Reading.Name = "txtI1Reading";
            this.txtI1Reading.Size = new System.Drawing.Size(75, 22);
            this.txtI1Reading.TabIndex = 36;
            this.txtI1Reading.Text = "00.00";
            // 
            // btnReadI1C
            // 
            this.btnReadI1C.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadI1C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReadI1C.Location = new System.Drawing.Point(249, 42);
            this.btnReadI1C.Name = "btnReadI1C";
            this.btnReadI1C.Size = new System.Drawing.Size(40, 23);
            this.btnReadI1C.TabIndex = 35;
            this.btnReadI1C.Text = "I1";
            this.btnReadI1C.UseVisualStyleBackColor = true;
            this.btnReadI1C.Click += new System.EventHandler(this.btnReadI1C_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(218, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "V";
            // 
            // txtE2Reading
            // 
            this.txtE2Reading.BackColor = System.Drawing.Color.Black;
            this.txtE2Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE2Reading.ForeColor = System.Drawing.Color.Lime;
            this.txtE2Reading.Location = new System.Drawing.Point(141, 71);
            this.txtE2Reading.Name = "txtE2Reading";
            this.txtE2Reading.Size = new System.Drawing.Size(75, 22);
            this.txtE2Reading.TabIndex = 33;
            this.txtE2Reading.Text = "00.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(109, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "V";
            // 
            // txtE1Reading
            // 
            this.txtE1Reading.BackColor = System.Drawing.Color.Black;
            this.txtE1Reading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE1Reading.ForeColor = System.Drawing.Color.Lime;
            this.txtE1Reading.Location = new System.Drawing.Point(32, 71);
            this.txtE1Reading.Name = "txtE1Reading";
            this.txtE1Reading.Size = new System.Drawing.Size(75, 22);
            this.txtE1Reading.TabIndex = 30;
            this.txtE1Reading.Text = "00.00";
            // 
            // selectExperimentToolStripMenuItem
            // 
            this.selectExperimentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLaboratoryManualToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.selectExperimentToolStripMenuItem.Name = "selectExperimentToolStripMenuItem";
            this.selectExperimentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.selectExperimentToolStripMenuItem.Text = " Experiment";
            // 
            // openLaboratoryManualToolStripMenuItem
            // 
            this.openLaboratoryManualToolStripMenuItem.Name = "openLaboratoryManualToolStripMenuItem";
            this.openLaboratoryManualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openLaboratoryManualToolStripMenuItem.Text = "Open";
            this.openLaboratoryManualToolStripMenuItem.Click += new System.EventHandler(this.openLaboratoryManualToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectExperimentToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 708);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPorts);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblExpTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtfData);
            this.Controls.Add(this.IncomingText);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DC Machinery Laboratory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Command;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox IncomingText;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.RichTextBox rtfData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnPorts;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtN1Reading;
        private System.Windows.Forms.Button btnReadN1C;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtI2Reading;
        private System.Windows.Forms.Button btnReadI2C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtI1Reading;
        private System.Windows.Forms.Button btnReadI1C;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtE2Reading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtE1Reading;
        private System.Windows.Forms.ToolStripMenuItem selectExperimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLaboratoryManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnReadE1C;
        private System.Windows.Forms.Button btnReadE2C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkE1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkE2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkI1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chkI2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox chkN1;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.Label label8;
    }
}

