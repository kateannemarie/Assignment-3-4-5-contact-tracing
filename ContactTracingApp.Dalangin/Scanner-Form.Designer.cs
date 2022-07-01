namespace ContactTracingApp.Dalangin
{
    partial class Scanner_Form
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
            this.cameraLabel = new System.Windows.Forms.Label();
            this.cameradeviceComboBox = new System.Windows.Forms.ComboBox();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Location = new System.Drawing.Point(32, 66);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(51, 15);
            this.cameraLabel.TabIndex = 0;
            this.cameraLabel.Text = "Camera:";
            // 
            // cameradeviceComboBox
            // 
            this.cameradeviceComboBox.FormattingEnabled = true;
            this.cameradeviceComboBox.Location = new System.Drawing.Point(89, 63);
            this.cameradeviceComboBox.Name = "cameradeviceComboBox";
            this.cameradeviceComboBox.Size = new System.Drawing.Size(220, 23);
            this.cameradeviceComboBox.TabIndex = 1;
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.Location = new System.Drawing.Point(32, 103);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(305, 269);
            this.outputPictureBox.TabIndex = 2;
            this.outputPictureBox.TabStop = false;
            // 
            // Scanner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 393);
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.cameradeviceComboBox);
            this.Controls.Add(this.cameraLabel);
            this.MaximumSize = new System.Drawing.Size(387, 432);
            this.MinimumSize = new System.Drawing.Size(387, 432);
            this.Name = "Scanner_Form";
            this.Text = "QR Code Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cameraLabel;
        private ComboBox cameradeviceComboBox;
        private PictureBox outputPictureBox;
    }
}