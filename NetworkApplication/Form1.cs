using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using NetworkC;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace NetworkApplication
{
    public partial class NetworkApp : Form
    {
        public NetworkApp()
        {
            InitializeComponent();
        }

        private CommonOpenFileDialog Dialog = new CommonOpenFileDialog();
        private Uri DownloadDirectory = new Uri(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads");

        private void NetworkApp_Load(object sender, EventArgs e)
        {
            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            Dialog.IsFolderPicker = true;
            lblDownloadDir.Text = Dialog.InitialDirectory;
        }

        private async void BtnCheck_Click(object sender, EventArgs e)
        {
            HttpClient Client = new HttpClient();
            string input = txtUrl.Text;
            if (Uri.IsWellFormedUriString(input, UriKind.Absolute))
            {
                Uri DownloadLink = new Uri(@input);

                Network.Download Download = new Network.Download
                {
                    url = DownloadLink.ToString(),
                    filename = Path.GetFileName(DownloadLink.LocalPath)
                };

                try
                {
                    var ok = await Network.GetFileSize(Download);

                    Download.size = long.Parse(ok);
                    lblHost.Text = DownloadLink.DnsSafeHost;
                    lblName.Text = Download.filename;
                    lblSize.Text = Network.BytesToFormat(Download.size, Network.ByteMeasurement.MB);
                    input = "";

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect URL format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnChooseDir_Click(object sender, EventArgs e)
        {
            if(Dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lblDownloadDir.Text = Dialog.FileName;
                DownloadDirectory = new Uri(Dialog.FileName);
            }
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            string input = txtUrl.Text;

            if(input == "")
            {
                MessageBox.Show("You Need to enter a URL", "URL Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    HttpClient Client = new HttpClient();
                    if (Uri.IsWellFormedUriString(input, UriKind.Absolute))
                    {
                        Uri download = new Uri(input);

                        if (File.Exists(DownloadDirectory.AbsolutePath + download.LocalPath))
                        {
                            DialogResult diag = MessageBox.Show("File: " + download.LocalPath + " Exists.\nAre you sure you want to replace this file?",
                                "Overwrite Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            using (Stream stream = File.Open(DownloadDirectory.AbsolutePath + download.LocalPath, FileMode.Create))
                            {

                                if (diag == DialogResult.Yes)
                                {
                                    BtnDownload.Enabled = false;
                                    HttpResponseMessage response = await Client.GetAsync(input, HttpCompletionOption.ResponseHeadersRead);
                                    await response.Content.CopyToAsync(stream);
                                    BtnDownload.Enabled = true;
                                }
                            }
                        }
                        else
                        {
                            using (Stream stream = File.Open(DownloadDirectory.AbsolutePath + download.LocalPath, FileMode.Create))
                            {
                                BtnDownload.Enabled = false;
                                HttpResponseMessage response = await Client.GetAsync(input, HttpCompletionOption.ResponseHeadersRead);
                                await response.Content.CopyToAsync(stream);
                                BtnDownload.Enabled = true;
                            }
                        }

                    }
                }

            }

        private void displayFormat_SelectedItemChanged(object sender, EventArgs e)
        {



        }
    }
    }

