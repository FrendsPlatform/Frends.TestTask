using NUnit.Framework;

namespace Frends.TestTask.DoNothing.Tests
{
    [TestFixture]
    public class TestTaskTests
    {
        [Test]
        public void DoNothingTest()
        {
            var result = TestTask.DoNothing();
            Assert.AreEqual("true", result);
        }
    }
}