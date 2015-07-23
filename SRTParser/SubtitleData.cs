using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTParser
{
    public interface ISubtitleData
    {
        int Index { get; set; }
        TimeSpan StartTime { get; set; }
        TimeSpan EndTime { get; set; }
        string Text { get; set; }
    }

    public class SubtitleData : ISubtitleData
    {
        public SubtitleData(int index, TimeSpan startTime, TimeSpan endTime, string text)
        {
            Index = index;
            StartTime = startTime;
            EndTime = endTime;
            Text = text;
        }

        public int Index { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Text { get; set; }
    }
}
