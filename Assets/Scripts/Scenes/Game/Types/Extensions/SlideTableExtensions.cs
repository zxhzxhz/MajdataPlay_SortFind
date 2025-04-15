using MajdataPlay.Game.Notes.Slide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajdataPlay.Game.Notes
{
    internal static class SlideTableExtensions
    {
        public static SlideTable Merge(this SlideTable origin, SlideTable table2)
        {
            var newQueue = new SlideArea[origin.JudgeQueue.Length + table2.JudgeQueue.Length - 1];
            var newConst = table2.Const;
            var newName = origin.Name;
        }
    }
}
