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
        public Scanner_Form()
        {
            InitializeComponent();
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
                    scannedqrTextBox.Text = result.ToString();
                    scannerTimer.Stop();

                }
            }

        }

        private void Scanner_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Information.txt", scannedqrTextBox.Text);
            saveButton.Enabled = false;
            Application.Exit();
        }
    }
}
