![](https://i.imgur.com/L2B0Oeo.png)  

# What is ShrineYTDownloader?
**Shrine YouTube Downloader** (formerly known as YTVideoListUpdater) is a multipurpose tool for downloading videos from YouTube.  
Essentially, it is yet another frontend for YT-DLP written in C# WinForms.

# Why Another YT-DLP Frontend?
I made this primarily for the Vinesauce editing team to simplify the process of setting up and troubleshooting YT-DLP.  
Since many team members have varying experience with YT-DLP, or may need specific ease-of-use features, this helps accommodate our specific needs.

# What special features does this have?
Unlike other YouTube downloaders, this tool is made specifically to track what videos are available on specific channels, and to track which ones you have already downloaded. You can also easily choose what additional data you want to download (descriptions, comments, views, thumbnails, subtitles etc) without the hassle of entering commands or navigating complicated menus.

# Download
Download the latest builds via the [Releases page](https://github.com/ShrineFox/ShrineYTDownloader/releases).  
⚠ **NOTE**: ⚠  
Antivirus may flag this program with the following detection. This is a **false positive**.  
![Commando.A!ML](https://i.imgur.com/PKaKja3.png)  
Use Windows Defender to whitelist and restore the program.  
If you're curious, this most likely happens due to the Deno installer running via powershell. This *does* run a remote script from the following URL, which *could* potentially become a vulnerability if you do not trust the site the Deno installer is from: ``https://deno.land/install.ps1``  
  
  However, Deno is the javascript challenge solver that makes downloading videos from YouTube using YT-DLP possible. Thus, this program tries to install it by default before you try to download any videos.

# More Information
Read the [Wiki](https://github.com/ShrineFox/ShrineYTDownloader/wiki) for a breakdown on how to use every single feature.

# Basic Usage
1. Start the program for the first time to download dependencies (``ffmpeg``, ``deno``, ``yt-dlp``)
2. In the ``Settings`` tab, choose an output folder for downloaded videos, and set your YT-DLP preferences.
3. Use the ``Downloader`` tab to download a video or playlist by URL, or download from a prespecified channel in bulk (see "Adding a Channel" below).
4. Use the ``Updater`` tab to update YT-DLP as needed, and update the list of videos available on each prespecified YouTube channel.

# Adding a Channel
- Edit ``settings.json``. Add your YouTube channel's name and Channel ID to the list.  

# Resuming Bulk Downloads of a YouTube Channel
1. On subsequent launches, in the ``Downloader`` tab's ``Download by Channel`` tab, select the channel you were downloading from previously.
2. Click on ``Tools > Check Missing Videos`` and choose the folder where you were outputting downloaded videos to.
3. A ``.tsv`` file will be generated with a list of all the videos already downloaded so far. You can load that list via ``Tools > Load Downloaded Video List`` to resume from where you left off last time you checked for missing videos.
4. Now when you choose "Download All Videos" from a channel, it will skip trying to download videos that were already downloaded, thus saving you time.

# Troubleshooting
Sometimes you may end up getting rate limited or blocked from downloading videos.  
- This happens if you download too many within a short period of time, and your activity gets flagged as automated behavior.  
  - One workaround is to log into your YouTube account on FireFox, and then in the ``Settings`` tab, choose ``FireFox`` as the browser to get cookies from.  
  - This will also help you download Age Restricted videos, which would otherwise be skipped by default.  
- Additionally, you should try using a VPN to avoid rate limiting and IP bans.
