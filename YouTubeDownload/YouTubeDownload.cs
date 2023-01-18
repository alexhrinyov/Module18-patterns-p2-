using YouTubeDownload.Commands;

namespace YouTubeDownload
{
    public partial class YouTubeDownload : Form
    {
        public static List<string>? YouTubeList;
        Sender senderOne;
        Receiver receiver;
        IYouTubeCommand descriptionCommand;
        IYouTubeCommand downloadCommand;
        public YouTubeDownload()
        {
            InitializeComponent();
            senderOne = new Sender();
            receiver = new Receiver();
            descriptionCommand = new DescriptionCommand(receiver);

        }

        private void SetPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFolderDialog.ShowDialog();
            PathLabel.Text = openFolderDialog.SelectedPath;

        }

        private async void GetDescrButton_Click(object sender, EventArgs e)
        {
            try
            {
                VideoInfo video = new VideoInfo(VideoUrlBox.Text);
                senderOne.SetCommand(descriptionCommand);
                await descriptionCommand.Run(video, VideoUrlBox.Text);
                DescriptionLabel.Text = $"Title: {video.Title}, Author: {video.Author}, Duration: {video.Duration}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {

        }
    }
}