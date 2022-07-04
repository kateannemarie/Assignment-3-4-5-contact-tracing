using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode;

namespace ContactTracingApp.Dalangin
{
    public partial class Scanner_Form : Form
    {
        public static Scanner_Form instance;

        public Scanner_Form()
        {
            InitializeComponent();
            instance = this;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void previewButton_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cameradevicesComboBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            scannerTimer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            outputPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Scanner_Form_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cameradevicesComboBox.Items.Add(filterInfo.Name);
            cameradevicesComboBox.SelectedIndex = 0;
        }

        private void scannerTimer_Tick(object sender, EventArgs e)
        {
            if (outputPictureBox.Image != null)
            {
                ZXing.Windows.Compatibility.BarcodeReader barcodeReader = new ZXing.Windows.Compatibility.BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)outputPictureBox.Image);
                if (result != null)
                {
                    Health_Declaration_Form hdf = new Health_Declaration_Form();
                    hdf.Show();

                    result.ToString();
                    string[] index = result.ToString().Split(new char[] { '\n' });

                    if (index[1].Trim().ToLower().Equals("female"))
                        Health_Declaration_Form.instance.radiobuttonF.Checked = true;
                    if (index[1].Trim().ToLower().Equals("male"))
                        Health_Declaration_Form.instance.radiobuttonM.Checked = true;

                    if (index.Length > 0)
                    {
                        Health_Declaration_Form.instance.nameTxtBx.Text = index[0];
                        Health_Declaration_Form.instance.ageTxtBx.Text = index[2];
                        Health_Declaration_Form.instance.contactaddTxtBx.Text = index[3];
                        Health_Declaration_Form.instance.contactnumTxtBx.Text = index[4];
                        Health_Declaration_Form.instance.contactemTxtBx.Text = index[5];
                    }
                    scannerTimer.Stop();

                    this.Close();

                }
            }

        }

        private void Scanner_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Health_Declaration_Form hdf = new Health_Declaration_Form();
            hdf.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
