namespace YTVideoListUpdater
{
    partial class YTVidListUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTVidListUpdater));
            tlp_ListUpdater = new TableLayoutPanel();
            btn_InstallFFMPEG = new Button();
            btn_InstallDeno = new Button();
            groupBox_ytdlpver = new GroupBox();
            lbl_Version = new Label();
            btn_UpdateYTDLP = new Button();
            groupBox_Channel = new GroupBox();
            comboBox_Channel = new ComboBox();
            btn_UpdateVideoList = new Button();
            txt_Log = new TextBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel_ChannelDownloader = new TableLayoutPanel();
            chk_LaunchCmd = new CheckBox();
            tabControl_DlType = new TabControl();
            tabPage4 = new TabPage();
            tableLayoutPanel_VideoDownloader = new TableLayoutPanel();
            btn_DownloadURL = new Button();
            groupBox_DownloadURL = new GroupBox();
            txt_VideoURL = new TextBox();
            tabPage5 = new TabPage();
            tlp_ChannelDl = new TableLayoutPanel();
            btn_StopDownloads = new Button();
            groupBox_VideoSearch = new GroupBox();
            txt_VideoSearch = new TextBox();
            btn_DownloadSelectedVideo = new Button();
            groupBox_Video = new GroupBox();
            comboBox_Video = new ComboBox();
            btn_DownloadAllVideos = new Button();
            groupBox_DownloadChannel = new GroupBox();
            comboBox_ChannelDownload = new ComboBox();
            txt_DownloadLog = new TextBox();
            groupBox_Range = new GroupBox();
            tlp_TimeRange = new TableLayoutPanel();
            chk_UseTimeStampRange = new CheckBox();
            txt_to = new TextBox();
            txt_from = new TextBox();
            lbl_from = new Label();
            lbl_to = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tlp_Settings = new TableLayoutPanel();
            chk_ConvertToMp3 = new CheckBox();
            chk_UseMp4Format = new CheckBox();
            groupBox_FFMPEGPath = new GroupBox();
            tlp_FFMPEGPath = new TableLayoutPanel();
            btn_FFMPEGPath = new Button();
            txt_FFMPEGPath = new TextBox();
            groupBox_YTDLPPath = new GroupBox();
            tlp_YTDLPPath = new TableLayoutPanel();
            btn_YTDLPPath = new Button();
            txt_YTDLPPath = new TextBox();
            groupBox_Cmd = new GroupBox();
            txt_CmdArgs = new TextBox();
            chk_WriteThumbnail = new CheckBox();
            groupBox_OutputDir = new GroupBox();
            tlp_OutputDir = new TableLayoutPanel();
            btn_OutputDir = new Button();
            txt_OutputDir = new TextBox();
            chk_WriteSubs = new CheckBox();
            chk_EmbedSubs = new CheckBox();
            chk_WriteAutoSubs = new CheckBox();
            chk_AddMetadata = new CheckBox();
            chk_WriteInfoJson = new CheckBox();
            chk_WriteComments = new CheckBox();
            chk_WriteDescription = new CheckBox();
            groupBox_TitleFormat = new GroupBox();
            txt_TitleFormat = new TextBox();
            groupBox_Cookies = new GroupBox();
            comboBox_Cookies = new ComboBox();
            menuStrip1 = new MenuStrip();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            checkMissingVideosToolStripMenuItem = new ToolStripMenuItem();
            loadDownloadedVideoListToolStripMenuItem = new ToolStripMenuItem();
            selectNextMissingVideoToolStripMenuItem = new ToolStripMenuItem();
            getViewCountOfVideoInListToolStripMenuItem = new ToolStripMenuItem();
            addMetadataFromTSVToolStripMenuItem = new ToolStripMenuItem();
            cmdOptionsToolStripMenuItem = new ToolStripMenuItem();
            chk_KeepCmdOpen = new ToolStripMenuItem();
            tlp_ListUpdater.SuspendLayout();
            groupBox_ytdlpver.SuspendLayout();
            groupBox_Channel.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel_ChannelDownloader.SuspendLayout();
            tabControl_DlType.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel_VideoDownloader.SuspendLayout();
            groupBox_DownloadURL.SuspendLayout();
            tabPage5.SuspendLayout();
            tlp_ChannelDl.SuspendLayout();
            groupBox_VideoSearch.SuspendLayout();
            groupBox_Video.SuspendLayout();
            groupBox_DownloadChannel.SuspendLayout();
            groupBox_Range.SuspendLayout();
            tlp_TimeRange.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tlp_Settings.SuspendLayout();
            groupBox_FFMPEGPath.SuspendLayout();
            tlp_FFMPEGPath.SuspendLayout();
            groupBox_YTDLPPath.SuspendLayout();
            tlp_YTDLPPath.SuspendLayout();
            groupBox_Cmd.SuspendLayout();
            groupBox_OutputDir.SuspendLayout();
            tlp_OutputDir.SuspendLayout();
            groupBox_TitleFormat.SuspendLayout();
            groupBox_Cookies.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_ListUpdater
            // 
            tlp_ListUpdater.ColumnCount = 3;
            tlp_ListUpdater.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlp_ListUpdater.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_ListUpdater.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_ListUpdater.Controls.Add(btn_InstallFFMPEG, 2, 2);
            tlp_ListUpdater.Controls.Add(btn_InstallDeno, 1, 2);
            tlp_ListUpdater.Controls.Add(groupBox_ytdlpver, 0, 1);
            tlp_ListUpdater.Controls.Add(btn_UpdateYTDLP, 1, 1);
            tlp_ListUpdater.Controls.Add(groupBox_Channel, 0, 0);
            tlp_ListUpdater.Controls.Add(btn_UpdateVideoList, 1, 0);
            tlp_ListUpdater.Controls.Add(txt_Log, 0, 3);
            tlp_ListUpdater.Dock = DockStyle.Fill;
            tlp_ListUpdater.Location = new Point(3, 3);
            tlp_ListUpdater.Name = "tlp_ListUpdater";
            tlp_ListUpdater.RowCount = 4;
            tlp_ListUpdater.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222233F));
            tlp_ListUpdater.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp_ListUpdater.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp_ListUpdater.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444466F));
            tlp_ListUpdater.Size = new Size(653, 424);
            tlp_ListUpdater.TabIndex = 0;
            // 
            // btn_InstallFFMPEG
            // 
            btn_InstallFFMPEG.Dock = DockStyle.Fill;
            btn_InstallFFMPEG.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_InstallFFMPEG.Location = new Point(524, 167);
            btn_InstallFFMPEG.Name = "btn_InstallFFMPEG";
            btn_InstallFFMPEG.Size = new Size(126, 64);
            btn_InstallFFMPEG.TabIndex = 6;
            btn_InstallFFMPEG.Text = "Install ffmpeg";
            btn_InstallFFMPEG.UseVisualStyleBackColor = true;
            btn_InstallFFMPEG.Click += InstallFFMPEG_Click;
            // 
            // btn_InstallDeno
            // 
            btn_InstallDeno.Dock = DockStyle.Fill;
            btn_InstallDeno.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_InstallDeno.Location = new Point(394, 167);
            btn_InstallDeno.Name = "btn_InstallDeno";
            btn_InstallDeno.Size = new Size(124, 64);
            btn_InstallDeno.TabIndex = 5;
            btn_InstallDeno.Text = "Install Deno";
            btn_InstallDeno.UseVisualStyleBackColor = true;
            btn_InstallDeno.Click += InstallDeno_Click;
            // 
            // groupBox_ytdlpver
            // 
            groupBox_ytdlpver.Controls.Add(lbl_Version);
            groupBox_ytdlpver.Dock = DockStyle.Fill;
            groupBox_ytdlpver.Location = new Point(3, 97);
            groupBox_ytdlpver.Name = "groupBox_ytdlpver";
            groupBox_ytdlpver.Size = new Size(385, 64);
            groupBox_ytdlpver.TabIndex = 4;
            groupBox_ytdlpver.TabStop = false;
            groupBox_ytdlpver.Text = "YT-DLP Version";
            // 
            // lbl_Version
            // 
            lbl_Version.AutoSize = true;
            lbl_Version.Dock = DockStyle.Right;
            lbl_Version.Location = new Point(382, 23);
            lbl_Version.Name = "lbl_Version";
            lbl_Version.Size = new Size(0, 20);
            lbl_Version.TabIndex = 1;
            lbl_Version.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_UpdateYTDLP
            // 
            btn_UpdateYTDLP.Dock = DockStyle.Fill;
            btn_UpdateYTDLP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_UpdateYTDLP.Location = new Point(394, 97);
            btn_UpdateYTDLP.Name = "btn_UpdateYTDLP";
            btn_UpdateYTDLP.Size = new Size(124, 64);
            btn_UpdateYTDLP.TabIndex = 3;
            btn_UpdateYTDLP.Text = "Download Latest YT-DLP";
            btn_UpdateYTDLP.UseVisualStyleBackColor = true;
            btn_UpdateYTDLP.Click += UpdateYTDLP_Click;
            // 
            // groupBox_Channel
            // 
            groupBox_Channel.Controls.Add(comboBox_Channel);
            groupBox_Channel.Dock = DockStyle.Fill;
            groupBox_Channel.Location = new Point(3, 3);
            groupBox_Channel.Name = "groupBox_Channel";
            groupBox_Channel.Size = new Size(385, 88);
            groupBox_Channel.TabIndex = 0;
            groupBox_Channel.TabStop = false;
            groupBox_Channel.Text = "Channel";
            // 
            // comboBox_Channel
            // 
            comboBox_Channel.Dock = DockStyle.Fill;
            comboBox_Channel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Channel.FormattingEnabled = true;
            comboBox_Channel.Location = new Point(3, 23);
            comboBox_Channel.Name = "comboBox_Channel";
            comboBox_Channel.Size = new Size(379, 28);
            comboBox_Channel.TabIndex = 0;
            // 
            // btn_UpdateVideoList
            // 
            tlp_ListUpdater.SetColumnSpan(btn_UpdateVideoList, 2);
            btn_UpdateVideoList.Dock = DockStyle.Fill;
            btn_UpdateVideoList.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_UpdateVideoList.Location = new Point(394, 3);
            btn_UpdateVideoList.Name = "btn_UpdateVideoList";
            btn_UpdateVideoList.Size = new Size(256, 88);
            btn_UpdateVideoList.TabIndex = 1;
            btn_UpdateVideoList.Text = "Update Video List";
            btn_UpdateVideoList.UseVisualStyleBackColor = true;
            btn_UpdateVideoList.Click += UpdateVideoList_Click;
            // 
            // txt_Log
            // 
            tlp_ListUpdater.SetColumnSpan(txt_Log, 3);
            txt_Log.Dock = DockStyle.Fill;
            txt_Log.Location = new Point(3, 237);
            txt_Log.Multiline = true;
            txt_Log.Name = "txt_Log";
            txt_Log.ReadOnly = true;
            txt_Log.ScrollBars = ScrollBars.Vertical;
            txt_Log.Size = new Size(647, 184);
            txt_Log.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 28);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(667, 463);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel_ChannelDownloader);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(659, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Downloader";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_ChannelDownloader
            // 
            tableLayoutPanel_ChannelDownloader.ColumnCount = 2;
            tableLayoutPanel_ChannelDownloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.70205F));
            tableLayoutPanel_ChannelDownloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.29795F));
            tableLayoutPanel_ChannelDownloader.Controls.Add(chk_LaunchCmd, 1, 2);
            tableLayoutPanel_ChannelDownloader.Controls.Add(tabControl_DlType, 0, 0);
            tableLayoutPanel_ChannelDownloader.Controls.Add(txt_DownloadLog, 0, 3);
            tableLayoutPanel_ChannelDownloader.Controls.Add(groupBox_Range, 0, 2);
            tableLayoutPanel_ChannelDownloader.Dock = DockStyle.Fill;
            tableLayoutPanel_ChannelDownloader.Location = new Point(3, 3);
            tableLayoutPanel_ChannelDownloader.Name = "tableLayoutPanel_ChannelDownloader";
            tableLayoutPanel_ChannelDownloader.RowCount = 4;
            tableLayoutPanel_ChannelDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel_ChannelDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_ChannelDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_ChannelDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_ChannelDownloader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_ChannelDownloader.Size = new Size(653, 424);
            tableLayoutPanel_ChannelDownloader.TabIndex = 1;
            // 
            // chk_LaunchCmd
            // 
            chk_LaunchCmd.AutoSize = true;
            chk_LaunchCmd.Checked = true;
            chk_LaunchCmd.CheckState = CheckState.Checked;
            chk_LaunchCmd.Dock = DockStyle.Fill;
            chk_LaunchCmd.Font = new Font("Segoe UI", 8F);
            chk_LaunchCmd.Location = new Point(523, 256);
            chk_LaunchCmd.Name = "chk_LaunchCmd";
            chk_LaunchCmd.Size = new Size(127, 78);
            chk_LaunchCmd.TabIndex = 16;
            chk_LaunchCmd.Text = "Launch Cmd";
            chk_LaunchCmd.UseVisualStyleBackColor = true;
            // 
            // tabControl_DlType
            // 
            tableLayoutPanel_ChannelDownloader.SetColumnSpan(tabControl_DlType, 2);
            tabControl_DlType.Controls.Add(tabPage4);
            tabControl_DlType.Controls.Add(tabPage5);
            tabControl_DlType.Dock = DockStyle.Fill;
            tabControl_DlType.Location = new Point(3, 3);
            tabControl_DlType.Name = "tabControl_DlType";
            tableLayoutPanel_ChannelDownloader.SetRowSpan(tabControl_DlType, 2);
            tabControl_DlType.SelectedIndex = 0;
            tabControl_DlType.Size = new Size(647, 247);
            tabControl_DlType.TabIndex = 12;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel_VideoDownloader);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(639, 214);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Video";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_VideoDownloader
            // 
            tableLayoutPanel_VideoDownloader.ColumnCount = 2;
            tableLayoutPanel_VideoDownloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel_VideoDownloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_VideoDownloader.Controls.Add(btn_DownloadURL, 1, 0);
            tableLayoutPanel_VideoDownloader.Controls.Add(groupBox_DownloadURL, 0, 0);
            tableLayoutPanel_VideoDownloader.Dock = DockStyle.Fill;
            tableLayoutPanel_VideoDownloader.Location = new Point(3, 3);
            tableLayoutPanel_VideoDownloader.Name = "tableLayoutPanel_VideoDownloader";
            tableLayoutPanel_VideoDownloader.RowCount = 1;
            tableLayoutPanel_VideoDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_VideoDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_VideoDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_VideoDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel_VideoDownloader.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel_VideoDownloader.Size = new Size(633, 208);
            tableLayoutPanel_VideoDownloader.TabIndex = 3;
            // 
            // btn_DownloadURL
            // 
            btn_DownloadURL.Dock = DockStyle.Fill;
            btn_DownloadURL.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_DownloadURL.Location = new Point(509, 3);
            btn_DownloadURL.Name = "btn_DownloadURL";
            btn_DownloadURL.Size = new Size(121, 202);
            btn_DownloadURL.TabIndex = 1;
            btn_DownloadURL.Text = "Download Video";
            btn_DownloadURL.UseVisualStyleBackColor = true;
            btn_DownloadURL.Click += DownloadVideoURL_Click;
            // 
            // groupBox_DownloadURL
            // 
            groupBox_DownloadURL.Controls.Add(txt_VideoURL);
            groupBox_DownloadURL.Dock = DockStyle.Fill;
            groupBox_DownloadURL.Location = new Point(3, 3);
            groupBox_DownloadURL.Name = "groupBox_DownloadURL";
            groupBox_DownloadURL.Size = new Size(500, 202);
            groupBox_DownloadURL.TabIndex = 6;
            groupBox_DownloadURL.TabStop = false;
            groupBox_DownloadURL.Text = "Video URL";
            // 
            // txt_VideoURL
            // 
            txt_VideoURL.Dock = DockStyle.Fill;
            txt_VideoURL.Location = new Point(3, 23);
            txt_VideoURL.Name = "txt_VideoURL";
            txt_VideoURL.ScrollBars = ScrollBars.Vertical;
            txt_VideoURL.Size = new Size(494, 27);
            txt_VideoURL.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(tlp_ChannelDl);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(639, 214);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Channel";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tlp_ChannelDl
            // 
            tlp_ChannelDl.ColumnCount = 2;
            tlp_ChannelDl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_ChannelDl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_ChannelDl.Controls.Add(btn_StopDownloads, 1, 2);
            tlp_ChannelDl.Controls.Add(groupBox_VideoSearch, 0, 2);
            tlp_ChannelDl.Controls.Add(btn_DownloadSelectedVideo, 1, 1);
            tlp_ChannelDl.Controls.Add(groupBox_Video, 0, 1);
            tlp_ChannelDl.Controls.Add(btn_DownloadAllVideos, 1, 0);
            tlp_ChannelDl.Controls.Add(groupBox_DownloadChannel, 0, 0);
            tlp_ChannelDl.Dock = DockStyle.Fill;
            tlp_ChannelDl.Location = new Point(3, 3);
            tlp_ChannelDl.Name = "tlp_ChannelDl";
            tlp_ChannelDl.RowCount = 3;
            tlp_ChannelDl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlp_ChannelDl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlp_ChannelDl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlp_ChannelDl.Size = new Size(633, 208);
            tlp_ChannelDl.TabIndex = 0;
            // 
            // btn_StopDownloads
            // 
            btn_StopDownloads.Dock = DockStyle.Fill;
            btn_StopDownloads.Font = new Font("Segoe UI", 7F);
            btn_StopDownloads.Location = new Point(509, 141);
            btn_StopDownloads.Name = "btn_StopDownloads";
            btn_StopDownloads.Size = new Size(121, 64);
            btn_StopDownloads.TabIndex = 15;
            btn_StopDownloads.Text = "Stop Downloads";
            btn_StopDownloads.UseVisualStyleBackColor = true;
            btn_StopDownloads.Visible = false;
            btn_StopDownloads.Click += StopDownload_Click;
            // 
            // groupBox_VideoSearch
            // 
            groupBox_VideoSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox_VideoSearch.Controls.Add(txt_VideoSearch);
            groupBox_VideoSearch.Location = new Point(3, 148);
            groupBox_VideoSearch.Name = "groupBox_VideoSearch";
            groupBox_VideoSearch.Size = new Size(500, 50);
            groupBox_VideoSearch.TabIndex = 14;
            groupBox_VideoSearch.TabStop = false;
            groupBox_VideoSearch.Text = "Video Search";
            // 
            // txt_VideoSearch
            // 
            txt_VideoSearch.Dock = DockStyle.Fill;
            txt_VideoSearch.Location = new Point(3, 23);
            txt_VideoSearch.Name = "txt_VideoSearch";
            txt_VideoSearch.ScrollBars = ScrollBars.Vertical;
            txt_VideoSearch.Size = new Size(494, 27);
            txt_VideoSearch.TabIndex = 1;
            txt_VideoSearch.KeyDown += Search_KeyDown;
            // 
            // btn_DownloadSelectedVideo
            // 
            btn_DownloadSelectedVideo.Dock = DockStyle.Fill;
            btn_DownloadSelectedVideo.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_DownloadSelectedVideo.Location = new Point(509, 72);
            btn_DownloadSelectedVideo.Name = "btn_DownloadSelectedVideo";
            btn_DownloadSelectedVideo.Size = new Size(121, 63);
            btn_DownloadSelectedVideo.TabIndex = 13;
            btn_DownloadSelectedVideo.Text = "Download Selected Video";
            btn_DownloadSelectedVideo.UseVisualStyleBackColor = true;
            btn_DownloadSelectedVideo.Click += Download_Click;
            // 
            // groupBox_Video
            // 
            groupBox_Video.Controls.Add(comboBox_Video);
            groupBox_Video.Dock = DockStyle.Fill;
            groupBox_Video.Location = new Point(3, 72);
            groupBox_Video.Name = "groupBox_Video";
            groupBox_Video.Size = new Size(500, 63);
            groupBox_Video.TabIndex = 12;
            groupBox_Video.TabStop = false;
            groupBox_Video.Text = "Selected Video";
            // 
            // comboBox_Video
            // 
            comboBox_Video.Dock = DockStyle.Fill;
            comboBox_Video.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Video.FormattingEnabled = true;
            comboBox_Video.Location = new Point(3, 23);
            comboBox_Video.Name = "comboBox_Video";
            comboBox_Video.Size = new Size(494, 28);
            comboBox_Video.TabIndex = 0;
            // 
            // btn_DownloadAllVideos
            // 
            btn_DownloadAllVideos.Dock = DockStyle.Fill;
            btn_DownloadAllVideos.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_DownloadAllVideos.Location = new Point(509, 3);
            btn_DownloadAllVideos.Name = "btn_DownloadAllVideos";
            btn_DownloadAllVideos.Size = new Size(121, 63);
            btn_DownloadAllVideos.TabIndex = 11;
            btn_DownloadAllVideos.Text = "Download All Videos";
            btn_DownloadAllVideos.UseVisualStyleBackColor = true;
            btn_DownloadAllVideos.Click += DownloadAllVideos_Click;
            // 
            // groupBox_DownloadChannel
            // 
            groupBox_DownloadChannel.Controls.Add(comboBox_ChannelDownload);
            groupBox_DownloadChannel.Dock = DockStyle.Fill;
            groupBox_DownloadChannel.Location = new Point(3, 3);
            groupBox_DownloadChannel.Name = "groupBox_DownloadChannel";
            groupBox_DownloadChannel.Size = new Size(500, 63);
            groupBox_DownloadChannel.TabIndex = 1;
            groupBox_DownloadChannel.TabStop = false;
            groupBox_DownloadChannel.Text = "Channel";
            // 
            // comboBox_ChannelDownload
            // 
            comboBox_ChannelDownload.Dock = DockStyle.Fill;
            comboBox_ChannelDownload.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ChannelDownload.FormattingEnabled = true;
            comboBox_ChannelDownload.Location = new Point(3, 23);
            comboBox_ChannelDownload.Name = "comboBox_ChannelDownload";
            comboBox_ChannelDownload.Size = new Size(494, 28);
            comboBox_ChannelDownload.TabIndex = 0;
            comboBox_ChannelDownload.SelectedIndexChanged += ChannelDownload_Changed;
            // 
            // txt_DownloadLog
            // 
            tableLayoutPanel_ChannelDownloader.SetColumnSpan(txt_DownloadLog, 2);
            txt_DownloadLog.Dock = DockStyle.Fill;
            txt_DownloadLog.Location = new Point(3, 340);
            txt_DownloadLog.Multiline = true;
            txt_DownloadLog.Name = "txt_DownloadLog";
            txt_DownloadLog.ReadOnly = true;
            txt_DownloadLog.ScrollBars = ScrollBars.Vertical;
            txt_DownloadLog.Size = new Size(647, 81);
            txt_DownloadLog.TabIndex = 3;
            // 
            // groupBox_Range
            // 
            groupBox_Range.Controls.Add(tlp_TimeRange);
            groupBox_Range.Dock = DockStyle.Fill;
            groupBox_Range.Location = new Point(3, 256);
            groupBox_Range.Name = "groupBox_Range";
            groupBox_Range.Size = new Size(514, 78);
            groupBox_Range.TabIndex = 7;
            groupBox_Range.TabStop = false;
            groupBox_Range.Text = "Timestamp Range";
            // 
            // tlp_TimeRange
            // 
            tlp_TimeRange.ColumnCount = 5;
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tlp_TimeRange.Controls.Add(chk_UseTimeStampRange, 4, 0);
            tlp_TimeRange.Controls.Add(txt_to, 3, 0);
            tlp_TimeRange.Controls.Add(txt_from, 1, 0);
            tlp_TimeRange.Controls.Add(lbl_from, 0, 0);
            tlp_TimeRange.Controls.Add(lbl_to, 2, 0);
            tlp_TimeRange.Dock = DockStyle.Fill;
            tlp_TimeRange.Location = new Point(3, 23);
            tlp_TimeRange.Name = "tlp_TimeRange";
            tlp_TimeRange.RowCount = 1;
            tlp_TimeRange.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_TimeRange.Size = new Size(508, 52);
            tlp_TimeRange.TabIndex = 0;
            // 
            // chk_UseTimeStampRange
            // 
            chk_UseTimeStampRange.AutoSize = true;
            chk_UseTimeStampRange.Dock = DockStyle.Fill;
            chk_UseTimeStampRange.Font = new Font("Segoe UI", 7F);
            chk_UseTimeStampRange.Location = new Point(395, 3);
            chk_UseTimeStampRange.Name = "chk_UseTimeStampRange";
            chk_UseTimeStampRange.Size = new Size(110, 46);
            chk_UseTimeStampRange.TabIndex = 9;
            chk_UseTimeStampRange.Text = "Use Range";
            chk_UseTimeStampRange.UseVisualStyleBackColor = true;
            chk_UseTimeStampRange.CheckedChanged += UseRange_CheckChanged;
            // 
            // txt_to
            // 
            txt_to.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_to.Enabled = false;
            txt_to.Location = new Point(283, 12);
            txt_to.Name = "txt_to";
            txt_to.ScrollBars = ScrollBars.Vertical;
            txt_to.Size = new Size(106, 27);
            txt_to.TabIndex = 3;
            txt_to.Text = "00:02:00";
            // 
            // txt_from
            // 
            txt_from.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_from.Enabled = false;
            txt_from.Location = new Point(87, 12);
            txt_from.Name = "txt_from";
            txt_from.ScrollBars = ScrollBars.Vertical;
            txt_from.Size = new Size(106, 27);
            txt_from.TabIndex = 2;
            txt_from.Text = "00:01:00";
            // 
            // lbl_from
            // 
            lbl_from.Anchor = AnchorStyles.Right;
            lbl_from.AutoSize = true;
            lbl_from.Location = new Point(37, 16);
            lbl_from.Name = "lbl_from";
            lbl_from.Size = new Size(44, 20);
            lbl_from.TabIndex = 0;
            lbl_from.Text = "from:";
            lbl_from.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_to
            // 
            lbl_to.Anchor = AnchorStyles.Right;
            lbl_to.AutoSize = true;
            lbl_to.Location = new Point(251, 16);
            lbl_to.Name = "lbl_to";
            lbl_to.Size = new Size(26, 20);
            lbl_to.TabIndex = 1;
            lbl_to.Text = "to:";
            lbl_to.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tlp_ListUpdater);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(659, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Updater";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tlp_Settings);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(659, 430);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tlp_Settings
            // 
            tlp_Settings.ColumnCount = 4;
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Settings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Settings.Controls.Add(chk_ConvertToMp3, 3, 4);
            tlp_Settings.Controls.Add(chk_UseMp4Format, 3, 3);
            tlp_Settings.Controls.Add(groupBox_FFMPEGPath, 2, 1);
            tlp_Settings.Controls.Add(groupBox_YTDLPPath, 0, 1);
            tlp_Settings.Controls.Add(groupBox_Cmd, 0, 5);
            tlp_Settings.Controls.Add(chk_WriteThumbnail, 1, 2);
            tlp_Settings.Controls.Add(groupBox_OutputDir, 0, 0);
            tlp_Settings.Controls.Add(chk_WriteSubs, 0, 4);
            tlp_Settings.Controls.Add(chk_EmbedSubs, 2, 4);
            tlp_Settings.Controls.Add(chk_WriteAutoSubs, 1, 4);
            tlp_Settings.Controls.Add(chk_AddMetadata, 0, 2);
            tlp_Settings.Controls.Add(chk_WriteInfoJson, 0, 3);
            tlp_Settings.Controls.Add(chk_WriteComments, 2, 3);
            tlp_Settings.Controls.Add(chk_WriteDescription, 1, 3);
            tlp_Settings.Controls.Add(groupBox_TitleFormat, 3, 0);
            tlp_Settings.Controls.Add(groupBox_Cookies, 2, 2);
            tlp_Settings.Dock = DockStyle.Fill;
            tlp_Settings.Location = new Point(0, 0);
            tlp_Settings.Name = "tlp_Settings";
            tlp_Settings.RowCount = 6;
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlp_Settings.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            tlp_Settings.Size = new Size(659, 430);
            tlp_Settings.TabIndex = 0;
            // 
            // chk_ConvertToMp3
            // 
            chk_ConvertToMp3.AutoSize = true;
            chk_ConvertToMp3.Checked = true;
            chk_ConvertToMp3.CheckState = CheckState.Checked;
            chk_ConvertToMp3.Dock = DockStyle.Fill;
            chk_ConvertToMp3.Location = new Point(495, 290);
            chk_ConvertToMp3.Name = "chk_ConvertToMp3";
            chk_ConvertToMp3.Size = new Size(161, 45);
            chk_ConvertToMp3.TabIndex = 29;
            chk_ConvertToMp3.Text = "Convert to MP3";
            chk_ConvertToMp3.UseVisualStyleBackColor = true;
            chk_ConvertToMp3.CheckedChanged += ConvertToMp3_CheckedChanged;
            // 
            // chk_UseMp4Format
            // 
            chk_UseMp4Format.AutoSize = true;
            chk_UseMp4Format.Checked = true;
            chk_UseMp4Format.CheckState = CheckState.Checked;
            chk_UseMp4Format.Dock = DockStyle.Fill;
            chk_UseMp4Format.Location = new Point(495, 239);
            chk_UseMp4Format.Name = "chk_UseMp4Format";
            chk_UseMp4Format.Size = new Size(161, 45);
            chk_UseMp4Format.TabIndex = 28;
            chk_UseMp4Format.Text = "Use MP4 Format";
            chk_UseMp4Format.UseVisualStyleBackColor = true;
            chk_UseMp4Format.CheckedChanged += UseMp4Format_CheckedChanged;
            // 
            // groupBox_FFMPEGPath
            // 
            tlp_Settings.SetColumnSpan(groupBox_FFMPEGPath, 2);
            groupBox_FFMPEGPath.Controls.Add(tlp_FFMPEGPath);
            groupBox_FFMPEGPath.Dock = DockStyle.Fill;
            groupBox_FFMPEGPath.Location = new Point(331, 89);
            groupBox_FFMPEGPath.Name = "groupBox_FFMPEGPath";
            groupBox_FFMPEGPath.Size = new Size(325, 80);
            groupBox_FFMPEGPath.TabIndex = 26;
            groupBox_FFMPEGPath.TabStop = false;
            groupBox_FFMPEGPath.Text = "ffmpeg Path";
            // 
            // tlp_FFMPEGPath
            // 
            tlp_FFMPEGPath.ColumnCount = 2;
            tlp_FFMPEGPath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_FFMPEGPath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_FFMPEGPath.Controls.Add(btn_FFMPEGPath, 1, 0);
            tlp_FFMPEGPath.Controls.Add(txt_FFMPEGPath, 0, 0);
            tlp_FFMPEGPath.Dock = DockStyle.Fill;
            tlp_FFMPEGPath.Location = new Point(3, 23);
            tlp_FFMPEGPath.Name = "tlp_FFMPEGPath";
            tlp_FFMPEGPath.RowCount = 1;
            tlp_FFMPEGPath.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_FFMPEGPath.Size = new Size(319, 54);
            tlp_FFMPEGPath.TabIndex = 0;
            // 
            // btn_FFMPEGPath
            // 
            btn_FFMPEGPath.Dock = DockStyle.Fill;
            btn_FFMPEGPath.Font = new Font("Segoe UI", 7F);
            btn_FFMPEGPath.Location = new Point(258, 3);
            btn_FFMPEGPath.Name = "btn_FFMPEGPath";
            btn_FFMPEGPath.Size = new Size(58, 48);
            btn_FFMPEGPath.TabIndex = 16;
            btn_FFMPEGPath.Text = ". . .";
            btn_FFMPEGPath.UseVisualStyleBackColor = true;
            btn_FFMPEGPath.Click += FFMPEGPath_Click;
            // 
            // txt_FFMPEGPath
            // 
            txt_FFMPEGPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_FFMPEGPath.Location = new Point(3, 13);
            txt_FFMPEGPath.Name = "txt_FFMPEGPath";
            txt_FFMPEGPath.ScrollBars = ScrollBars.Vertical;
            txt_FFMPEGPath.Size = new Size(249, 27);
            txt_FFMPEGPath.TabIndex = 2;
            txt_FFMPEGPath.TextChanged += FFMPEGPath_TextChanged;
            // 
            // groupBox_YTDLPPath
            // 
            tlp_Settings.SetColumnSpan(groupBox_YTDLPPath, 2);
            groupBox_YTDLPPath.Controls.Add(tlp_YTDLPPath);
            groupBox_YTDLPPath.Dock = DockStyle.Fill;
            groupBox_YTDLPPath.Location = new Point(3, 89);
            groupBox_YTDLPPath.Name = "groupBox_YTDLPPath";
            groupBox_YTDLPPath.Size = new Size(322, 80);
            groupBox_YTDLPPath.TabIndex = 25;
            groupBox_YTDLPPath.TabStop = false;
            groupBox_YTDLPPath.Text = "YT-DLP Path";
            // 
            // tlp_YTDLPPath
            // 
            tlp_YTDLPPath.ColumnCount = 2;
            tlp_YTDLPPath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_YTDLPPath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_YTDLPPath.Controls.Add(btn_YTDLPPath, 1, 0);
            tlp_YTDLPPath.Controls.Add(txt_YTDLPPath, 0, 0);
            tlp_YTDLPPath.Dock = DockStyle.Fill;
            tlp_YTDLPPath.Location = new Point(3, 23);
            tlp_YTDLPPath.Name = "tlp_YTDLPPath";
            tlp_YTDLPPath.RowCount = 1;
            tlp_YTDLPPath.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_YTDLPPath.Size = new Size(316, 54);
            tlp_YTDLPPath.TabIndex = 0;
            // 
            // btn_YTDLPPath
            // 
            btn_YTDLPPath.Dock = DockStyle.Fill;
            btn_YTDLPPath.Font = new Font("Segoe UI", 7F);
            btn_YTDLPPath.Location = new Point(255, 3);
            btn_YTDLPPath.Name = "btn_YTDLPPath";
            btn_YTDLPPath.Size = new Size(58, 48);
            btn_YTDLPPath.TabIndex = 16;
            btn_YTDLPPath.Text = ". . .";
            btn_YTDLPPath.UseVisualStyleBackColor = true;
            btn_YTDLPPath.Click += YTDLPPath_Click;
            // 
            // txt_YTDLPPath
            // 
            txt_YTDLPPath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_YTDLPPath.Location = new Point(3, 13);
            txt_YTDLPPath.Name = "txt_YTDLPPath";
            txt_YTDLPPath.ScrollBars = ScrollBars.Vertical;
            txt_YTDLPPath.Size = new Size(246, 27);
            txt_YTDLPPath.TabIndex = 2;
            txt_YTDLPPath.TextChanged += YTDLPPath_TextChanged;
            // 
            // groupBox_Cmd
            // 
            tlp_Settings.SetColumnSpan(groupBox_Cmd, 4);
            groupBox_Cmd.Controls.Add(txt_CmdArgs);
            groupBox_Cmd.Dock = DockStyle.Fill;
            groupBox_Cmd.Location = new Point(3, 341);
            groupBox_Cmd.Name = "groupBox_Cmd";
            groupBox_Cmd.Size = new Size(653, 86);
            groupBox_Cmd.TabIndex = 24;
            groupBox_Cmd.TabStop = false;
            groupBox_Cmd.Text = "Additional Commandline Arguments";
            // 
            // txt_CmdArgs
            // 
            txt_CmdArgs.Dock = DockStyle.Fill;
            txt_CmdArgs.Location = new Point(3, 23);
            txt_CmdArgs.Multiline = true;
            txt_CmdArgs.Name = "txt_CmdArgs";
            txt_CmdArgs.ScrollBars = ScrollBars.Vertical;
            txt_CmdArgs.Size = new Size(647, 60);
            txt_CmdArgs.TabIndex = 0;
            txt_CmdArgs.Text = "--verbose";
            txt_CmdArgs.TextChanged += AdditionalArgs_TextChanged;
            // 
            // chk_WriteThumbnail
            // 
            chk_WriteThumbnail.AutoSize = true;
            chk_WriteThumbnail.Dock = DockStyle.Fill;
            chk_WriteThumbnail.Location = new Point(167, 175);
            chk_WriteThumbnail.Name = "chk_WriteThumbnail";
            chk_WriteThumbnail.Size = new Size(158, 58);
            chk_WriteThumbnail.TabIndex = 18;
            chk_WriteThumbnail.Text = "Write Thumbnail";
            chk_WriteThumbnail.UseVisualStyleBackColor = true;
            chk_WriteThumbnail.CheckedChanged += WriteThumbnail_CheckedChanged;
            // 
            // groupBox_OutputDir
            // 
            tlp_Settings.SetColumnSpan(groupBox_OutputDir, 3);
            groupBox_OutputDir.Controls.Add(tlp_OutputDir);
            groupBox_OutputDir.Dock = DockStyle.Fill;
            groupBox_OutputDir.Location = new Point(3, 3);
            groupBox_OutputDir.Name = "groupBox_OutputDir";
            groupBox_OutputDir.Size = new Size(486, 80);
            groupBox_OutputDir.TabIndex = 15;
            groupBox_OutputDir.TabStop = false;
            groupBox_OutputDir.Text = "Output Directory";
            // 
            // tlp_OutputDir
            // 
            tlp_OutputDir.ColumnCount = 2;
            tlp_OutputDir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_OutputDir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_OutputDir.Controls.Add(btn_OutputDir, 1, 0);
            tlp_OutputDir.Controls.Add(txt_OutputDir, 0, 0);
            tlp_OutputDir.Dock = DockStyle.Fill;
            tlp_OutputDir.Location = new Point(3, 23);
            tlp_OutputDir.Name = "tlp_OutputDir";
            tlp_OutputDir.RowCount = 1;
            tlp_OutputDir.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_OutputDir.Size = new Size(480, 54);
            tlp_OutputDir.TabIndex = 0;
            // 
            // btn_OutputDir
            // 
            btn_OutputDir.Dock = DockStyle.Fill;
            btn_OutputDir.Font = new Font("Segoe UI", 7F);
            btn_OutputDir.Location = new Point(387, 3);
            btn_OutputDir.Name = "btn_OutputDir";
            btn_OutputDir.Size = new Size(90, 48);
            btn_OutputDir.TabIndex = 16;
            btn_OutputDir.Text = ". . .";
            btn_OutputDir.UseVisualStyleBackColor = true;
            btn_OutputDir.Click += OutputDir_Click;
            // 
            // txt_OutputDir
            // 
            txt_OutputDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_OutputDir.Location = new Point(3, 13);
            txt_OutputDir.Name = "txt_OutputDir";
            txt_OutputDir.ScrollBars = ScrollBars.Vertical;
            txt_OutputDir.Size = new Size(378, 27);
            txt_OutputDir.TabIndex = 2;
            txt_OutputDir.TextChanged += OutputDir_TextChanged;
            // 
            // chk_WriteSubs
            // 
            chk_WriteSubs.AutoSize = true;
            chk_WriteSubs.Dock = DockStyle.Fill;
            chk_WriteSubs.Location = new Point(3, 290);
            chk_WriteSubs.Name = "chk_WriteSubs";
            chk_WriteSubs.Size = new Size(158, 45);
            chk_WriteSubs.TabIndex = 21;
            chk_WriteSubs.Text = "Write Subtitles";
            chk_WriteSubs.UseVisualStyleBackColor = true;
            chk_WriteSubs.CheckedChanged += WriteSub_CheckedChanged;
            // 
            // chk_EmbedSubs
            // 
            chk_EmbedSubs.AutoSize = true;
            chk_EmbedSubs.Dock = DockStyle.Fill;
            chk_EmbedSubs.Location = new Point(331, 290);
            chk_EmbedSubs.Name = "chk_EmbedSubs";
            chk_EmbedSubs.Size = new Size(158, 45);
            chk_EmbedSubs.TabIndex = 22;
            chk_EmbedSubs.Text = "Embed Subtitles";
            chk_EmbedSubs.UseVisualStyleBackColor = true;
            chk_EmbedSubs.CheckedChanged += EmbedSubs_CheckedChanged;
            // 
            // chk_WriteAutoSubs
            // 
            chk_WriteAutoSubs.AutoSize = true;
            chk_WriteAutoSubs.Dock = DockStyle.Fill;
            chk_WriteAutoSubs.Location = new Point(167, 290);
            chk_WriteAutoSubs.Name = "chk_WriteAutoSubs";
            chk_WriteAutoSubs.Size = new Size(158, 45);
            chk_WriteAutoSubs.TabIndex = 23;
            chk_WriteAutoSubs.Text = "Write Auto-Subtitles";
            chk_WriteAutoSubs.UseVisualStyleBackColor = true;
            chk_WriteAutoSubs.CheckedChanged += WriteAutoSubs_CheckedChanged;
            // 
            // chk_AddMetadata
            // 
            chk_AddMetadata.AutoSize = true;
            chk_AddMetadata.Dock = DockStyle.Fill;
            chk_AddMetadata.Location = new Point(3, 175);
            chk_AddMetadata.Name = "chk_AddMetadata";
            chk_AddMetadata.Size = new Size(158, 58);
            chk_AddMetadata.TabIndex = 19;
            chk_AddMetadata.Text = "Add Metadata";
            chk_AddMetadata.UseVisualStyleBackColor = true;
            chk_AddMetadata.CheckedChanged += AddMetadata_CheckedChanged;
            // 
            // chk_WriteInfoJson
            // 
            chk_WriteInfoJson.AutoSize = true;
            chk_WriteInfoJson.Dock = DockStyle.Fill;
            chk_WriteInfoJson.Location = new Point(3, 239);
            chk_WriteInfoJson.Name = "chk_WriteInfoJson";
            chk_WriteInfoJson.Size = new Size(158, 45);
            chk_WriteInfoJson.TabIndex = 16;
            chk_WriteInfoJson.Text = "Write Info Json";
            chk_WriteInfoJson.UseVisualStyleBackColor = true;
            chk_WriteInfoJson.CheckedChanged += WriteInfoJson_CheckedChanged;
            // 
            // chk_WriteComments
            // 
            chk_WriteComments.AutoSize = true;
            chk_WriteComments.Dock = DockStyle.Fill;
            chk_WriteComments.Location = new Point(331, 239);
            chk_WriteComments.Name = "chk_WriteComments";
            chk_WriteComments.Size = new Size(158, 45);
            chk_WriteComments.TabIndex = 17;
            chk_WriteComments.Text = "Write Comments";
            chk_WriteComments.UseVisualStyleBackColor = true;
            chk_WriteComments.CheckedChanged += WriteComments_CheckedChanged;
            // 
            // chk_WriteDescription
            // 
            chk_WriteDescription.AutoSize = true;
            chk_WriteDescription.Dock = DockStyle.Fill;
            chk_WriteDescription.Font = new Font("Segoe UI", 8F);
            chk_WriteDescription.Location = new Point(167, 239);
            chk_WriteDescription.Name = "chk_WriteDescription";
            chk_WriteDescription.Size = new Size(158, 45);
            chk_WriteDescription.TabIndex = 20;
            chk_WriteDescription.Text = "Write Description";
            chk_WriteDescription.UseVisualStyleBackColor = true;
            chk_WriteDescription.CheckedChanged += WriteDescription_CheckedChanged;
            // 
            // groupBox_TitleFormat
            // 
            groupBox_TitleFormat.Controls.Add(txt_TitleFormat);
            groupBox_TitleFormat.Dock = DockStyle.Fill;
            groupBox_TitleFormat.Location = new Point(495, 3);
            groupBox_TitleFormat.Name = "groupBox_TitleFormat";
            groupBox_TitleFormat.Size = new Size(161, 80);
            groupBox_TitleFormat.TabIndex = 27;
            groupBox_TitleFormat.TabStop = false;
            groupBox_TitleFormat.Text = "Title Format";
            // 
            // txt_TitleFormat
            // 
            txt_TitleFormat.Dock = DockStyle.Fill;
            txt_TitleFormat.Location = new Point(3, 23);
            txt_TitleFormat.Name = "txt_TitleFormat";
            txt_TitleFormat.ScrollBars = ScrollBars.Vertical;
            txt_TitleFormat.Size = new Size(155, 27);
            txt_TitleFormat.TabIndex = 3;
            txt_TitleFormat.TextChanged += TitleFormat_TextChanged;
            // 
            // groupBox_Cookies
            // 
            tlp_Settings.SetColumnSpan(groupBox_Cookies, 2);
            groupBox_Cookies.Controls.Add(comboBox_Cookies);
            groupBox_Cookies.Dock = DockStyle.Fill;
            groupBox_Cookies.Location = new Point(331, 175);
            groupBox_Cookies.Name = "groupBox_Cookies";
            groupBox_Cookies.Size = new Size(325, 58);
            groupBox_Cookies.TabIndex = 0;
            groupBox_Cookies.TabStop = false;
            groupBox_Cookies.Text = "Cookies From Browser";
            // 
            // comboBox_Cookies
            // 
            comboBox_Cookies.Dock = DockStyle.Fill;
            comboBox_Cookies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Cookies.FormattingEnabled = true;
            comboBox_Cookies.Items.AddRange(new object[] { "None", "Firefox" });
            comboBox_Cookies.Location = new Point(3, 23);
            comboBox_Cookies.Name = "comboBox_Cookies";
            comboBox_Cookies.Size = new Size(319, 28);
            comboBox_Cookies.TabIndex = 1;
            comboBox_Cookies.SelectedIndexChanged += CookiesFromBrowser_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolsToolStripMenuItem, cmdOptionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(667, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkMissingVideosToolStripMenuItem, loadDownloadedVideoListToolStripMenuItem, selectNextMissingVideoToolStripMenuItem, getViewCountOfVideoInListToolStripMenuItem, addMetadataFromTSVToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // checkMissingVideosToolStripMenuItem
            // 
            checkMissingVideosToolStripMenuItem.Name = "checkMissingVideosToolStripMenuItem";
            checkMissingVideosToolStripMenuItem.Size = new Size(303, 26);
            checkMissingVideosToolStripMenuItem.Text = "Check Missing Videos";
            checkMissingVideosToolStripMenuItem.Click += CheckMissingVideos_Click;
            // 
            // loadDownloadedVideoListToolStripMenuItem
            // 
            loadDownloadedVideoListToolStripMenuItem.Name = "loadDownloadedVideoListToolStripMenuItem";
            loadDownloadedVideoListToolStripMenuItem.Size = new Size(303, 26);
            loadDownloadedVideoListToolStripMenuItem.Text = "Load Downloaded Video List";
            loadDownloadedVideoListToolStripMenuItem.Click += LoadDownloadedVideoList_Click;
            // 
            // selectNextMissingVideoToolStripMenuItem
            // 
            selectNextMissingVideoToolStripMenuItem.Name = "selectNextMissingVideoToolStripMenuItem";
            selectNextMissingVideoToolStripMenuItem.Size = new Size(303, 26);
            selectNextMissingVideoToolStripMenuItem.Text = "Select Next Missing Video";
            selectNextMissingVideoToolStripMenuItem.Click += SelectNextMissingVideo_Click;
            // 
            // getViewCountOfVideoInListToolStripMenuItem
            // 
            getViewCountOfVideoInListToolStripMenuItem.Name = "getViewCountOfVideoInListToolStripMenuItem";
            getViewCountOfVideoInListToolStripMenuItem.Size = new Size(303, 26);
            getViewCountOfVideoInListToolStripMenuItem.Text = "Get View Count of Videos in List";
            getViewCountOfVideoInListToolStripMenuItem.Click += GetViewCounts_Click;
            // 
            // addMetadataFromTSVToolStripMenuItem
            // 
            addMetadataFromTSVToolStripMenuItem.Name = "addMetadataFromTSVToolStripMenuItem";
            addMetadataFromTSVToolStripMenuItem.Size = new Size(303, 26);
            addMetadataFromTSVToolStripMenuItem.Text = "Add Metadata from TSV";
            addMetadataFromTSVToolStripMenuItem.Click += AddMetadataFromTSV;
            // 
            // cmdOptionsToolStripMenuItem
            // 
            cmdOptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chk_KeepCmdOpen });
            cmdOptionsToolStripMenuItem.Name = "cmdOptionsToolStripMenuItem";
            cmdOptionsToolStripMenuItem.Size = new Size(110, 24);
            cmdOptionsToolStripMenuItem.Text = "Cmd Options";
            // 
            // chk_KeepCmdOpen
            // 
            chk_KeepCmdOpen.CheckOnClick = true;
            chk_KeepCmdOpen.Name = "chk_KeepCmdOpen";
            chk_KeepCmdOpen.Size = new Size(201, 26);
            chk_KeepCmdOpen.Text = "Keep Cmd Open";
            // 
            // YTVidListUpdater
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 491);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(460, 400);
            Name = "YTVidListUpdater";
            Text = "YTVideoListUpdater v1.4.5";
            tlp_ListUpdater.ResumeLayout(false);
            tlp_ListUpdater.PerformLayout();
            groupBox_ytdlpver.ResumeLayout(false);
            groupBox_ytdlpver.PerformLayout();
            groupBox_Channel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel_ChannelDownloader.ResumeLayout(false);
            tableLayoutPanel_ChannelDownloader.PerformLayout();
            tabControl_DlType.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel_VideoDownloader.ResumeLayout(false);
            groupBox_DownloadURL.ResumeLayout(false);
            groupBox_DownloadURL.PerformLayout();
            tabPage5.ResumeLayout(false);
            tlp_ChannelDl.ResumeLayout(false);
            groupBox_VideoSearch.ResumeLayout(false);
            groupBox_VideoSearch.PerformLayout();
            groupBox_Video.ResumeLayout(false);
            groupBox_DownloadChannel.ResumeLayout(false);
            groupBox_Range.ResumeLayout(false);
            tlp_TimeRange.ResumeLayout(false);
            tlp_TimeRange.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tlp_Settings.ResumeLayout(false);
            tlp_Settings.PerformLayout();
            groupBox_FFMPEGPath.ResumeLayout(false);
            tlp_FFMPEGPath.ResumeLayout(false);
            tlp_FFMPEGPath.PerformLayout();
            groupBox_YTDLPPath.ResumeLayout(false);
            tlp_YTDLPPath.ResumeLayout(false);
            tlp_YTDLPPath.PerformLayout();
            groupBox_Cmd.ResumeLayout(false);
            groupBox_Cmd.PerformLayout();
            groupBox_OutputDir.ResumeLayout(false);
            tlp_OutputDir.ResumeLayout(false);
            tlp_OutputDir.PerformLayout();
            groupBox_TitleFormat.ResumeLayout(false);
            groupBox_TitleFormat.PerformLayout();
            groupBox_Cookies.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlp_ListUpdater;
        private GroupBox groupBox_Channel;
        private ComboBox comboBox_Channel;
        private Button btn_UpdateVideoList;
        private TextBox txt_Log;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel_ChannelDownloader;
        private TextBox txt_DownloadLog;
        private GroupBox groupBox_Range;
        private TableLayoutPanel tlp_TimeRange;
        private Label lbl_from;
        private Label lbl_to;
        private TextBox txt_to;
        private TextBox txt_from;
        private TabControl tabControl_DlType;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel_VideoDownloader;
        private Button btn_DownloadURL;
        private GroupBox groupBox_DownloadURL;
        private TextBox txt_VideoURL;
        private TabPage tabPage5;
        private TableLayoutPanel tlp_ChannelDl;
        private Button btn_DownloadSelectedVideo;
        private GroupBox groupBox_Video;
        private ComboBox comboBox_Video;
        private Button btn_DownloadAllVideos;
        private GroupBox groupBox_DownloadChannel;
        private ComboBox comboBox_ChannelDownload;
        private GroupBox groupBox_VideoSearch;
        private TextBox txt_VideoSearch;
        private CheckBox chk_UseTimeStampRange;
        private CheckBox chk_LaunchCmd;
        private Button btn_UpdateYTDLP;
        private GroupBox groupBox_ytdlpver;
        private Label lbl_Version;
        private Button btn_StopDownloads;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem checkMissingVideosToolStripMenuItem;
        private TabPage tabPage3;
        private TableLayoutPanel tlp_Settings;
        private GroupBox groupBox_Cookies;
        private ComboBox comboBox_Cookies;
        private GroupBox groupBox_OutputDir;
        private TableLayoutPanel tlp_OutputDir;
        private TextBox txt_OutputDir;
        private Button btn_OutputDir;
        private CheckBox chk_WriteInfoJson;
        private CheckBox chk_WriteComments;
        private CheckBox chk_WriteThumbnail;
        private CheckBox chk_AddMetadata;
        private CheckBox chk_WriteDescription;
        private CheckBox chk_WriteSubs;
        private CheckBox chk_EmbedSubs;
        private CheckBox chk_WriteAutoSubs;
        private GroupBox groupBox_Cmd;
        private TextBox txt_CmdArgs;
        private GroupBox groupBox_YTDLPPath;
        private TableLayoutPanel tlp_YTDLPPath;
        private Button btn_YTDLPPath;
        private TextBox txt_YTDLPPath;
        private GroupBox groupBox_FFMPEGPath;
        private TableLayoutPanel tlp_FFMPEGPath;
        private Button btn_FFMPEGPath;
        private TextBox txt_FFMPEGPath;
        private GroupBox groupBox_TitleFormat;
        private TextBox txt_TitleFormat;
        private ToolStripMenuItem loadDownloadedVideoListToolStripMenuItem;
        private ToolStripMenuItem cmdOptionsToolStripMenuItem;
        private ToolStripMenuItem chk_KeepCmdOpen;
        private ToolStripMenuItem selectNextMissingVideoToolStripMenuItem;
        private ToolStripMenuItem getViewCountOfVideoInListToolStripMenuItem;
        private Button btn_InstallDeno;
        private ToolStripMenuItem addMetadataFromTSVToolStripMenuItem;
        private Button btn_InstallFFMPEG;
        private CheckBox chk_UseMp4Format;
        private CheckBox chk_ConvertToMp3;
    }
}
