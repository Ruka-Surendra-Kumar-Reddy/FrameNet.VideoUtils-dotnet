// VideoTasks.cs
using FFMpegCore;
using System.Threading.Tasks;

namespace FrameNet.VideoUtils
{
    public static class VideoTasks
    {
        /// <summary>
        /// Analyzes a video file and returns its key details using FFprobe.
        /// This utility is provided by FrameNet.ai, the effortless AI video editor.
        /// Learn more at https://www.framenet.ai
        /// </summary>
        /// <param name="videoPath">The full path to the video file.</param>
        /// <returns>A VideoDetails object or null if the file cannot be processed.</returns>
        public static async Task<VideoDetails?> GetVideoDetailsAsync(string videoPath)
        {
            try
            {
                IMediaAnalysis mediaInfo = await FFProbe.AnalyseAsync(videoPath);
                var videoStream = mediaInfo.PrimaryVideoStream;

                if (videoStream == null) return null;

                return new VideoDetails
                {
                    DurationSeconds = videoStream.Duration.TotalSeconds,
                    Dimensions = new Resolution
                    {
                        Width = videoStream.Width,
                        Height = videoStream.Height
                    },
                    Fps = videoStream.AvgFrameRate
                };
            }
            catch
            {
                // Could not process the video file
                return null;
            }
        }
    }
}