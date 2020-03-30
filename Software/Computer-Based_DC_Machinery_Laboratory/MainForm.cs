using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Computer_Based_DC_Machinery_Laboratory
{
    public partial class MainForm : Form
    {
        int TimerCountdown;
        String SerialData;
        int E1Countdown;
        int E2Countdown;
        int I1Countdown;
        int I2Countdown;
        int N1Countdown;
        MyClass newMyClass = new MyClass();
       
        public MainForm()
        {
            InitializeComponent();
        }

        //System.Net.Sockets.TcpClient Client = new System.Net.Sockets.TcpClient();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Connect.Text = "Connect";
            Connect.Enabled = false;
            Send.Enabled = false;
            btnReadE1C.Enabled = false;
            btnReadE2C.Enabled = false;
            btnReadI1C.Enabled = false;
            btnReadI2C.Enabled = false;
            btnReadN1C.Enabled = false;
            trkSpeed.Enabled = false;
            chkE1.Enabled = false;
            chkE2.Enabled = false;
            chkI1.Enabled = false;
            chkI2.Enabled = false;
            chkN1.Enabled = false;
           // newMyClass.MyTimer.Interval = 3000;
           // Client.Rec
            
            //TimerMain.Enabled = true;
        }

        private void primeMoverAndTorqueMeasurementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word Document|*.docx|Word 97 - 2003 Document|*.doc" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    object readOnly = true;
                    object visible = true;
                    object save = false;
                    object fileName = ofd.FileName;
                    object missing = Type.Missing;
                    object newTemplate = false;
                    object docType = 0;
                    Microsoft.Office.Interop.Word._Document oDoc = null;
                    Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    oDoc = oWord.Documents.Open(
                            ref fileName, ref missing, ref readOnly, ref missing,
                            ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref visible,
                            ref missing, ref missing, ref missing, ref missing);
                    oDoc.ActiveWindow.Selection.WholeStory();
                    oDoc.ActiveWindow.Selection.Copy();
                    IDataObject data = Clipboard.GetDataObject();
                    rtfData.Rtf = data.GetData(DataFormats.Rtf).ToString();
                    oWord.Quit(ref missing, ref missing, ref missing);
                    lblExpTitle.Text = fileName.ToString();
                }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
                Connect.Text = "Connect";
                TimerMain.Enabled = false;
                Send.Enabled = false;
                btnReadE1C.Enabled = false;
                btnReadE2C.Enabled = false;
                btnReadI1C.Enabled = false;
                btnReadI2C.Enabled = false;
                btnReadN1C.Enabled = false;
                trkSpeed.Enabled = false;
                chkE1.Enabled = false;
                chkE2.Enabled = false;
                chkI1.Enabled = false;
                chkI2.Enabled = false;
                chkN1.Enabled = false;
                lblDateTime.Text = "";
                tmrDateTime.Enabled = false;
                //newMyClass.MyTimer.Enabled = false;
            }
            else
            {
                SerialPort.PortName = PortList.Text;
                SerialPort.Open();
                Connect.Text = "Disconnect";
                TimerMain.Enabled = true;
                Send.Enabled = true;
                btnReadE1C.Enabled = true;
                btnReadE2C.Enabled = true;
                btnReadI1C.Enabled = true;
                btnReadI2C.Enabled = true;
                btnReadN1C.Enabled = true;
                chkE1.Enabled = true;
                chkE2.Enabled = true;
                chkI1.Enabled = true;
                chkI2.Enabled = true;
                chkN1.Enabled = true;
                trkSpeed.Enabled = true;
                tmrDateTime.Enabled = true;
                //newMyClass.MyTimer.Enabled = true;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.RestoreDirectory = true;
            ofd.FileName = "*.rtf";
            ofd.DefaultExt = "rtf";
            ofd.Filter = "rtf files (*.rtf)|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream filestream = ofd.OpenFile();
                StreamWriter sw = new StreamWriter(filestream);
                sw.Write(rtfData.Rtf);
                sw.Close();
                filestream.Close();
            }
        }

        private void openLaboratoryManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word Document|*.docx|Word 97 - 2003 Document|*.doc" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    object readOnly = true;
                    object visible = true;
                    //object save = false;
                    object fileName = ofd.FileName;
                    MessageBox.Show(fileName.ToString());
                    object missing = Type.Missing;
                    //object newTemplate = false;
                    //object docType = 0;
                    Microsoft.Office.Interop.Word._Document oDoc = null;
                    Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    oDoc = oWord.Documents.Open(
                            ref fileName, ref missing, ref readOnly, ref missing,
                            ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref visible,
                            ref missing, ref missing, ref missing, ref missing);
                    oDoc.ActiveWindow.Selection.WholeStory();
                    oDoc.ActiveWindow.Selection.Copy();
                    IDataObject data = Clipboard.GetDataObject();
                    rtfData.Rtf = data.GetData(DataFormats.Rtf).ToString();
                    oWord.Quit(ref missing, ref missing, ref missing);
                    lblExpTitle.Text = fileName.ToString();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.RestoreDirectory = true;
            ofd.FileName = "*.rtf";
            ofd.DefaultExt = "rtf";
            ofd.Filter = "docx files (*.rtf)|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream filestream = ofd.OpenFile();
                StreamWriter sw = new StreamWriter(filestream);
                sw.Write(rtfData.Rtf);
                sw.Close();
                filestream.Close();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
        }


        private void TimerMain_Tick(object sender, EventArgs e)
        {
            TimerMain.Enabled = false;
            SerialData  = GetSerialData();

            if (SerialData.Length > 0)
            {
                String cf = ParseString(SerialData, 1);
                String df = ParseString(SerialData, 2);
                switch (cf)
                {
                    case "HB":
                        SerialPort.WriteLine("OK.");
                        break;
                    case "E1":
                        txtE1Reading.Text = df;
                        break;
                    case "E2":
                        txtE2Reading.Text = df;
                        break;
                    case "I1":
                        txtI1Reading.Text = df;
                        break;
                    case "I2":
                        txtI2Reading.Text = df;
                        break;
                    case "N1":
                        txtN1Reading.Text = df;
                        break;
                }
            }


            TimerMain.Enabled = true;
        }

        private void btnPorts_Click(object sender, EventArgs e)
        {
            string[] portListing = System.IO.Ports.SerialPort.GetPortNames();
            //MessageBox.Show(portListing.Length.ToString());
            if (portListing.Length > 0)
            {
                PortList.Items.Clear();
                foreach (string portName in portListing)
                {
                    PortList.Items.Add(portName);
                }
                PortList.SelectedIndex = 0;
                Connect.Enabled = true;
                Connect.ForeColor = Color.DarkGreen;
            }
        }

        private String GetSerialData()
        {
            try
            {
                SerialPort.ReadTimeout = 100;
                String sd = SerialPort.ReadLine();
                IncomingText.Text += sd;
                return sd;
            }
            catch
            {
                ;
            }
            return "";
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SerialPort.WriteLine(Command.Text);
        }

        public string ParseString(string rawString, int fieldNum)
        {
            int startParse;
            int delimeterCount;
            string extractString;

            char[] rawStringArray = rawString.ToArray();
            extractString = "";

            startParse = 0;
            delimeterCount = 1;
            for (int i = startParse; i < rawString.Length; i++)
            {
                if (rawStringArray[i] == '|')
                {
                    delimeterCount += 1;
                    startParse = i + 1;
                }
                if (delimeterCount == fieldNum)
                {
                    for (int j = startParse; j < rawString.Length; j++)
                    {
                        if (rawStringArray[j] == '|' || rawStringArray[j] == '\r' || rawStringArray[j] == '\n')
                        {
                            return extractString;
                        }
                        extractString += rawStringArray[j];
                    }
                    return extractString;
                }
            }
            return "";
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            if (--TimerCountdown < 1)
            {
                TimerCountdown = 10;
                lblDateTime.Text = DateTime.Now.ToString();
                lblDateTimeShadow.Text = lblDateTime.Text;
            }
            if(chkE1.Checked == true && E1Countdown -- < 1)
            {
                SerialPort.WriteLine("E1|");
                E1Countdown = 20;
            }
            if (chkE2.Checked == true && E2Countdown-- < 1)
            {
                SerialPort.WriteLine("E2|");
                E2Countdown = 20;
            }
            if (chkI1.Checked == true && I1Countdown-- < 1)
            {
                SerialPort.WriteLine("I1|");
                I1Countdown = 20;
            }
            if (chkI2.Checked == true && I2Countdown-- < 1)
            {
                SerialPort.WriteLine("I2|");
                I2Countdown = 20;
            }
            if (chkN1.Checked == true && N1Countdown-- < 1)
            {
                SerialPort.WriteLine("N1|");
                N1Countdown = 20;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnReadI1C_Click(object sender, EventArgs e)
        {
            if (chkI1.Checked == false) { SerialPort.WriteLine("I1|"); }
        }

        private void btnReadI2C_Click(object sender, EventArgs e)
        {
            if (chkI2.Checked == false) { SerialPort.WriteLine("I2|"); }
        }

        private void btnReadN1C_Click(object sender, EventArgs e)
        {
            if (chkN1.Checked == false) { SerialPort.WriteLine("N1|"); }

        }

        private void btnReadE1C_Click(object sender, EventArgs e)
        {
            if (chkE1.Checked == false) { SerialPort.WriteLine("E1|"); }
        }

        private void btnReadE2C_Click(object sender, EventArgs e)
        {
            if (chkE2.Checked == false) { SerialPort.WriteLine("E2|"); }
        }

        private void trkSpeed_Scroll(object sender, EventArgs e)
        {
            SerialPort.WriteLine("N1|" + trkSpeed.Value.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void e1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkE1.Checked == false && chkE2.Checked == false && chkI1.Checked  == false && chkI2.Checked  == false && chkN1.Checked == false)
            {
                frmCalibrate CalForm = new frmCalibrate();
                //CalForm.Show();
                CalForm.ShowDialog();
                CalForm.StartPosition = FormStartPosition.CenterScreen;
                CalForm.Text = "Calibrate - " + sender.ToString();
                CalForm.txtRaw1.Text = "1234";
                //if (TimerMain.Enabled == true) { TimerMain.Enabled = false; }
            }
            else
            {
                MessageBox.Show("Please disable instrument reading.");
            }

        }

        private void e2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalibrate CalForm = new frmCalibrate();

            CalForm.Show();
            CalForm.StartPosition = FormStartPosition.CenterScreen;
            CalForm.Text = "Calibrate - " + sender.ToString();
        }

        private void i1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalibrate CalForm = new frmCalibrate();

            CalForm.Show();
            CalForm.StartPosition = FormStartPosition.CenterScreen;
            CalForm.Text = "Calibrate - " + sender.ToString();
        }

        private void i2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalibrate CalForm = new frmCalibrate();

            CalForm.Show();
            CalForm.StartPosition = FormStartPosition.CenterScreen;
            CalForm.Text = "Calibrate - " + sender.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReadE1C_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReadE2C_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReadN1C_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReadI1C_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReadI2C_Click_1(object sender, EventArgs e)
        {

        }

        private void trkSpeed_Scroll_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            IncomingText.Text = "";
        }

        private void experiment1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object readOnly = true;
            object visible = true;
            object fileName = "C:" + (char)92 + "Latest Projects" + (char)92 + "Muniz-Marcaida" + (char)92 + "DC_Machine_Lab" + (char)92 + "Others" + (char)92 + sender + ".docx";
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word._Document oDoc = null;
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            oDoc = oWord.Documents.Open(
                    ref fileName, ref missing, ref readOnly, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref visible,
                    ref missing, ref missing, ref missing, ref missing);
            oDoc.ActiveWindow.Selection.WholeStory();
            oDoc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            rtfData.Rtf = data.GetData(DataFormats.Rtf).ToString();
            oWord.Quit(ref missing, ref missing, ref missing);
            
            lblExpTitle.Text = sender.ToString();
         }

        private void experiment2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object readOnly = true;
            object visible = true;
            object fileName = "C:" + (char)92 + "Latest Projects" + (char)92 + "Muniz-Marcaida" + (char)92 + "DC_Machine_Lab" + (char)92 + "Others" + (char)92 + sender + ".docx";
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word._Document oDoc = null;
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            oDoc = oWord.Documents.Open(
                    ref fileName, ref missing, ref readOnly, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref visible,
                    ref missing, ref missing, ref missing, ref missing);
            oDoc.ActiveWindow.Selection.WholeStory();
            oDoc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            rtfData.Rtf = data.GetData(DataFormats.Rtf).ToString();
            oWord.Quit(ref missing, ref missing, ref missing);

            lblExpTitle.Text = sender.ToString();
            pnlE4.Enabled = false;
            pnlE4.Visible = false;
            pnlE3.Enabled = true;
            pnlE3.Visible = true;
        }

        private void calibrateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void experiment3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object readOnly = true;
            object visible = true;
            object fileName = "C:" + (char)92 + "Latest Projects" + (char)92 + "Muniz-Marcaida" + (char)92 + "DC_Machine_Lab" + (char)92 + "Others" + (char)92 + sender + ".docx";
            object missing = Type.Missing;
            Microsoft.Office.Interop.Word._Document oDoc = null;
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            oDoc = oWord.Documents.Open(
                    ref fileName, ref missing, ref readOnly, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref visible,
                    ref missing, ref missing, ref missing, ref missing);
            oDoc.ActiveWindow.Selection.WholeStory();
            oDoc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            rtfData.Rtf = data.GetData(DataFormats.Rtf).ToString();
            oWord.Quit(ref missing, ref missing, ref missing);

            lblExpTitle.Text = sender.ToString();
            pnlE3.Enabled = false;
            pnlE3.Visible = false;
            pnlE4.Enabled = true;
            pnlE4.Visible = true;
        }
    }
    public class MyClass {
        public Timer MyTimer;
    }
}
