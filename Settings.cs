using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ShrineYTDownloader
{
    public class Settings
    {
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public List<YTChannel> Channels { get; set; } = new List<YTChannel>();

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string OutputDir { get; set; } = "./";

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string TitleFormat { get; set; } = "";

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string YTDlpExePath { get; set; } = "./yt-dlp.exe";

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string CookiesFromBrowser { get; set; } = "None";

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string FfmpegExePath { get; set; } = "";

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool AddMetadata { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool WriteThumbnail { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool WriteInfoJson { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool WriteDescription { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool WriteComments { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool WriteSub { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool WriteAutoSubs { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool EmbedSubs { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool DLMp4Format { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool ConvertToMp3 { get; set; } = false;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public int SleepRequests { get; set; } = 3;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public int SleepInterval { get; set; } = 60;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public int MaxSleepInterval { get; set; } = 120;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool RateLimit { get; set; } = true;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool UpdateOnStartup { get; set; } = true;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public bool SkipExistingDL { get; set; } = true;

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string CmdLineArgs { get; set; } = "";
    }

    public partial class ShrineYTDownloader : Form
    {
        public static string jsonPath;
        public static Settings settings;

        public void SaveJson(string jsonPath)
        {
            if (!File.Exists(jsonPath))
            {
                CreateNewSettings(jsonPath);
            }

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented));
        }

        private void CreateNewSettings(string jsonPath)
        {
            settings = new Settings()
            {
                Channels = new List<YTChannel>() {
                    new YTChannel() { ID = "UCzORJV8l3FWY4cFO8ot-F2w", Name = "vinesauce" },
                    new YTChannel() { ID = "UC2_IYqb1Tc_8Azh7rByedPA", Name = "FullSauce" },
                    new YTChannel() { ID = "UCo03CCLE1x34004iBmjcHnA", Name = "TwitchClipSauce" },
                    new YTChannel() { ID = "UCHEVjnU0KXhr-HDrlwoBm2g", Name = "ExtraSauce" },
                },
                OutputDir = @"./Output/",
                TitleFormat = "%(title)s.%(ext)s",
                YTDlpExePath = "./yt-dlp.exe",
                WriteInfoJson = false,
                WriteComments = false,
                WriteDescription = false,
                WriteThumbnail = false,
                AddMetadata = false,
                WriteSub = false,
                EmbedSubs = false,
                WriteAutoSubs = false,
                DLMp4Format = true,
                SleepRequests = 3,
                SleepInterval = 60,
                MaxSleepInterval = 120,
                RateLimit = true,
                UpdateOnStartup = true,
                SkipExistingDL = true,
                CmdLineArgs = "--verbose"
            };
        }

        public void LoadJson(string jsonPath)
        {
            if (!File.Exists(jsonPath))
            {
                // Create new configuraton JSON since one doesn't exist
                SaveJson(jsonPath);

                // Ensure Deno and Ffmpeg are installed if this is (likely)
                // the first time launching program
                MessageBox.Show("Since this is the first time starting up," +
                    "\r\nthe program will now automatically download required dependencies:" +
                    "\r\nyt-dlp, deno, and ffmpeg." +
                    "\r\n\r\nPlease be patient as this may take some time.", "ShrineYTDownloader (First-Time Startup)");

                InstallDeno();
                InstallFfmpeg();
            }

            string jsonText = File.ReadAllText(Path.GetFullPath(jsonPath));
            settings = JsonConvert.DeserializeObject<Settings>(jsonText);

            if (settings == null)
            {
                MessageBox.Show("Failed to load settings from JSON file.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_OutputDir.Text = settings.OutputDir;
            txt_TitleFormat.Text = settings.TitleFormat;
            txt_YTDLPPath.Text = settings.YTDlpExePath;
            txt_FFMPEGPath.Text = settings.FfmpegExePath;
            comboBox_Cookies.SelectedIndex = comboBox_Cookies.Items.IndexOf(settings.CookiesFromBrowser);
            chk_AddMetadata.Checked = settings.AddMetadata;
            chk_WriteThumbnail.Checked = settings.WriteThumbnail;
            chk_WriteInfoJson.Checked = settings.WriteInfoJson;
            chk_WriteDescription.Checked = settings.WriteDescription;
            chk_WriteComments.Checked = settings.WriteComments;
            chk_WriteSubs.Checked = settings.WriteSub;
            chk_WriteAutoSubs.Checked = settings.WriteAutoSubs;
            chk_EmbedSubs.Checked = settings.EmbedSubs;
            chk_UseMp4Format.Checked = settings.DLMp4Format;
            chk_ConvertToMp3.Checked = settings.ConvertToMp3;
            num_SleepRequests.Value = settings.SleepRequests;
            num_SleepInterval.Value = settings.SleepInterval;
            num_MaxSleepInterval.Value = settings.MaxSleepInterval;
            chk_RateLimit.Checked = settings.RateLimit;
            chk_UpdateOnStartup.Checked = settings.UpdateOnStartup;
            chk_SkipExistingDL.Checked = settings.SkipExistingDL;
            txt_CmdArgs.Text = settings.CmdLineArgs;
        }

        private void OutputDir_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            settings.OutputDir = txt.Text;
            SaveJson(jsonPath);
        }

        private void TitleFormat_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            settings.TitleFormat = txt.Text;
            SaveJson(jsonPath);
        }

        private void YTDLPPath_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            settings.YTDlpExePath = txt.Text;
            SaveJson(jsonPath);
        }

        private void FFMPEGPath_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            settings.FfmpegExePath = txt.Text;
            SaveJson(jsonPath);
        }

        private void OutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select folder to save downloaded videos to";
            folderBrowser.UseDescriptionForTitle = true;

            var rslt = folderBrowser.ShowDialog();
            if (rslt == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                txt_OutputDir.Text = folderBrowser.SelectedPath;
            }
        }

        private void YTDLPPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Select your YT-DLP.exe";
            fileDlg.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";

            var result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_YTDLPPath.Text = fileDlg.FileName;
            }
        }

        private void FFMPEGPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Select your ffmpeg.exe";
            fileDlg.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";

            var result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_FFMPEGPath.Text = fileDlg.FileName;
            }
        }

        private void CookiesFromBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            settings.CookiesFromBrowser = combo.SelectedItem.ToString();
            SaveJson(jsonPath);
        }

        private void AddMetadata_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.AddMetadata = chk.Checked;
            SaveJson(jsonPath);
        }

        private void WriteThumbnail_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.WriteThumbnail = chk.Checked;
            SaveJson(jsonPath);
        }

        private void WriteInfoJson_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.WriteInfoJson = chk.Checked;
            SaveJson(jsonPath);
        }

        private void WriteDescription_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.WriteDescription = chk.Checked;
            SaveJson(jsonPath);
        }

        private void WriteComments_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.WriteComments = chk.Checked;
            SaveJson(jsonPath);
        }

        private void WriteSub_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.WriteSub = chk.Checked;
            SaveJson(jsonPath);
        }

        private void WriteAutoSubs_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.WriteAutoSubs = chk.Checked;
            SaveJson(jsonPath);
        }

        private void EmbedSubs_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.EmbedSubs = chk.Checked;
            SaveJson(jsonPath);
        }

        private void UseMp4Format_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.DLMp4Format = chk.Checked;
            SaveJson(jsonPath);
        }

        private void ConvertToMp3_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.ConvertToMp3 = chk.Checked;
            SaveJson(jsonPath);
        }

        private void AdditionalArgs_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            settings.CmdLineArgs = txt.Text;
            SaveJson(jsonPath);
        }

        private void SleepRequests_ValueChanged(object sender, EventArgs e)
        {
            var num = (NumericUpDown)sender;
            settings.SleepRequests = Convert.ToInt32(num.Value);
            SaveJson(jsonPath);
        }

        private void SleepInterval_ValueChanged(object sender, EventArgs e)
        {
            var num = (NumericUpDown)sender;
            settings.SleepInterval = Convert.ToInt32(num.Value);
            SaveJson(jsonPath);
        }

        private void MaxSleepInterval_ValueChanged(object sender, EventArgs e)
        {
            var num = (NumericUpDown)sender;
            settings.MaxSleepInterval = Convert.ToInt32(num.Value);
            SaveJson(jsonPath);
        }

        private void RateLimit_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.RateLimit = chk.Checked;
            SaveJson(jsonPath);
        }

        private void UpdateOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.UpdateOnStartup = chk.Checked;
            SaveJson(jsonPath);
        }

        private void SkipExistngDL_CheckedChanged(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            settings.SkipExistingDL = chk.Checked;
            SaveJson(jsonPath);
        }
    }
}