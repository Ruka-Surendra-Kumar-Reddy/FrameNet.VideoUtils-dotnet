// VideoDetails.cs
namespace FrameNet.VideoUtils
{
    public class VideoDetails
    {
        public double DurationSeconds { get; set; }
        public Resolution Dimensions { get; set; }
        public double Fps { get; set; }
    }

    public class Resolution
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}