using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajdataPlay
{
    [AttributeUsage(AttributeTargets.Method)]
    public class PlayerLoopFunctionAttribute : Attribute
    {
        public LoopTiming Timing
        {
            get => _timing;
            init => _timing = value;
        }

        LoopTiming _timing = LoopTiming.Update;
    }
    [Flags]
    public enum LoopTiming
    {
        PreUpdate = 1,
        Update,
        LateUpdate,
        FixedUpdate
    }
}
