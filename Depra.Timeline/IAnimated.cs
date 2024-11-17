namespace Depra.Timeline.Animation
{
    public interface IAnimated
    {
        float Duration { get; }
        
        float StartTime { get; }

        void Play();
    }
}