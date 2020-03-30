namespace Computer_Based_DC_Machinery_Laboratory
{
    //partial class MainForm
    public partial class MainForm
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
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.selectExperimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLaboratoryManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.experiment1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experiment2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experiment3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connect = new System.Windows.Forms.Button();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.Command = new System.Windows.Forms.ComboBox();
            this.IncomingText = new System.Windows.Forms.TextBox();
            this.rtfData = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnPorts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtE1Reading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtE2Reading = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadI1C = new System.Windows.Forms.Button();
            this.txtI1Reading = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReadI2C = new System.Windows.Forms.Button();
            this.txtI2Reading = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReadN1C = new System.Windows.Forms.Button();
            this.txtN1Reading = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReadE1C = new System.Windows.Forms.Button();
            this.btnReadE2C = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkE1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkE2 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkI1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkI2 = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkN1 = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.grpPanel = new System.Windows.Forms.GroupBox();
            this.pnlE3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label30 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this._3_7_4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this._3_7_3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this._3_7_2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this._3_5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this._3_4_5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClearText = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.lblDateTimeShadow = new System.Windows.Forms.Label();
            this.pnlE4 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            this.grpPanel.SuspendLayout();
            this.pnlE3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.pnlE4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerMain
            // 
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(246, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "|----------- DC Ammeter ---------|";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(586, 15);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 86);
            this.trackBar1.TabIndex = 58;
            this.trackBar1.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox6.Location = new System.Drawing.Point(526, 47);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 18);
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.Location = new System.Drawing.Point(511, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox7.Location = new System.Drawing.Point(417, 47);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 18);
            this.pictureBox7.TabIndex = 55;
            this.pictureBox7.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(402, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 54;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox8.Location = new System.Drawing.Point(309, 47);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(19, 18);
            this.pictureBox8.TabIndex = 53;
            this.pictureBox8.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox3.Location = new System.Drawing.Point(294, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 52;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox9.Location = new System.Drawing.Point(202, 47);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(19, 18);
            this.pictureBox9.TabIndex = 51;
            this.pictureBox9.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(187, 47);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 50;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox10.Location = new System.Drawing.Point(94, 47);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(19, 18);
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(79, 47);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 47;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(29, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "|----------- DC Voltmeter ---------|";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(140, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "E2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnReadE2C_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(542, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "RPM";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("FESTO B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(465, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "00.00";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(465, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 24);
            this.button6.TabIndex = 41;
            this.button6.Text = "N1";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnReadN1C_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(434, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "A";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("FESTO B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(357, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "00.00";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(357, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 23);
            this.button7.TabIndex = 38;
            this.button7.Text = "I2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnReadI2C_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(326, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "A";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Font = new System.Drawing.Font("FESTO B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(249, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 36;
            this.textBox3.Text = "00.00";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(249, 43);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 23);
            this.button8.TabIndex = 35;
            this.button8.Text = "I1";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnReadI1C_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(218, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "V";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Font = new System.Drawing.Font("FESTO B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Lime;
            this.textBox4.Location = new System.Drawing.Point(141, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 22);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "00.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(109, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "V";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Font = new System.Drawing.Font("FESTO B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Lime;
            this.textBox5.Location = new System.Drawing.Point(32, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 22);
            this.textBox5.TabIndex = 30;
            this.textBox5.Text = "00.00";
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
            this.openLaboratoryManualToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openLaboratoryManualToolStripMenuItem.Text = "Open";
            this.openLaboratoryManualToolStripMenuItem.Click += new System.EventHandler(this.openLaboratoryManualToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // calibrateToolStripMenuItem
            // 
            this.calibrateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.e1ToolStripMenuItem,
            this.e2ToolStripMenuItem,
            this.e3ToolStripMenuItem,
            this.e4ToolStripMenuItem,
            this.i1ToolStripMenuItem,
            this.i2ToolStripMenuItem,
            this.i3ToolStripMenuItem,
            this.i4ToolStripMenuItem});
            this.calibrateToolStripMenuItem.Name = "calibrateToolStripMenuItem";
            this.calibrateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.calibrateToolStripMenuItem.Text = "Calibrate";
            this.calibrateToolStripMenuItem.Click += new System.EventHandler(this.calibrateToolStripMenuItem_Click);
            // 
            // e1ToolStripMenuItem
            // 
            this.e1ToolStripMenuItem.Name = "e1ToolStripMenuItem";
            this.e1ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.e1ToolStripMenuItem.Text = "E1";
            this.e1ToolStripMenuItem.Click += new System.EventHandler(this.e1ToolStripMenuItem_Click);
            // 
            // e2ToolStripMenuItem
            // 
            this.e2ToolStripMenuItem.Name = "e2ToolStripMenuItem";
            this.e2ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.e2ToolStripMenuItem.Text = "E2";
            this.e2ToolStripMenuItem.Click += new System.EventHandler(this.e2ToolStripMenuItem_Click);
            // 
            // e3ToolStripMenuItem
            // 
            this.e3ToolStripMenuItem.Name = "e3ToolStripMenuItem";
            this.e3ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.e3ToolStripMenuItem.Text = "E3";
            // 
            // e4ToolStripMenuItem
            // 
            this.e4ToolStripMenuItem.Name = "e4ToolStripMenuItem";
            this.e4ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.e4ToolStripMenuItem.Text = "E4";
            // 
            // i1ToolStripMenuItem
            // 
            this.i1ToolStripMenuItem.Name = "i1ToolStripMenuItem";
            this.i1ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.i1ToolStripMenuItem.Text = "I1";
            this.i1ToolStripMenuItem.Click += new System.EventHandler(this.i1ToolStripMenuItem_Click);
            // 
            // i2ToolStripMenuItem
            // 
            this.i2ToolStripMenuItem.Name = "i2ToolStripMenuItem";
            this.i2ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.i2ToolStripMenuItem.Text = "I2";
            this.i2ToolStripMenuItem.Click += new System.EventHandler(this.i2ToolStripMenuItem_Click);
            // 
            // i3ToolStripMenuItem
            // 
            this.i3ToolStripMenuItem.Name = "i3ToolStripMenuItem";
            this.i3ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.i3ToolStripMenuItem.Text = "I3";
            // 
            // i4ToolStripMenuItem
            // 
            this.i4ToolStripMenuItem.Name = "i4ToolStripMenuItem";
            this.i4ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.i4ToolStripMenuItem.Text = "I4";
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
            this.toolStripMenuItem1,
            this.calibrateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.experiment1ToolStripMenuItem,
            this.experiment2ToolStripMenuItem,
            this.experiment3ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Manual";
            // 
            // experiment1ToolStripMenuItem
            // 
            this.experiment1ToolStripMenuItem.Name = "experiment1ToolStripMenuItem";
            this.experiment1ToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.experiment1ToolStripMenuItem.Text = "The DC Separately-Excited Shunt Generator";
            this.experiment1ToolStripMenuItem.Click += new System.EventHandler(this.experiment1ToolStripMenuItem_Click);
            // 
            // experiment2ToolStripMenuItem
            // 
            this.experiment2ToolStripMenuItem.Name = "experiment2ToolStripMenuItem";
            this.experiment2ToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.experiment2ToolStripMenuItem.Text = "The DC Self-Excited Shunt Generator and The DC Series Generator";
            this.experiment2ToolStripMenuItem.Click += new System.EventHandler(this.experiment2ToolStripMenuItem_Click);
            // 
            // experiment3ToolStripMenuItem
            // 
            this.experiment3ToolStripMenuItem.Name = "experiment3ToolStripMenuItem";
            this.experiment3ToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.experiment3ToolStripMenuItem.Text = "The DC Compound Generator";
            this.experiment3ToolStripMenuItem.Click += new System.EventHandler(this.experiment3ToolStripMenuItem_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Connect.Location = new System.Drawing.Point(1075, 69);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(92, 23);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // PortList
            // 
            this.PortList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(1173, 69);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(127, 21);
            this.PortList.TabIndex = 6;
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Send.Location = new System.Drawing.Point(1075, 95);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(92, 23);
            this.Send.TabIndex = 7;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Command
            // 
            this.Command.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Command.FormattingEnabled = true;
            this.Command.Items.AddRange(new object[] {
            "CAL|E1",
            "CAL|E2",
            "CAL|I1",
            "CAL|I2",
            "RCAL|E1",
            "RCAL|E2",
            "RCAL|I1",
            "RCAL|I2",
            "HB"});
            this.Command.Location = new System.Drawing.Point(1173, 96);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(127, 21);
            this.Command.TabIndex = 8;
            // 
            // IncomingText
            // 
            this.IncomingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IncomingText.Location = new System.Drawing.Point(1075, 125);
            this.IncomingText.Multiline = true;
            this.IncomingText.Name = "IncomingText";
            this.IncomingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IncomingText.Size = new System.Drawing.Size(254, 49);
            this.IncomingText.TabIndex = 9;
            // 
            // rtfData
            // 
            this.rtfData.AcceptsTab = true;
            this.rtfData.AutoWordSelection = true;
            this.rtfData.BackColor = System.Drawing.Color.White;
            this.rtfData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfData.EnableAutoDragDrop = true;
            this.rtfData.Location = new System.Drawing.Point(34, 77);
            this.rtfData.Margin = new System.Windows.Forms.Padding(10, 3, 8, 3);
            this.rtfData.Name = "rtfData";
            this.rtfData.Size = new System.Drawing.Size(1013, 365);
            this.rtfData.TabIndex = 11;
            this.rtfData.Text = "";
            this.rtfData.ZoomFactor = 2F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(31, 58);
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
            this.lblExpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblExpTitle.Location = new System.Drawing.Point(165, 58);
            this.lblExpTitle.Name = "lblExpTitle";
            this.lblExpTitle.Size = new System.Drawing.Size(0, 16);
            this.lblExpTitle.TabIndex = 13;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDateTime.Location = new System.Drawing.Point(1076, 24);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(25, 24);
            this.lblDateTime.TabIndex = 29;
            this.lblDateTime.Text = "A";
            // 
            // btnPorts
            // 
            this.btnPorts.AutoEllipsis = true;
            this.btnPorts.BackColor = System.Drawing.Color.White;
            this.btnPorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorts.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.square_wave3;
            this.btnPorts.Location = new System.Drawing.Point(1306, 69);
            this.btnPorts.Name = "btnPorts";
            this.btnPorts.Size = new System.Drawing.Size(23, 23);
            this.btnPorts.TabIndex = 30;
            this.btnPorts.UseVisualStyleBackColor = false;
            this.btnPorts.Click += new System.EventHandler(this.btnPorts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(1090, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 482);
            this.panel1.TabIndex = 32;
            // 
            // txtE1Reading
            // 
            this.txtE1Reading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtE1Reading.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE1Reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtE1Reading.Location = new System.Drawing.Point(17, 78);
            this.txtE1Reading.Name = "txtE1Reading";
            this.txtE1Reading.Size = new System.Drawing.Size(90, 26);
            this.txtE1Reading.TabIndex = 30;
            this.txtE1Reading.Text = "000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(108, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "V";
            // 
            // txtE2Reading
            // 
            this.txtE2Reading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtE2Reading.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE2Reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtE2Reading.Location = new System.Drawing.Point(134, 78);
            this.txtE2Reading.Name = "txtE2Reading";
            this.txtE2Reading.Size = new System.Drawing.Size(90, 26);
            this.txtE2Reading.TabIndex = 33;
            this.txtE2Reading.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(224, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "V";
            // 
            // btnReadI1C
            // 
            this.btnReadI1C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadI1C.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadI1C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadI1C.Location = new System.Drawing.Point(17, 142);
            this.btnReadI1C.Name = "btnReadI1C";
            this.btnReadI1C.Size = new System.Drawing.Size(41, 22);
            this.btnReadI1C.TabIndex = 35;
            this.btnReadI1C.Text = "I1";
            this.btnReadI1C.UseCompatibleTextRendering = true;
            this.btnReadI1C.UseVisualStyleBackColor = false;
            this.btnReadI1C.Click += new System.EventHandler(this.btnReadI1C_Click);
            // 
            // txtI1Reading
            // 
            this.txtI1Reading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtI1Reading.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtI1Reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtI1Reading.Location = new System.Drawing.Point(17, 170);
            this.txtI1Reading.Name = "txtI1Reading";
            this.txtI1Reading.Size = new System.Drawing.Size(90, 26);
            this.txtI1Reading.TabIndex = 36;
            this.txtI1Reading.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(108, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "A";
            // 
            // btnReadI2C
            // 
            this.btnReadI2C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadI2C.Enabled = false;
            this.btnReadI2C.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadI2C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadI2C.Location = new System.Drawing.Point(133, 142);
            this.btnReadI2C.Name = "btnReadI2C";
            this.btnReadI2C.Size = new System.Drawing.Size(41, 22);
            this.btnReadI2C.TabIndex = 38;
            this.btnReadI2C.Text = "I2";
            this.btnReadI2C.UseCompatibleTextRendering = true;
            this.btnReadI2C.UseVisualStyleBackColor = false;
            this.btnReadI2C.Click += new System.EventHandler(this.btnReadI2C_Click);
            // 
            // txtI2Reading
            // 
            this.txtI2Reading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtI2Reading.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtI2Reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtI2Reading.Location = new System.Drawing.Point(134, 170);
            this.txtI2Reading.Name = "txtI2Reading";
            this.txtI2Reading.Size = new System.Drawing.Size(90, 26);
            this.txtI2Reading.TabIndex = 39;
            this.txtI2Reading.Text = "00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(224, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "A";
            // 
            // btnReadN1C
            // 
            this.btnReadN1C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadN1C.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadN1C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadN1C.Location = new System.Drawing.Point(17, 416);
            this.btnReadN1C.Name = "btnReadN1C";
            this.btnReadN1C.Size = new System.Drawing.Size(41, 22);
            this.btnReadN1C.TabIndex = 41;
            this.btnReadN1C.Text = "N1";
            this.btnReadN1C.UseCompatibleTextRendering = true;
            this.btnReadN1C.UseVisualStyleBackColor = false;
            this.btnReadN1C.Click += new System.EventHandler(this.btnReadN1C_Click);
            // 
            // txtN1Reading
            // 
            this.txtN1Reading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtN1Reading.Font = new System.Drawing.Font("Digital-7 Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1Reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtN1Reading.Location = new System.Drawing.Point(17, 446);
            this.txtN1Reading.Name = "txtN1Reading";
            this.txtN1Reading.Size = new System.Drawing.Size(75, 26);
            this.txtN1Reading.TabIndex = 42;
            this.txtN1Reading.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(92, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "RPM";
            // 
            // btnReadE1C
            // 
            this.btnReadE1C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadE1C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReadE1C.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnReadE1C.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReadE1C.FlatAppearance.BorderSize = 3;
            this.btnReadE1C.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadE1C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadE1C.Location = new System.Drawing.Point(17, 50);
            this.btnReadE1C.Name = "btnReadE1C";
            this.btnReadE1C.Size = new System.Drawing.Size(41, 22);
            this.btnReadE1C.TabIndex = 44;
            this.btnReadE1C.Text = "E1";
            this.btnReadE1C.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReadE1C.UseCompatibleTextRendering = true;
            this.btnReadE1C.UseVisualStyleBackColor = false;
            this.btnReadE1C.Click += new System.EventHandler(this.btnReadE1C_Click);
            // 
            // btnReadE2C
            // 
            this.btnReadE2C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadE2C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReadE2C.Enabled = false;
            this.btnReadE2C.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadE2C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReadE2C.Location = new System.Drawing.Point(133, 50);
            this.btnReadE2C.Name = "btnReadE2C";
            this.btnReadE2C.Size = new System.Drawing.Size(41, 22);
            this.btnReadE2C.TabIndex = 45;
            this.btnReadE2C.Text = "E2";
            this.btnReadE2C.UseCompatibleTextRendering = true;
            this.btnReadE2C.UseVisualStyleBackColor = false;
            this.btnReadE2C.Click += new System.EventHandler(this.btnReadE2C_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "|------------- DC Voltmeter -----------|";
            // 
            // chkE1
            // 
            this.chkE1.AutoSize = true;
            this.chkE1.Location = new System.Drawing.Point(64, 54);
            this.chkE1.Name = "chkE1";
            this.chkE1.Size = new System.Drawing.Size(15, 14);
            this.chkE1.TabIndex = 47;
            this.chkE1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(79, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // chkE2
            // 
            this.chkE2.AutoSize = true;
            this.chkE2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkE2.Enabled = false;
            this.chkE2.Location = new System.Drawing.Point(181, 54);
            this.chkE2.Name = "chkE2";
            this.chkE2.Size = new System.Drawing.Size(15, 14);
            this.chkE2.TabIndex = 50;
            this.chkE2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox2.Location = new System.Drawing.Point(196, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 18);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // chkI1
            // 
            this.chkI1.AutoSize = true;
            this.chkI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkI1.Location = new System.Drawing.Point(63, 146);
            this.chkI1.Name = "chkI1";
            this.chkI1.Size = new System.Drawing.Size(15, 14);
            this.chkI1.TabIndex = 52;
            this.chkI1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox3.Location = new System.Drawing.Point(79, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 18);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // chkI2
            // 
            this.chkI2.AutoSize = true;
            this.chkI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkI2.Enabled = false;
            this.chkI2.Location = new System.Drawing.Point(181, 146);
            this.chkI2.Name = "chkI2";
            this.chkI2.Size = new System.Drawing.Size(15, 14);
            this.chkI2.TabIndex = 54;
            this.chkI2.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox4.Location = new System.Drawing.Point(196, 146);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 18);
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // chkN1
            // 
            this.chkN1.AutoSize = true;
            this.chkN1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkN1.Location = new System.Drawing.Point(63, 420);
            this.chkN1.Name = "chkN1";
            this.chkN1.Size = new System.Drawing.Size(15, 14);
            this.chkN1.TabIndex = 56;
            this.chkN1.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Computer_Based_DC_Machinery_Laboratory.Properties.Resources.Capture;
            this.pictureBox5.Location = new System.Drawing.Point(78, 420);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 18);
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // trkSpeed
            // 
            this.trkSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.trkSpeed.Location = new System.Drawing.Point(137, 423);
            this.trkSpeed.Maximum = 100;
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(99, 45);
            this.trkSpeed.TabIndex = 58;
            this.trkSpeed.Scroll += new System.EventHandler(this.trkSpeed_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "|------------- DC Ammeter -----------|";
            // 
            // grpPanel
            // 
            this.grpPanel.BackColor = System.Drawing.Color.Silver;
            this.grpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpPanel.Controls.Add(this.label8);
            this.grpPanel.Controls.Add(this.trkSpeed);
            this.grpPanel.Controls.Add(this.pictureBox5);
            this.grpPanel.Controls.Add(this.chkN1);
            this.grpPanel.Controls.Add(this.pictureBox4);
            this.grpPanel.Controls.Add(this.chkI2);
            this.grpPanel.Controls.Add(this.pictureBox3);
            this.grpPanel.Controls.Add(this.chkI1);
            this.grpPanel.Controls.Add(this.pictureBox2);
            this.grpPanel.Controls.Add(this.chkE2);
            this.grpPanel.Controls.Add(this.pictureBox1);
            this.grpPanel.Controls.Add(this.chkE1);
            this.grpPanel.Controls.Add(this.label7);
            this.grpPanel.Controls.Add(this.btnReadE2C);
            this.grpPanel.Controls.Add(this.btnReadE1C);
            this.grpPanel.Controls.Add(this.label6);
            this.grpPanel.Controls.Add(this.txtN1Reading);
            this.grpPanel.Controls.Add(this.btnReadN1C);
            this.grpPanel.Controls.Add(this.label5);
            this.grpPanel.Controls.Add(this.txtI2Reading);
            this.grpPanel.Controls.Add(this.btnReadI2C);
            this.grpPanel.Controls.Add(this.label4);
            this.grpPanel.Controls.Add(this.txtI1Reading);
            this.grpPanel.Controls.Add(this.btnReadI1C);
            this.grpPanel.Controls.Add(this.label3);
            this.grpPanel.Controls.Add(this.txtE2Reading);
            this.grpPanel.Controls.Add(this.label2);
            this.grpPanel.Controls.Add(this.txtE1Reading);
            this.grpPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpPanel.Location = new System.Drawing.Point(1075, 208);
            this.grpPanel.Name = "grpPanel";
            this.grpPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpPanel.Size = new System.Drawing.Size(254, 482);
            this.grpPanel.TabIndex = 33;
            this.grpPanel.TabStop = false;
            this.grpPanel.Text = "INSTRUMENT and CONTROL PANEL";
            // 
            // pnlE3
            // 
            this.pnlE3.AllowDrop = true;
            this.pnlE3.AutoScroll = true;
            this.pnlE3.BackColor = System.Drawing.Color.Silver;
            this.pnlE3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlE3.Controls.Add(this.button3);
            this.pnlE3.Controls.Add(this.button5);
            this.pnlE3.Controls.Add(this.textBox33);
            this.pnlE3.Controls.Add(this.label32);
            this.pnlE3.Controls.Add(this.textBox32);
            this.pnlE3.Controls.Add(this.label31);
            this.pnlE3.Controls.Add(this.button2);
            this.pnlE3.Controls.Add(this.button1);
            this.pnlE3.Controls.Add(this.pictureBox12);
            this.pnlE3.Controls.Add(this.label30);
            this.pnlE3.Controls.Add(this.pictureBox11);
            this.pnlE3.Controls.Add(this.label29);
            this.pnlE3.Controls.Add(this.comboBox2);
            this.pnlE3.Controls.Add(this.label28);
            this.pnlE3.Controls.Add(this.textBox31);
            this.pnlE3.Controls.Add(this.label27);
            this.pnlE3.Controls.Add(this.comboBox1);
            this.pnlE3.Controls.Add(this.label26);
            this.pnlE3.Controls.Add(this.label25);
            this.pnlE3.Controls.Add(this.textBox30);
            this.pnlE3.Controls.Add(this.label24);
            this.pnlE3.Controls.Add(this.label23);
            this.pnlE3.Controls.Add(this.textBox21);
            this.pnlE3.Controls.Add(this.textBox22);
            this.pnlE3.Controls.Add(this.textBox23);
            this.pnlE3.Controls.Add(this.textBox24);
            this.pnlE3.Controls.Add(this.textBox25);
            this.pnlE3.Controls.Add(this.textBox26);
            this.pnlE3.Controls.Add(this.textBox27);
            this.pnlE3.Controls.Add(this.textBox28);
            this.pnlE3.Controls.Add(this.textBox29);
            this.pnlE3.Controls.Add(this.textBox12);
            this.pnlE3.Controls.Add(this.textBox13);
            this.pnlE3.Controls.Add(this.textBox14);
            this.pnlE3.Controls.Add(this.textBox15);
            this.pnlE3.Controls.Add(this.textBox16);
            this.pnlE3.Controls.Add(this.textBox17);
            this.pnlE3.Controls.Add(this.textBox18);
            this.pnlE3.Controls.Add(this.textBox19);
            this.pnlE3.Controls.Add(this.textBox20);
            this.pnlE3.Controls.Add(this.textBox9);
            this.pnlE3.Controls.Add(this.textBox10);
            this.pnlE3.Controls.Add(this.textBox11);
            this.pnlE3.Controls.Add(this.textBox6);
            this.pnlE3.Controls.Add(this.textBox7);
            this.pnlE3.Controls.Add(this.textBox8);
            this.pnlE3.Controls.Add(this.label22);
            this.pnlE3.Controls.Add(this._3_7_4);
            this.pnlE3.Controls.Add(this.label21);
            this.pnlE3.Controls.Add(this._3_7_3);
            this.pnlE3.Controls.Add(this.label20);
            this.pnlE3.Controls.Add(this._3_7_2);
            this.pnlE3.Controls.Add(this.label19);
            this.pnlE3.Controls.Add(this._3_5);
            this.pnlE3.Controls.Add(this.label18);
            this.pnlE3.Controls.Add(this.label17);
            this.pnlE3.Controls.Add(this._3_4_5);
            this.pnlE3.Controls.Add(this.label16);
            this.pnlE3.Enabled = false;
            this.pnlE3.Location = new System.Drawing.Point(200, 504);
            this.pnlE3.Name = "pnlE3";
            this.pnlE3.Size = new System.Drawing.Size(1013, 192);
            this.pnlE3.TabIndex = 34;
            this.pnlE3.Visible = false;
            this.pnlE3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 1342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 1342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 56;
            this.button5.Text = "Submit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(40, 1249);
            this.textBox33.Multiline = true;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(927, 76);
            this.textBox33.TabIndex = 55;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(14, 1248);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 16);
            this.label32.TabIndex = 54;
            this.label32.Text = "7";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(40, 1151);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(927, 76);
            this.textBox32.TabIndex = 53;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(14, 1150);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 16);
            this.label31.TabIndex = 52;
            this.label31.Text = "6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 1112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Select image";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 939);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Select image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(42, 1009);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(320, 97);
            this.pictureBox12.TabIndex = 49;
            this.pictureBox12.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(14, 988);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(230, 16);
            this.label30.TabIndex = 48;
            this.label30.Text = "5     (Paste image of compuation here)";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(42, 647);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(430, 287);
            this.pictureBox11.TabIndex = 47;
            this.pictureBox11.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(14, 624);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(253, 16);
            this.label29.TabIndex = 46;
            this.label29.Text = "4     (Paste image of regulation curve here)";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(40, 591);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(58, 21);
            this.comboBox2.TabIndex = 45;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(14, 592);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 16);
            this.label28.TabIndex = 44;
            this.label28.Text = "3";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(40, 503);
            this.textBox31.Multiline = true;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(929, 76);
            this.textBox31.TabIndex = 43;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(14, 502);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(15, 16);
            this.label27.TabIndex = 42;
            this.label27.Text = "2";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(40, 472);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(14, 473);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 16);
            this.label26.TabIndex = 40;
            this.label26.Text = "1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(14, 448);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(139, 16);
            this.label25.TabIndex = 39;
            this.label25.Text = "REVIEW QUESTIONS";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(40, 359);
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(925, 76);
            this.textBox30.TabIndex = 38;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(13, 359);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 16);
            this.label24.TabIndex = 37;
            this.label24.Text = "8d";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(103, 133);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 16);
            this.label23.TabIndex = 36;
            this.label23.Text = "Table 3.1";
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox21.Location = new System.Drawing.Point(165, 322);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(55, 20);
            this.textBox21.TabIndex = 35;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(103, 322);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(56, 20);
            this.textBox22.TabIndex = 34;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(42, 322);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(56, 20);
            this.textBox23.TabIndex = 33;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox24.Location = new System.Drawing.Point(165, 303);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(55, 20);
            this.textBox24.TabIndex = 32;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(103, 303);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(56, 20);
            this.textBox25.TabIndex = 31;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(42, 303);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(56, 20);
            this.textBox26.TabIndex = 30;
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox27.Location = new System.Drawing.Point(165, 284);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(55, 20);
            this.textBox27.TabIndex = 29;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(103, 284);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(56, 20);
            this.textBox28.TabIndex = 28;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(42, 284);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(56, 20);
            this.textBox29.TabIndex = 27;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox12.Location = new System.Drawing.Point(165, 266);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(55, 20);
            this.textBox12.TabIndex = 26;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(103, 266);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(56, 20);
            this.textBox13.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(42, 266);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(56, 20);
            this.textBox14.TabIndex = 24;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox15.Location = new System.Drawing.Point(165, 247);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(55, 20);
            this.textBox15.TabIndex = 23;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(103, 247);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(56, 20);
            this.textBox16.TabIndex = 22;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(42, 247);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(56, 20);
            this.textBox17.TabIndex = 21;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox18.Location = new System.Drawing.Point(165, 228);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(55, 20);
            this.textBox18.TabIndex = 20;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(103, 228);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(56, 20);
            this.textBox19.TabIndex = 19;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(42, 228);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(56, 20);
            this.textBox20.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox9.Location = new System.Drawing.Point(165, 209);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(55, 20);
            this.textBox9.TabIndex = 17;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(103, 209);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(56, 20);
            this.textBox10.TabIndex = 16;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(42, 209);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(56, 20);
            this.textBox11.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox6.Location = new System.Drawing.Point(165, 190);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(103, 190);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(42, 190);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(56, 20);
            this.textBox8.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(165, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "PWR(W)";
            // 
            // _3_7_4
            // 
            this._3_7_4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._3_7_4.Location = new System.Drawing.Point(165, 171);
            this._3_7_4.Name = "_3_7_4";
            this._3_7_4.Size = new System.Drawing.Size(55, 20);
            this._3_7_4.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(103, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "E1(V)";
            // 
            // _3_7_3
            // 
            this._3_7_3.Location = new System.Drawing.Point(103, 171);
            this._3_7_3.Name = "_3_7_3";
            this._3_7_3.Size = new System.Drawing.Size(56, 20);
            this._3_7_3.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(40, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 16);
            this.label20.TabIndex = 7;
            this.label20.Text = "I1(A)";
            // 
            // _3_7_2
            // 
            this._3_7_2.Location = new System.Drawing.Point(42, 171);
            this._3_7_2.Name = "_3_7_2";
            this._3_7_2.Size = new System.Drawing.Size(56, 20);
            this._3_7_2.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "7b";
            // 
            // _3_5
            // 
            this._3_5.Location = new System.Drawing.Point(39, 50);
            this._3_5.Multiline = true;
            this._3_5.Name = "_3_5";
            this._3_5.Size = new System.Drawing.Size(928, 57);
            this._3_5.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "E1 =";
            // 
            // _3_4_5
            // 
            this._3_4_5.Location = new System.Drawing.Point(73, 11);
            this._3_4_5.Name = "_3_4_5";
            this._3_4_5.Size = new System.Drawing.Size(100, 20);
            this._3_4_5.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "4e";
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(1254, 180);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(75, 23);
            this.btnClearText.TabIndex = 35;
            this.btnClearText.Text = "Clear";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(53, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 366);
            this.panel3.TabIndex = 36;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(33, 480);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(114, 16);
            this.label33.TabIndex = 37;
            this.label33.Text = "Data and Results";
            // 
            // lblDateTimeShadow
            // 
            this.lblDateTimeShadow.AutoSize = true;
            this.lblDateTimeShadow.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTimeShadow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateTimeShadow.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeShadow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateTimeShadow.Location = new System.Drawing.Point(1076, 44);
            this.lblDateTimeShadow.Name = "lblDateTimeShadow";
            this.lblDateTimeShadow.Size = new System.Drawing.Size(25, 24);
            this.lblDateTimeShadow.TabIndex = 40;
            this.lblDateTimeShadow.Text = "A";
            // 
            // pnlE4
            // 
            this.pnlE4.AllowDrop = true;
            this.pnlE4.AutoScroll = true;
            this.pnlE4.BackColor = System.Drawing.Color.Silver;
            this.pnlE4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlE4.Controls.Add(this.button9);
            this.pnlE4.Controls.Add(this.button10);
            this.pnlE4.Controls.Add(this.label35);
            this.pnlE4.Controls.Add(this.button12);
            this.pnlE4.Controls.Add(this.comboBox4);
            this.pnlE4.Controls.Add(this.label40);
            this.pnlE4.Controls.Add(this.label41);
            this.pnlE4.Controls.Add(this.label42);
            this.pnlE4.Controls.Add(this.textBox38);
            this.pnlE4.Controls.Add(this.textBox39);
            this.pnlE4.Controls.Add(this.textBox40);
            this.pnlE4.Controls.Add(this.textBox41);
            this.pnlE4.Controls.Add(this.textBox42);
            this.pnlE4.Controls.Add(this.textBox43);
            this.pnlE4.Controls.Add(this.textBox44);
            this.pnlE4.Controls.Add(this.textBox45);
            this.pnlE4.Controls.Add(this.textBox46);
            this.pnlE4.Controls.Add(this.textBox47);
            this.pnlE4.Controls.Add(this.textBox48);
            this.pnlE4.Controls.Add(this.textBox49);
            this.pnlE4.Controls.Add(this.textBox50);
            this.pnlE4.Controls.Add(this.textBox51);
            this.pnlE4.Controls.Add(this.textBox52);
            this.pnlE4.Controls.Add(this.textBox53);
            this.pnlE4.Controls.Add(this.textBox54);
            this.pnlE4.Controls.Add(this.textBox55);
            this.pnlE4.Controls.Add(this.textBox56);
            this.pnlE4.Controls.Add(this.textBox57);
            this.pnlE4.Controls.Add(this.textBox58);
            this.pnlE4.Controls.Add(this.textBox59);
            this.pnlE4.Controls.Add(this.textBox60);
            this.pnlE4.Controls.Add(this.textBox61);
            this.pnlE4.Enabled = false;
            this.pnlE4.Location = new System.Drawing.Point(34, 504);
            this.pnlE4.Name = "pnlE4";
            this.pnlE4.Size = new System.Drawing.Size(1013, 192);
            this.pnlE4.TabIndex = 41;
            this.pnlE4.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(40, 1342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 57;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(132, 1342);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 56;
            this.button10.Text = "Submit";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(14, 1150);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(15, 16);
            this.label35.TabIndex = 52;
            this.label35.Text = "6";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(42, 939);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(78, 23);
            this.button12.TabIndex = 50;
            this.button12.Text = "Select image";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox4.Location = new System.Drawing.Point(40, 472);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(58, 21);
            this.comboBox4.TabIndex = 41;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(14, 473);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(15, 16);
            this.label40.TabIndex = 40;
            this.label40.Text = "1";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(14, 448);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(139, 16);
            this.label41.TabIndex = 39;
            this.label41.Text = "REVIEW QUESTIONS";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(13, 359);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(22, 16);
            this.label42.TabIndex = 37;
            this.label42.Text = "8d";
            // 
            // textBox38
            // 
            this.textBox38.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox38.Location = new System.Drawing.Point(165, 322);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(55, 20);
            this.textBox38.TabIndex = 35;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(103, 322);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(56, 20);
            this.textBox39.TabIndex = 34;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(42, 322);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(56, 20);
            this.textBox40.TabIndex = 33;
            // 
            // textBox41
            // 
            this.textBox41.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox41.Location = new System.Drawing.Point(165, 303);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(55, 20);
            this.textBox41.TabIndex = 32;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(103, 303);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(56, 20);
            this.textBox42.TabIndex = 31;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(42, 303);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(56, 20);
            this.textBox43.TabIndex = 30;
            // 
            // textBox44
            // 
            this.textBox44.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox44.Location = new System.Drawing.Point(165, 284);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(55, 20);
            this.textBox44.TabIndex = 29;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(103, 284);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(56, 20);
            this.textBox45.TabIndex = 28;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(42, 284);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(56, 20);
            this.textBox46.TabIndex = 27;
            // 
            // textBox47
            // 
            this.textBox47.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox47.Location = new System.Drawing.Point(165, 266);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(55, 20);
            this.textBox47.TabIndex = 26;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(103, 266);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(56, 20);
            this.textBox48.TabIndex = 25;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(42, 266);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(56, 20);
            this.textBox49.TabIndex = 24;
            // 
            // textBox50
            // 
            this.textBox50.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox50.Location = new System.Drawing.Point(165, 247);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(55, 20);
            this.textBox50.TabIndex = 23;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(103, 247);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(56, 20);
            this.textBox51.TabIndex = 22;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(42, 247);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(56, 20);
            this.textBox52.TabIndex = 21;
            // 
            // textBox53
            // 
            this.textBox53.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox53.Location = new System.Drawing.Point(165, 228);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(55, 20);
            this.textBox53.TabIndex = 20;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(103, 228);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(56, 20);
            this.textBox54.TabIndex = 19;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(42, 228);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(56, 20);
            this.textBox55.TabIndex = 18;
            // 
            // textBox56
            // 
            this.textBox56.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox56.Location = new System.Drawing.Point(165, 209);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(55, 20);
            this.textBox56.TabIndex = 17;
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(103, 209);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(56, 20);
            this.textBox57.TabIndex = 16;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(42, 209);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(56, 20);
            this.textBox58.TabIndex = 15;
            // 
            // textBox59
            // 
            this.textBox59.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox59.Location = new System.Drawing.Point(165, 190);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(55, 20);
            this.textBox59.TabIndex = 14;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(103, 190);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(56, 20);
            this.textBox60.TabIndex = 13;
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(42, 190);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(56, 20);
            this.textBox61.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 708);
            this.Controls.Add(this.pnlE4);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblDateTimeShadow);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.pnlE3);
            this.Controls.Add(this.grpPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPorts);
            this.Controls.Add(this.lblExpTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtfData);
            this.Controls.Add(this.IncomingText);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DC Machinery Laboratory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            this.grpPanel.ResumeLayout(false);
            this.grpPanel.PerformLayout();
            this.pnlE3.ResumeLayout(false);
            this.pnlE3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.pnlE4.ResumeLayout(false);
            this.pnlE4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer tmrDateTime;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.ComboBox comboBox2;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        //private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem selectExperimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLaboratoryManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem e1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem e2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem e3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem e4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ComboBox Command;
        private System.Windows.Forms.RichTextBox rtfData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnPorts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtE1Reading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtE2Reading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadI1C;
        private System.Windows.Forms.TextBox txtI1Reading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReadI2C;
        private System.Windows.Forms.TextBox txtI2Reading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReadN1C;
        private System.Windows.Forms.TextBox txtN1Reading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReadE1C;
        private System.Windows.Forms.Button btnReadE2C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkE1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkE2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkI1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkI2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chkN1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpPanel;
        private System.Windows.Forms.Panel pnlE3;
        private System.Windows.Forms.TextBox _3_5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox _3_4_5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox _3_7_4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox _3_7_3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox _3_7_2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblDateTimeShadow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem experiment1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experiment2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experiment3ToolStripMenuItem;
        public System.Windows.Forms.Timer TimerMain;
        public System.Windows.Forms.TextBox IncomingText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlE4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox61;
        //public MainForm mform = new MainForm();
    }
}

