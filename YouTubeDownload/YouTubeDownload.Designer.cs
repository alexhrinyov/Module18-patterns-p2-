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
            this.VideoGrid = new System.Windows.Forms.DataGridView();
            this.Links = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetPathButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoGrid
            // 
            this.VideoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Links});
            this.VideoGrid.Location = new System.Drawing.Point(24, 28);
            this.VideoGrid.Name = "VideoGrid";
            this.VideoGrid.RowTemplate.Height = 25;
            this.VideoGrid.Size = new System.Drawing.Size(752, 150);
            this.VideoGrid.TabIndex = 0;
            this.VideoGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.VideoGrid_RowsAdded);
            // 
            // Links
            // 
            this.Links.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Links.HeaderText = "Links";
            this.Links.Name = "Links";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Download Path";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(24, 235);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(86, 15);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "No Description";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(189, 297);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(50, 15);
            this.PathLabel.TabIndex = 6;
            this.PathLabel.Text = "No Path";
            // 
            // YouTubeDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.SetPathButton);
            this.Controls.Add(this.VideoGrid);
            this.Name = "YouTubeDownload";
            this.Text = "YouTubeDownload";
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView VideoGrid;
        private DataGridViewTextBoxColumn Links;
        private Button SetPathButton;
        private Button DownloadButton;
        private Label label1;
        private Label label2;
        private Label DescriptionLabel;
        private Label PathLabel;
    }
}