namespace YouTubeDownload
{
    partial class YouTubeDownload
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
            this.SetPathButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.VideoUrlBox = new System.Windows.Forms.TextBox();
            this.GetDescrButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SetPathButton
            // 
            this.SetPathButton.Location = new System.Drawing.Point(24, 283);
            this.SetPathButton.Name = "SetPathButton";
            this.SetPathButton.Size = new System.Drawing.Size(132, 42);
            this.SetPathButton.TabIndex = 1;
            this.SetPathButton.Text = "Set Path";
            this.SetPathButton.UseVisualStyleBackColor = true;
            this.SetPathButton.Click += new System.EventHandler(this.SetPathButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(24, 346);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(132, 41);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Download Path";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(24, 223);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(86, 15);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "No Description";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(206, 310);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(50, 15);
            this.PathLabel.TabIndex = 6;
            this.PathLabel.Text = "No Path";
            // 
            // VideoUrlBox
            // 
            this.VideoUrlBox.Location = new System.Drawing.Point(24, 28);
            this.VideoUrlBox.Name = "VideoUrlBox";
            this.VideoUrlBox.Size = new System.Drawing.Size(739, 23);
            this.VideoUrlBox.TabIndex = 7;
            // 
            // GetDescrButton
            // 
            this.GetDescrButton.Location = new System.Drawing.Point(24, 79);
            this.GetDescrButton.Name = "GetDescrButton";
            this.GetDescrButton.Size = new System.Drawing.Size(146, 35);
            this.GetDescrButton.TabIndex = 8;
            this.GetDescrButton.Text = "Get Description";
            this.GetDescrButton.UseVisualStyleBackColor = true;
            this.GetDescrButton.Click += new System.EventHandler(this.GetDescrButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(178, 364);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // YouTubeDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GetDescrButton);
            this.Controls.Add(this.VideoUrlBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.SetPathButton);
            this.Name = "YouTubeDownload";
            this.Text = "YouTubeDownload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button SetPathButton;
        private Button DownloadButton;
        private Label label1;
        private Label label2;
        private Label DescriptionLabel;
        private Label PathLabel;
        private TextBox VideoUrlBox;
        private Button GetDescrButton;
        private ProgressBar progressBar1;
    }
}