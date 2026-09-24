using System.Threading;
using Frends.TestTask.DoNothing.Definitions;
using NUnit.Framework;

namespace Frends.TestTask.DoNothing.Tests
{
    [TestFixture]
    public class TestTaskTests
    {
        [Test]
        public void DoNothingTest()
        {
            var result = TestTask.DoNothing(new Input(), new Options(), CancellationToken.None);
            Assert.IsTrue(result.Success);
        }
    }
}
