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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner_Form));
            this.cameradevicesComboBox = new System.Windows.Forms.ComboBox();
            this.cameraLabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.scannerTimer = new System.Windows.Forms.Timer(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameradevicesComboBox
            // 
            this.cameradevicesComboBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cameradevicesComboBox.FormattingEnabled = true;
            this.cameradevicesComboBox.Location = new System.Drawing.Point(94, 55);
            this.cameradevicesComboBox.Name = "cameradevicesComboBox";
            this.cameradevicesComboBox.Size = new System.Drawing.Size(137, 23);
            this.cameradevicesComboBox.TabIndex = 0;
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cameraLabel.Location = new System.Drawing.Point(30, 57);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(58, 17);
            this.cameraLabel.TabIndex = 2;
            this.cameraLabel.Text = "Camera:";
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previewButton.Location = new System.Drawing.Point(244, 55);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(91, 23);
            this.previewButton.TabIndex = 3;
            this.previewButton.Text = "Scan";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputPictureBox.Location = new System.Drawing.Point(32, 84);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(303, 292);
            this.outputPictureBox.TabIndex = 5;
            this.outputPictureBox.TabStop = false;
            // 
            // scannerTimer
            // 
            this.scannerTimer.Interval = 1000;
            this.scannerTimer.Tick += new System.EventHandler(this.scannerTimer_Tick);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::ContactTracingApp.Dalangin.Properties.Resources.Cute_Cartoon_Game_Buttons__Game__Button__Cartoon_PNG_Transparent_Clipart_Image_and_PSD_File_for_Free;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(39, 39);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(327, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 39);
            this.exitButton.TabIndex = 7;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Scanner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(378, 388);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.outputPictureBox);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.cameraLabel);
            this.Controls.Add(this.cameradevicesComboBox);
            this.MaximumSize = new System.Drawing.Size(394, 427);
            this.MinimumSize = new System.Drawing.Size(394, 427);
            this.Name = "Scanner_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scanner_Form_FormClosing);
            this.Load += new System.EventHandler(this.Scanner_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cameradevicesComboBox;
        private Label cameraLabel;
        private Button previewButton;
        private PictureBox outputPictureBox;
        private System.Windows.Forms.Timer scannerTimer;
        private Button backButton;
        private Button exitButton;
    }
}