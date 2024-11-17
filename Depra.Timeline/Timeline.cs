using System.Collections.Generic;

namespace Depra.Timeline.Animation
{
    public class Timeline : ITimeline
    {
        private readonly Queue<IAnimated> _queue;

        private float _time;

        public Timeline(float time)
        {
            _time = time;
            _queue = new Queue<IAnimated>();
        }

        public void Tick(float timeStep)
        {
            _time += timeStep;
            var currentAnimated = _queue.Peek();
            if (currentAnimated == null || _time < currentAnimated.StartTime)
            {
                return;
            }

            currentAnimated = _queue.Dequeue();
            currentAnimated.Play();
        }

        public void Add(IAnimated animated)
        {
            _queue.Enqueue(animated);
        }
    }
}