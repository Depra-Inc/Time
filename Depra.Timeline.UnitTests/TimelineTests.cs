using NUnit.Framework;

namespace Depra.Timeline.UnitTests
{
    [TestFixture(TestOf = typeof(Animation.Timeline))]
    public class TimelineTests
    {
        private Animation.Timeline _timeline;

        [SetUp]
        public void Setup()
        {
            _timeline = new Animation.Timeline(0f);
        }

        [Test]
        public void WhenAddAnimated_AndTick_Then()
        {
            // Arrange.
            var animated = new TestAnimated(1f, 1f);
            _timeline.Add(animated);

            // Act.

            // Assert.
        }
    }
}