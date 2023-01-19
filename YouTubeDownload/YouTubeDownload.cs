using YouTubeDownload.Commands;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Videos;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeDownload
{
    public partial class YouTubeDownload : Form
    {
        
        Sender CommadSender;
        Receiver receiver;
        IYouTubeCommand descriptionCommand;
        IYouTubeCommand downloadCommand;
        public YouTubeDownload()
        {
            InitializeComponent();
            CommadSender = new Sender();
            receiver = new Receiver();
            descriptionCommand = new DescriptionCommand(receiver);
            downloadCommand = new DownloadCommand(receiver);


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
                CommadSender.SetCommand(descriptionCommand);
                await CommadSender.RunDescription(video, VideoUrlBox.Text);
                DescriptionLabel.Text = $"Title: {video.Title}\nAuthor: {video.Author}\nDuration: {video.Duration}";

                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                VideoInfo video = new VideoInfo(VideoUrlBox.Text);
                CommadSender.SetCommand(downloadCommand);
                await CommadSender.RunDownload(video, PathLabel.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}