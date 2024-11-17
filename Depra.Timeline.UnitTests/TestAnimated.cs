using Depra.Timeline.Animation;

namespace Depra.Timeline.UnitTests
{
    internal sealed class TestAnimated : IAnimated
    {
        public TestAnimated(float duration, float startTime)
        {
            Duration = duration;
            StartTime = startTime;
        }

        public float Duration { get; }

        public float StartTime { get; }

        public void Play() { }
    }
}