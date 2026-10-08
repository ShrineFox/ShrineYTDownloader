using Newtonsoft.Json;
using SevenZipExtractor;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp;
using YoutubeDLSharp.Metadata;
using YoutubeDLSharp.Options;
using static ShrineYTDownloader.ShrineYTDownloader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShrineYTDownloader
{
    public partial class ShrineYTDownloader : Form
    {
        public static List<YTVideo> videos;
        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();
        BindingSource bs_videos = new BindingSource();
        public static bool stopDownloads;

        public ShrineYTDownloader()
        {
            jsonPath = "./settings.json";
            InitializeComponent();
            LoadJson(jsonPath);

            //SaveJson(jsonPath);
            bs.DataSource = settings.Channels;
            bs2.DataSource = settings.Channels;
            bs_videos.DataSource = videos;

            comboBox_Channel.DataSource = bs;
            comboBox_ChannelDownload.DataSource = bs2;
            comboBox_Video.DataSource = bs_videos;
            comboBox_Channel.DisplayMember = "Name";
            comboBox_ChannelDownload.DisplayMember = "Name";
            comboBox_Video.DisplayMember = "Title";
            comboBox_Video.FormattingEnabled = true;
            comboBox_Video.Format += VideoComboBox_Format;

            txt_CmdArgs.Text = settings.CmdLineArgs;
            GetYTDLPVersion();
            if (settings.UpdateOnStartup)
                UpdateYTDLP();

            SetupTooltips();
        }

        private void SetupTooltips()
        {
            
            // Download by URL
            toolTip1.SetToolTip(groupBox_DownloadURL, "Manually specify URL for video or playlist to download.\r\n\r\n" +
                "Video URL example: https://www.youtube.com/watch?v=oeRD_fGFhdA\r\nPlaylist URL example: https://www.youtube.com/playlist?list=PLU6By7bu-RSs6FRsdyYotRzhFm2l7CEYv");
            toolTip1.SetToolTip(btn_DownloadURL, "Begin downloading the video or playlist specified in the URL textbox.\r\n\r\n" +
                "It should appear in the location specified in Settings > Output Directory.\r\nThe folder is created if it doesn't already exist.");
            toolTip1.SetToolTip(groupBox_CookiesTxt, "Path to cookies.txt.\r\nHover over \"Get Cookies\" button for more info.");

            // Download by Channel
            toolTip1.SetToolTip(groupBox_DownloadChannel, "Select the channel to download videos from.\r\nChannels are specified in settings.json.");
            toolTip1.SetToolTip(groupBox_Video, "Select the video to download from the selected channel.\r\nUse \"Updater\" Tab to fetch latest list of videos.");
            toolTip1.SetToolTip(groupBox_VideoSearch, "Enter part of a video title from selected channel here and press Enter to select the video in the list, if found.");
            toolTip1.SetToolTip(btn_DownloadAllVideos, "Begin downloading each video from the selected channel one by one, starting with the currently selected video.");
            toolTip1.SetToolTip(btn_DownloadSelectedVideo, "Begin downloading the currently selected video from the currently selected channel.");
            toolTip1.SetToolTip(btn_StopDownloads, "Quit batch downloading videos after the next download completes.");
            toolTip1.SetToolTip(groupBox_Range, "Specify \"start\" and \"end\" timestamps of downloaded videos.\r\nUse the hh:mm:ss format.");
            toolTip1.SetToolTip(chk_LaunchCmd, "Show the output of YT-DLP as a separate window, instead of in the built-in log textbox at the bottom of the \"Downloader\" tab.");

            // Updater
            toolTip1.SetToolTip(groupBox_Channel, "Channels to update video lists for. Lists appear in \"Downloader\" Tab.\r\nAdd channels in ./settings.json using a text editor.");
            toolTip1.SetToolTip(btn_UpdateVideoList, "Download an up-to-date list of videos for the selected channel.");
            toolTip1.SetToolTip(groupBox_ytdlpver, "Current version of YT-DLP being used by the downloader.");
            toolTip1.SetToolTip(btn_UpdateYTDLP, "Download very latest available YT-DLP version.\r\nUsed for downloading from YouTube.");
            toolTip1.SetToolTip(chk_UpdateOnStartup, "Automatically download latest YT-DLP when this program is opened.");
            toolTip1.SetToolTip(btn_InstallFFMPEG, "Install very latest FFMPEG to this program's folder.\r\nUsed for conversion and downloading in highest resolution.");
            toolTip1.SetToolTip(btn_InstallDeno, "Install very latest Deno to this program's folder.\r\nUsed for solving javascript verification challenges from YouTube.");
            
            // Settings
            toolTip1.SetToolTip(groupBox_OutputDir, "Path to the folder where videos will be downloaded to.");
            toolTip1.SetToolTip(groupBox_TitleFormat, "Format of the downloaded video filename (i.e. VideoTitle.mp4).");
            toolTip1.SetToolTip(groupBox_YTDLPPath, "Path to yt-dlp.exe. You probably don't need to change this,\r\nYT-DLP gets downloaded to the program's root folder by default.");
            toolTip1.SetToolTip(groupBox_FFMPEGPath, "Path to ffmpeg.exe. You probably don't need to change this,\r\nFFMPEG gets downloaded to the program's root folder by default.");
            toolTip1.SetToolTip(groupBox_Cookies, "Attempts to use YouTube logins from browser to improve reliability downloading videos.\r\n\r\nNote: Chromium-based browsers don't work at this time, use \"Cookies.txt\" instead.\r\nUsing a VPN can help avoid rate limits, IP bans etc.\r\nIt's recommended to login to a burner YouTube account instead of your main one.");
            toolTip1.SetToolTip(groupBox_CookiesTxt, "Path to cookies.txt.\r\nHover over \"Get Cookies\" button for more info.\r\n\r\nNote: Using a VPN can help avoid rate limits, IP bans etc.\r\nIt's recommended to login to a burner YouTube account instead of your main one.");
            toolTip1.SetToolTip(btn_GetCookies, "Install cookies extension for Chrome.\r\n\r\nClick the extension icon and choose \"Download All Cookies\"\r\nto get cookies.txt.");
            toolTip1.SetToolTip(chk_AddMetadata, "If enabled, metadata about the video (such as its url, upload date, and description) will be added to the video file.");
            toolTip1.SetToolTip(chk_WriteThumbnail, "If enabled, video thumbnails will be downloaded alongside the video.");
            toolTip1.SetToolTip(chk_WriteInfoJson, "If enabled, a .json that includes video metadata will be downloaded alongside the video.");
            toolTip1.SetToolTip(chk_WriteDescription, "If enabled, a .description file that includes the video description text will be downloaded alongside the video.");
            toolTip1.SetToolTip(chk_WriteComments, "If enabled, a file that includes the video's comments will be downloaded alongside the video.\r\n\r\nThis may take awhile if there are a lot of comments.");
            toolTip1.SetToolTip(chk_WriteSubs, "If enabled, manual subtitles will be downloaded along with the video.");
            toolTip1.SetToolTip(chk_WriteAutoSubs, "If enabled, automatic (YouTube-transcribed) subtitles will be downloaded along with the video.");
            toolTip1.SetToolTip(chk_EmbedSubs, "If enabled, subtitles will be embedded into the video format, if possible.");
            toolTip1.SetToolTip(chk_UseMp4Format, "If enabled, the video will attempt to be downloaded in (or converted to) .mp4 format, instead of whatever other format it downloads in by default (i.e. mkv)");
            toolTip1.SetToolTip(chk_ConvertToMp3, "If enabled, the video will be converted to .MP3 after being downloaded, in case you only want the audio.");
            toolTip1.SetToolTip(groupBox_RateLimit, "Use to prevent timeouts, rate limiting, IP bans etc from detected automated behavior.\r\n\r\nSleep Requests: Number of seconds to sleep between requests during data extraction (default: 3)\r\nSleep Interval: Number of seconds to sleep before each download.\r\n\tThis is the minimum time to sleep when used along with --max-sleep-interval.\r\nMax Sleep Interval: Maximum number of seconds to sleep. Can only e used along with --min-sleep-interval.");
            toolTip1.SetToolTip(chk_UseMp4Format, "If enabled, the video will attempt to be downloaded in (or converted to) .mp4 format, instead of whatever other format it downloads in by default (i.e. mkv)");
            toolTip1.SetToolTip(chk_ConvertToMp3, "If enabled, the video will be converted to .MP3 after being downloaded, in case you only want the audio.");
            toolTip1.SetToolTip(chk_RateLimit, "If enabled, rate limit prevention durations will be used when downloading.\r\nDisable to download faster, but at the risk of triggering rate limits or IP bans more easily.");
            toolTip1.SetToolTip(chk_SkipExistingDL, "If enabled, downloading will be skipped when a video in the Output folder exists with a matching title.");
            toolTip1.SetToolTip(groupBox_Cmd, "Enter any additional commandline options that you want to use here.\r\nEach option and value must be listed on a new line. Example:\r\n--verbose\r\n--convert-subs ass\r\n--sub-langs all");
        }

        private void VideoComboBox_Format(object? sender, ListControlConvertEventArgs e)
        {
            YTVideo vid = (YTVideo)e.ListItem;
            e.Value = $"{vid.Title} | views: {vid.ViewCount} | {vid.Date}";
        }

        private async void ProcessChannel(YTChannel channel)
        {
            txt_Log.Text = $"Processing channel \"{channel.Name}\", please wait...";
            btn_UpdateVideoList.Enabled = false;

            string tempPath = "./--print-to-file";

            // yt-dlp.exe --skip-download --ignore-errors --flat-playlist --print-to-file $"%(upload_date)s{SEP}%(webpage_url)s{SEP}%(title)s{SEP}" urls.txt https://www.youtube.com/channel/UCzORJV8l3FWY4cFO8ot-F2w/videos

            var ytdl = new YoutubeDL
            {
                YoutubeDLPath = settings.YTDlpExePath
            };

            var options = new OptionSet
            {
                SkipDownload = true,
                IgnoreErrors = true,
                FlatPlaylist = true,
                PlaylistReverse = true,
                PrintToFile = new MultiValue<string>($"%(webpage_url)s\t%(title)s\t"),
                Output = channel.Name + ".txt"
            };

            if (File.Exists(tempPath))
                File.Delete(tempPath);
            if (File.Exists("./--"))
                File.Delete("./--");

            var runResult = await ytdl.RunWithOptions($"https://www.youtube.com/channel/{channel.ID}/videos", options);

            if (runResult.ErrorOutput != null)
                foreach (string str in runResult.ErrorOutput)
                    txt_Log.Text += "\r\n" + str;

            ProcessOutputText(tempPath, "./" + channel.Name + ".tsv");

            txt_Log.Text += $"\r\n\r\nDone updating \"{Path.GetFullPath(channel.Name + ".tsv")}\".";
            SystemSounds.Exclamation.Play();

            btn_UpdateVideoList.Enabled = true;
        }

        private void ProcessOutputText(string txtPath, string outPath)
        {
            using (WaitForFile(txtPath)) { }
            ;
            if (!File.Exists(txtPath))
                txtPath = "./--";

            using (WaitForFile(txtPath)) { }
            ;
            if (!File.Exists(txtPath))
            {
                txt_Log.Text = "Could not find temp output file.";
                return;
            }

            File.Copy(txtPath, outPath, true);
            txt_Log.Text = $"Saved video list to: \"{Path.GetFullPath(outPath)}\"";
        }

        private void UpdateVideoList_Click(object sender, EventArgs e)
        {
            var channel = (YTChannel)comboBox_Channel.SelectedItem;

            ProcessChannel(channel);
        }

        public static FileStream WaitForFile(string fullPath,
            FileMode mode = FileMode.Open,
            FileAccess access = FileAccess.ReadWrite,
            FileShare share = FileShare.None)
        {
            for (int numTries = 0; numTries < 10; numTries++)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(fullPath, mode, access, share);
                    return fs;
                }
                catch (IOException)
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                    Thread.Sleep(400);
                }
            }
            return null;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            DownloadSelectedVideo();
        }

        private async void DownloadSelectedVideo()
        {
            var video = (YTVideo)comboBox_Video.SelectedItem;

            if (video == null) return;

            DownloadYTVideo(video.URL, video.Title);
            stopDownloads = false;
        }

        private void ChannelDownload_Changed(object sender, EventArgs e)
        {
            var channel = (YTChannel)comboBox_ChannelDownload.SelectedItem;

            UpdateVideoDownloadList(channel);
        }

        private void UpdateVideoDownloadList(YTChannel? channel)
        {
            if (!File.Exists(channel.Name + ".tsv"))
            {
                txt_DownloadLog.Text = $"Could not find \"{Path.GetFullPath(channel.Name + ".tsv")}\", " +
                    $"try downloading a video list for the channel first.";
                return;
            }

            UpdateVideoListDataSource(channel);
        }

        private void UpdateVideoListDataSource(YTChannel channel)
        {
            if (videos != null)
                videos.Clear();
            else
                videos = new List<YTVideo>();

            var tsvLines = File.ReadAllLines(channel.Name + ".tsv");
            foreach (var line in tsvLines)
            {
                var splitLines = line.Split('\t');
                string url = splitLines[0];
                string title = splitLines[1];
                string isDownloadedCheckmark = "";
                string viewCount = "";
                string uploadDate = "";

                if (splitLines.Length == 5)
                {
                    isDownloadedCheckmark = splitLines[2];
                    viewCount = splitLines[3];
                    uploadDate = splitLines[4];
                }

                videos.Add(new YTVideo()
                {
                    URL = url,
                    Title = title,
                    IsDownloaded = !string.IsNullOrEmpty(isDownloadedCheckmark),
                    ViewCount = viewCount,
                    Date = uploadDate
                });

            }
            bs_videos.DataSource = null;
            bs_videos.DataSource = videos;
        }



        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            string searchTxt = txt_VideoSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchTxt))
                return;
            if (e.KeyData == Keys.Enter)
            {
                // stop windows ding noise
                e.Handled = true;
                e.SuppressKeyPress = true;

                int i = comboBox_Video.SelectedIndex + 1;
                while (i < comboBox_Video.Items.Count)
                {
                    if (i == comboBox_Video.SelectedIndex)
                        return;

                    var vid = (YTVideo)comboBox_Video.Items[i];

                    if (vid.Title.ToLower().Contains(searchTxt.ToLower()) ||
                        vid.URL.ToLower().Contains(searchTxt.ToLower())
                        )
                    {
                        comboBox_Video.SelectedIndex = i;
                        return;
                    }

                    if (i == comboBox_Video.Items.Count - 1)
                        i = 0;
                    else
                        i++;
                }
            }
        }

        private void UseRange_CheckChanged(object sender, EventArgs e)
        {
            if (chk_UseTimeStampRange.Checked)
            {
                txt_to.Enabled = true;
                txt_from.Enabled = true;
            }
            else
            {
                txt_to.Enabled = false;
                txt_from.Enabled = false;
            }
        }

        private void DownloadAllVideos_Click(object sender, EventArgs e)
        {
            YTVideo selectedVideo = (YTVideo)comboBox_Video.SelectedItem;

            foreach (var vid in videos.SkipWhile(x => x != selectedVideo).Skip(1))
            {
                if (!vid.IsDownloaded)
                    DownloadYTVideo(vid.URL, vid.Title);
            }

            stopDownloads = false;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct STARTUPINFO
        {
            public Int32 cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public Int32 dwX;
            public Int32 dwY;
            public Int32 dwXSize;
            public Int32 dwYSize;
            public Int32 dwXCountChars;
            public Int32 dwYCountChars;
            public Int32 dwFillAttribute;
            public Int32 dwFlags;
            public Int16 wShowWindow;
            public Int16 cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(
            string lpApplicationName,
            string lpCommandLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            bool bInheritHandles,
            uint dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            [In] ref STARTUPINFO lpStartupInfo,
            out PROCESS_INFORMATION lpProcessInformation
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        const int STARTF_USESHOWWINDOW = 1;
        const int SW_SHOWNOACTIVATE = 4;
        const int SW_SHOWMINNOACTIVE = 7;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        const uint INFINITE = 0xFFFFFFFF;

        private static readonly System.Threading.SemaphoreSlim s_launchSemaphore = new System.Threading.SemaphoreSlim(1, 1);

        public static void LaunchYTDLPCmdSilently(string cmdLine)
        {
            // Fire-and-forget task that serializes process launches.
            // Each call will queue; only one process runs at a time.
            _ = Task.Run(() =>
            {
                // wait until previous process finished (or the slot is available)
                s_launchSemaphore.Wait();
                try
                {
                    STARTUPINFO si = new STARTUPINFO();
                    si.cb = Marshal.SizeOf(si);
                    si.dwFlags = STARTF_USESHOWWINDOW;
                    si.wShowWindow = SW_SHOWMINNOACTIVE;

                    PROCESS_INFORMATION pi = new PROCESS_INFORMATION();

                    bool started = CreateProcess(null, cmdLine, IntPtr.Zero, IntPtr.Zero, true,
                        0, IntPtr.Zero, null, ref si, out pi);

                    if (!started)
                        return;

                    WaitForSingleObject(pi.hProcess, INFINITE);

                    if (pi.hProcess != IntPtr.Zero)
                        CloseHandle(pi.hProcess);
                    if (pi.hThread != IntPtr.Zero)
                        CloseHandle(pi.hThread);
                }
                catch
                {
                    // intentionally swallow exceptions to keep the queue alive;
                    // consider logging if you want visibility into failures.
                }
                finally
                {
                    s_launchSemaphore.Release();
                }
            });
        }

        private void DownloadVideoURL_Click(object sender, EventArgs e)
        {
            DownloadYTVideo(txt_VideoURL.Text);
            stopDownloads = false;
        }

        private async void DownloadYTVideo(string url, string title = "")
        {
            if (stopDownloads)
                return;

            string args = GetYTDLPArgsFromSettings(url);

            if (chk_LaunchCmd.Checked)
            {
                if (chk_KeepCmdOpen.Checked)
                    KeepOpenCmd(args.Replace("\r", "").Replace("\n", " ") + $" {url}");
                LaunchYTDLPCmdSilently(args.Replace("\r", "").Replace("\n", " ") + $" {url}");
                txt_DownloadLog.Text += $"\r\nLaunching command prompt:\r\n{args}";
            }
            else
            {
                var ytdl = new YoutubeDL
                {
                    YoutubeDLPath = settings.YTDlpExePath
                };

                OptionSet options = OptionSet.FromString(args.Split('\n'));

                var runResult = await ytdl.RunWithOptions(url, options);

                if (runResult.ErrorOutput != null)
                    foreach (string str in runResult.ErrorOutput)
                        txt_DownloadLog.Text += "\r\n" + str;

                if (string.IsNullOrEmpty(title))
                    title = url;
                txt_DownloadLog.Text += $"\r\n\r\nDone downloading \"{title}\".";
                SystemSounds.Exclamation.Play();
            }
        }

        private void KeepOpenCmd(string args)
        {
            string exePath = Path.GetFullPath(settings.YTDlpExePath);

            // Escape quotes for cmd.exe
            string escapedArgs = args.Replace("\"", "\\\"");

            using (Process p = new Process())
            {
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = true;

                p.StartInfo.Arguments =
                    $"/k \"\"{Path.GetFullPath(exePath)}\" {escapedArgs}\"";

                p.Start();
                p.WaitForExit();
            }
        }

        private string GetYTDLPArgsFromSettings(string videoURL)
        {
            // Start by specifying path to YT-DLP.exe
            string args = $"\"{Path.GetFullPath(settings.YTDlpExePath)}\" ";

            // Specify output location and title formatting
            args += $"\r\n--output \"{Path.GetFullPath(settings.OutputDir)}\\{settings.TitleFormat}\"";

            // Get cookies from cookies.txt if specified, or browser if specified
            if (File.Exists(settings.CookiesTxtPath))
                args += $"\r\n--cookies {Path.GetFullPath(settings.CookiesTxtPath)}";
            else if (!string.IsNullOrEmpty(settings.CookiesFromBrowser.Replace("None", "")))
                args += $"\r\n--cookies-from-browser {settings.CookiesFromBrowser.ToLower()}";

            // Specify path to FFMPEG exe
            if (!string.IsNullOrEmpty(settings.FfmpegExePath))
                args += $"\r\n--ffmpeg-location \"{Path.GetFullPath(settings.FfmpegExePath)}\"";

            // Enable additional metadata downloads if selected in settings
            if (settings.AddMetadata)
                args += $"\r\n--add-metadata";
            if (settings.WriteThumbnail)
                args += $"\r\n--write-thumbnail";
            if (settings.WriteInfoJson)
                args += $"\r\n--write-info-json";
            if (settings.WriteDescription)
                args += $"\r\n--write-description";
            if (settings.WriteComments)
                args += $"\r\n--write-comments";
            if (settings.WriteSub)
                args += $"\r\n--write-sub";
            if (settings.WriteAutoSubs)
                args += $"\r\n--write-auto-sub";
            if (settings.EmbedSubs)
                args += $"\r\n--embed-subs";

            // Specify timestamp range of downloaded video(s)
            if (chk_UseTimeStampRange.Checked)
                args += $"\r\n--download-sections \"*{txt_from.Text}-{txt_to.Text}\"";

            // Specify output file format
            if (settings.DLMp4Format)
                args += $"\r\n-S vcodec:h264,res,acodec:m4a";
            if (settings.ConvertToMp3)
                args += $"\r\n-x --audio-format mp3";

            // Specify wait timers between downloads to prevent rate limiting
            if (settings.RateLimit)
            {
                args += $"\r\n--sleep-requests {settings.SleepRequests}" +
                    $"\r\n--sleep-interval {settings.SleepInterval}" +
                    $"\r\n--max-sleep-interval {settings.MaxSleepInterval}";
            }

            // Specify whether to download videos if a file with matching name exists at output dir
            if (settings.SkipExistingDL)
            {
                args += $"\r\n--no-overwrites" +
                    $"\r\n--no-post-overwrites";
            }

            // Add any additional user-specified commandline settings to end of query
            args += $"\r\n{settings.CmdLineArgs}";

            return args;
        }

        private string GetYTDLPVersion()
        {
            if (!File.Exists("./yt-dlp.exe"))
            {
                UpdateYTDLP();
                if (!File.Exists("./yt-dlp.exe"))
                {
                    MessageBox.Show($"YT-DLP is missing, downloading won't work until you place it at: \"{Path.GetFullPath(txt_YTDLPPath.Text)}\"");
                }
            }

            string output = "";
            if (File.Exists(settings.YTDlpExePath))
            {
                using (Process p = new Process())
                {
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(settings.YTDlpExePath));
                    p.StartInfo.FileName = Path.GetFullPath(settings.YTDlpExePath);
                    p.StartInfo.Arguments = "--version";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                }
                lbl_Version.Text = output + $"\r\nIs Deno installed: {File.Exists(Path.GetFullPath("%USERPROFILE%\\.deno\\bin\\deno.exe"))}";
            }
            return output;
        }

        private void UpdateYTDLP_Click(object sender, EventArgs e)
        {
            UpdateYTDLP();
        }

        private void UpdateYTDLP()
        {
            if (!File.Exists("./yt-dlp.exe"))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/yt-dlp/yt-dlp/releases/download/2026.07.04/yt-dlp.exe", "./yt-dlp.exe");
                }

                if (File.Exists("./yt-dlp.exe"))
                {
                    txt_YTDLPPath.Text = "./yt-dlp.exe";
                    txt_Log.Text += $"\r\nDownloaded yt-dlp.exe and updated YT-DLP path to newly downloaded one.";
                }
                else
                {
                    MessageBox.Show("Failed to download YT-DLP.");
                    return;
                }
            }

            txt_Log.Text += $"\r\nUpdating YT-DLP...";

            new Thread(() =>
            {
                using (Process p = new Process())
                {
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(settings.YTDlpExePath));

                    p.StartInfo.FileName = Path.GetFullPath(settings.YTDlpExePath);
                    p.StartInfo.Arguments = "-U";
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    p.WaitForExit();
                }
            }).Start();

            txt_Log.Text += $"\r\nYT-DLP is now up to date: {GetYTDLPVersion()}";
            SystemSounds.Exclamation.Play();
        }

        private void StopDownload_Click(object sender, EventArgs e)
        {
            stopDownloads = true;
        }

        private void CheckMissingVideos_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select folder containing downloaded videos";
            folderBrowser.UseDescriptionForTitle = true;

            var result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                CheckIfVideosDownloaded(folderBrowser.SelectedPath);
                var channel = (YTChannel)comboBox_ChannelDownload.SelectedItem;
                OutputTSVOfDownloadedVideos($"./{channel.Name}_DownloadedVideosList.tsv");
            }

            SystemSounds.Exclamation.Play();
        }

        private void OutputTSVOfDownloadedVideos(string outputPath)
        {
            string tsvText = "";
            int dlcount = 0;
            foreach (var video in videos)
            {
                tsvText += $"{video.URL}\t{video.Title}\t";
                if (video.IsDownloaded)
                {
                    tsvText += $"✔";
                    dlcount++;
                }
                tsvText += $"\t{video.ViewCount}\t{video.Date}\r\n";
            }
            txt_DownloadLog.Text = $"Saved currently downloaded video list to: {outputPath}";
            txt_DownloadLog.Text = $"Downloaded {dlcount} / {videos.Count} ({(dlcount / videos.Count) * 100}%)";
            SystemSounds.Exclamation.Play();

            File.WriteAllText(outputPath, tsvText);
        }

        private void CheckIfVideosDownloaded(string selectedPath)
        {
            string[] extensions = new string[] { ".mp4", ".mkv", ".webm" };
            foreach (var video in videos)
            {
                string normalizedTitle = video.Title.Replace("\"", "＂").Replace("?", "？").Replace(":", "：").Replace("/", "⧸").Replace("*", "＊");

                video.IsDownloaded = false;
                foreach (var ext in extensions)
                {
                    string fileName = Path.Combine(selectedPath, normalizedTitle + ext);
                    if (File.Exists(fileName))
                    {
                        video.IsDownloaded = true;
                        break;
                    }
                }
            }
        }

        private void LoadVideoDownloadTSV(string tsvPath)
        {
            if (!File.Exists(tsvPath))
            {
                txt_DownloadLog.Text = $"Could not find file: {tsvPath}";
                return;
            }

            foreach (var tsvLine in File.ReadAllLines(tsvPath).Where(x => x.Contains("✔")))
            {
                string url = tsvLine.Split('\t')[0];
                if (videos.Any(x => x.URL == url))
                    videos.First(x => x.URL == url).IsDownloaded = true;
            }
            txt_DownloadLog.Text = $"Updated the currently downloaded video list from: {tsvPath}";
            SystemSounds.Exclamation.Play();
        }

        private void LoadDownloadedVideoList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select downloaded videos TSV for currently selected channel";
            openFileDialog.Filter = "Tab Separated Value files (*.tsv)|*.tsv";

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                LoadVideoDownloadTSV(openFileDialog.FileName);
            }
        }

        private void SelectNextMissingVideo_Click(object sender, EventArgs e)
        {
            var currentSelectedVid = (YTVideo)comboBox_Video.SelectedItem;

            int i = comboBox_Video.SelectedIndex + 1;

            while (i < comboBox_Video.Items.Count)
            {
                if (i == comboBox_Video.SelectedIndex)
                    return;

                var vid = (YTVideo)comboBox_Video.Items[i];

                if (vid.IsDownloaded == false)
                {
                    comboBox_Video.SelectedItem = vid;
                    return;
                }

                if (i == comboBox_Video.Items.Count - 1)
                    i = 0;
                else
                    i++;
            }
        }

        private void GetViewCounts_Click(object sender, EventArgs e)
        {
            GetMetadata();
        }

        private async void GetMetadata()
        {
            txt_DownloadLog.Text = "Fetching video metadata, please wait. This can take some time...\r\n" +
            "If you see warnings below, the program is still working. Blame YouTube for how long this takes.\r\n";

            foreach (var video in videos)
            {
                // Skip fetching metadata if we already have it
                if (!string.IsNullOrEmpty(video.ViewCount) && !string.IsNullOrEmpty(video.Date))
                    continue;

                var ytdl = new YoutubeDL
                {
                    YoutubeDLPath = settings.YTDlpExePath
                };

                var runResult = await ytdl.RunVideoDataFetch(video.URL);
                VideoData vidMetadata = runResult.Data;

                if (runResult.Data == null)
                {
                    txt_DownloadLog.Text += $"\r\n\t[WARN] Failed to get metadata for: {video.Title}";
                    continue;
                }

                video.ViewCount = vidMetadata.ViewCount.ToString();
                video.Date = vidMetadata.UploadDate.ToString();
            }

            txt_DownloadLog.Text = $"Done fetching metadata.";
            OutputTSVOfDownloadedVideos("updatedMetadata.tsv");

            SystemSounds.Exclamation.Play();

        }

        private void InstallDeno_Click(object sender, EventArgs e)
        {
            InstallDeno();
        }

        private void InstallDeno()
        {
            txt_Log.Text += $"\r\nInstalling Deno...";
            string powershellCmd = "irm https://deno.land/install.ps1 | iex";
            txt_Log.Text += $"\r\nRunning powershell command: {powershellCmd}";

            new Thread(() =>
            {
                using (Process p = new Process())
                {
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(settings.YTDlpExePath));
                    p.StartInfo.FileName = "powershell.exe";
                    p.StartInfo.Arguments = powershellCmd;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    p.StartInfo.CreateNoWindow = false;
                    p.Start();
                    p.WaitForExit();
                }
            }).Start();

            txt_Log.Text += $"\r\nDeno should now be ready to use.";
            SystemSounds.Exclamation.Play();
        }

        private void AddMetadataFromTSV(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select TSV With Existing Metadata";
            openFileDialog.Filter = "Tab Separated Value files (*.tsv)|*.tsv";

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                foreach (var tsvLine in File.ReadAllLines(openFileDialog.FileName))
                {
                    var splitLines = tsvLine.Split('\t');

                    string url = tsvLine.Split('\t')[0];
                    string title = tsvLine.Split('\t')[1];
                    string isDownloadedCheckmark = "";
                    string viewCount = "";
                    string uploadDate = "";

                    if (splitLines.Length == 5)
                    {
                        isDownloadedCheckmark = tsvLine.Split('\t')[2];
                        viewCount = tsvLine.Split('\t')[3];
                        uploadDate = tsvLine.Split('\t')[4];

                        if (string.IsNullOrEmpty(viewCount) && string.IsNullOrEmpty(uploadDate))
                            continue;

                        if (videos.Any(x => x.Title == title))
                        {
                            var vid = videos.First(x => x.Title == title);
                            vid.ViewCount = viewCount;
                            vid.Date = uploadDate;
                        }
                    }
                }

                txt_DownloadLog.Text = $"Finished updating video list with metadata.";
                SystemSounds.Exclamation.Play();

                OutputTSVOfDownloadedVideos("updatedMetadata.tsv");
            }
        }

        private void InstallFFMPEG_Click(object sender, EventArgs e)
        {
            InstallFfmpeg();
        }

        private void InstallFfmpeg()
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.7z", "./ffmpeg.7z");
                    if (File.Exists("./ffmpeg.7z"))
                    {
                        using (ArchiveFile archiveFile = new ArchiveFile("./ffmpeg.7z"))
                        {
                            foreach (Entry entry in archiveFile.Entries.Where(x => x.FileName.EndsWith("ffmpeg.exe")))
                            {
                                using (MemoryStream memoryStream = new MemoryStream())
                                {
                                    entry.Extract(memoryStream);
                                    using (FileStream fs = new FileStream("./ffmpeg.exe", FileMode.Create, FileAccess.Write))
                                    {
                                        fs.Write(memoryStream.ToArray(), 0, memoryStream.ToArray().Length);
                                    }
                                    txt_Log.Text += $"\r\nDownloaded and extracted latest {entry.FileName}";
                                }
                            }
                        }
                        if (File.Exists("./ffmpeg.exe"))
                        {
                            txt_FFMPEGPath.Text = "./ffmpeg.exe";
                            txt_Log.Text += $"\r\nFFMPEG path is now set to newly downloaded exe.";
                        }
                        else
                        {
                            txt_Log.Text += $"\r\nFailed to extract ffmpeg.exe from downloaded archive.";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("\r\nFailed to download FFMPEG.");
                    return;
                }
            }
        }

        public static void OpenWebpage(string url)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + url);
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            OpenWebpage("http://www.shrinefox.com");
        }

        private void Readme_Click(object sender, EventArgs e)
        {
            OpenWebpage("https://github.com/ShrineFox/ShrineYTDownloader#readme");
        }

        private void Wiki_Click(object sender, EventArgs e)
        {
            OpenWebpage("https://github.com/ShrineFox/ShrineYTDownloader/wiki");
        }

        private void GetCookiesTxtBtn_Click(object sender, EventArgs e)
        {
            OpenWebpage("https://chromewebstore.google.com/detail/get-cookiestxt-locally/cclelndahbckbenkjhflpdbgdldlbecc?pli=1");
        }
    }

    public class YTChannel
    {
        public string Name { get; set; } = "";
        public string ID { get; set; } = "";
    }

    public class YTVideo
    {
        public string Title { get; set; } = "";
        public string URL { get; set; } = "";
        public bool IsDownloaded { get; set; } = false;
        public string ViewCount { get; set; } = "";
        public string Date { get; set; } = "";
    }

}
