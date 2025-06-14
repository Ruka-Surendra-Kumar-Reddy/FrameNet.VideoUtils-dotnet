# FrameNet.VideoUtils for .NET

![NuGet Version](https://img.shields.io/nuget/v/FrameNet.VideoUtils?style=flat-square) ![NuGet License](https://img.shields.io/nuget/l/FrameNet.VideoUtils?style=flat-square)

A simple .NET utility for getting video file details like duration, resolution, and frame rate. It works in any .NET Standard 2.0 compatible project.

This package provides a single, easy-to-use async function to quickly analyze local video files, a common task in video processing workflows. It requires `ffmpeg` to be installed and available in your system's PATH.

---

### About FrameNet.ai

This utility is proudly developed and maintained by the team at **[FrameNet.ai](https://www.framenet.ai)**. Our mission is to make video creation effortless through powerful, AI-driven tools.

While this package helps developers work with video programmatically, our platform offers a full suite of free tools for creators:

*   **[Free Online Video Editor](https://www.framenet.ai/tools/video-editor):** A powerful, browser-based editor to cut, merge, and enhance your videos.
*   **[Free Subtitle Generator](https://www.framenet.ai/tools/free-subtitle-generator):** Automatically generate subtitles for your videos with our AI, and export them for free.
*   **[Free SVG Icon Library](https://www.framenet.ai/icons):** Discover over 7,000 high-quality, royalty-free SVG icons perfect for all your video editing projects.

---

### Installation

Install the package directly from NuGet using the .NET CLI:

```bash
dotnet add package FrameNet.VideoUtils
```
Or via the NuGet Package Manager console:
```bash
Install-Package FrameNet.VideoUtils
```
## Usage
The library exports one primary async function, GetVideoDetailsAsync().
```bash
using FrameNet.VideoUtils;
using System;
using System.Threading.Tasks;

public class Example
{
    public static async Task Main()
    {
        var details = await VideoTasks.GetVideoDetailsAsync(@"C:\path\to\your\video.mp4");

        if (details != null)
        {
            Console.WriteLine($"Duration: {details.DurationSeconds}s");
            Console.WriteLine($"Resolution: {details.Dimensions.Width}x{details.Dimensions.Height}");
            Console.WriteLine($"Frame Rate: {details.Fps} fps");
        }
        else
        {
            Console.WriteLine("Could not process video.");
        }
    }
}
```
## About FrameNet.ai
FrameNet.ai is a comprehensive suite of AI tools designed to simplify and automate your video creation workflow, from text-to-video generation to automatic subtitling.

➡️ [Learn more about the FrameNet.ai platform](https://www.framenet.ai)