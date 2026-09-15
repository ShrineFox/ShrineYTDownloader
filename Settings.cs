using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace YTVideoListUpdater
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

        public string CmdLineArgs { get; set; } = "";
    }

    public partial class YTVidListUpdater : Form
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
                OutputDir = @"./",
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
                CmdLineArgs = "--verbose"
            };
        }

        public void LoadJson(string jsonPath)
        {
            if (!File.Exists(jsonPath))
            {
                SaveJson(jsonPath);
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
    }
}