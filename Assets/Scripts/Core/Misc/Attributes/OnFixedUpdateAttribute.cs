using System;

namespace MajdataPlay
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class OnFixedUpdateAttribute : PlayerLoopFunctionAttribute
    {
        public OnFixedUpdateAttribute() : base()
        {
            Timing = LoopTiming.FixedUpdate;
        }
    }
}
