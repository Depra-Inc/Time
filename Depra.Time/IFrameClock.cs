namespace Depra.Time
{
	public interface IFrameClock
	{
		float FrameTime { get; }
		float FixedFrameTime { get; }
	}
}