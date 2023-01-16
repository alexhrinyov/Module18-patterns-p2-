namespace YouTubeDownload
{
    public partial class YouTubeDownload : Form
    {
        public static List<string> YouTubeList;
        public YouTubeDownload()
        {
            InitializeComponent();
            
        }

        private void SetPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFolderDialog.ShowDialog();
            PathLabel.Text = openFolderDialog.SelectedPath;

        }

        private void VideoGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < VideoGrid.RowCount; i++)
            {
                YouTubeList.Add(VideoGrid.Rows[i].ToString());
            }
            
        }
    }
}