using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode;
using System.Diagnostics;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;


namespace ContactTracingApp.Dalangin
{
    public partial class Scanner_Form : Form
    {
        public Scanner_Form()
        {
            InitializeComponent();
        }

        public class QRCodeReadEventArgs
        {
            public string Data { get; set; }
        }

        FilterInfoCollection scanDataCollect;
        VideoCaptureDevice captureDevice;

        private void Scanner_Form_Load(object sender, EventArgs e)
        {
            scanDataCollect = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in scanDataCollect)
                cameradeviceComboBox.Items.Add(info.Name);
            cameradeviceComboBox.SelectedIndex = 0;
        }

        private void Scanner_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            afterScanning();
        }

        private void afterScanning()
        {
            if (captureDevice is not null)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                captureDevice = null;
            }
        }

        private void readQR()
        {
            if (captureDevice is null)
            {
                captureDevice = new VideoCaptureDevice(scanDataCollect[cameradeviceComboBox.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.PlayingFinished += errorInCamera;
                captureDevice.Start();
                scannerTimer.Start();
            }
        }

        private void errorInCamera (object sender, ReasonToFinishPlaying e)
        {
            Debug.WriteLine(e.ToString());

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Debug.WriteLine("Newframe");
            outputPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void scannerTimer_Tick(object sender, EventArgs e)
        {

            if (outputPictureBox.Image is not null)
            {

                Bitmap bmp = (Bitmap)outputPictureBox.Image;
                var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

                BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, bmp.PixelFormat);
                IntPtr ptr = bmpData.Scan0;

                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                bmp.UnlockBits(bmpData);
                var bitmapFormat = bmp.PixelFormat switch
                {
                    PixelFormat.Format24bppRgb => RGBLuminanceSource.BitmapFormat.RGB24,
                    PixelFormat.Format32bppRgb => RGBLuminanceSource.BitmapFormat.RGB32,
                    PixelFormat.Format32bppArgb => RGBLuminanceSource.BitmapFormat.ARGB32,
                    PixelFormat.Format16bppRgb565 => RGBLuminanceSource.BitmapFormat.RGB565,
                    PixelFormat.Format16bppGrayScale => RGBLuminanceSource.BitmapFormat.Gray16,
                    _ => RGBLuminanceSource.BitmapFormat.Unknown,
                };

                Result result = scanQRCode.Decode(rgbValues, bmp.Width, bmp.Height, bitmapFormat);

                if (result?.Text is not null)

                {
                    scannerTimer.Stop();
                    afterScanning();
                    QRCodeRead(this, new QRCodeReadEventArgs { Data = result.Text });
                    this.Close();
                }
            }
        }

        private void Scanner_Form_Shown(object sender, EventArgs e)
        {
            readQR();
        }

        private BarcodeReaderGeneric scanQRCode = new BarcodeReaderGeneric(new QRCodeReader(), null, null);

        public delegate void QRCodeReadEventHandler(object sender, QRCodeReadEventArgs eventArgs);
        public event QRCodeReadEventHandler QRCodeRead;

        private void outputPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void cameradeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            afterScanning();
            readQR();
        }
    }
}

