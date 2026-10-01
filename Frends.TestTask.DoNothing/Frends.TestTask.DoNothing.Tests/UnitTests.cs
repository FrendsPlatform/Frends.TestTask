using System;
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
            var username = Environment.GetEnvironmentVariable("FOO");

            var result = TestTask.DoNothing(new Input(), new Options(), CancellationToken.None);

            Assert.That(result.Success, Is.False);
            Assert.That(username, Is.EqualTo("bar"));
        }

        [Test]
        public void DoNothingTest_WithFullyPopulatedParameters()
        {
            var input = new Input
            {
                Content = "foobar",
                Repeat = 2,
            };

            var options = new Options
            {
                Delimiter = ",",
                ThrowErrorOnFailure = false,
                ErrorMessageOnFailure = "Custom error message",
            };

            var result = TestTask.DoNothing(input, options, CancellationToken.None);

            Assert.That(result.Success, Is.False);
            Assert.That(result.Error, Is.Null);

            Assert.That(input.Content, Is.EqualTo("foobar"));
            Assert.That(input.Repeat, Is.EqualTo(2));
            Assert.That(options.Delimiter, Is.EqualTo(","));
            Assert.That(options.ThrowErrorOnFailure, Is.False);
            Assert.That(options.ErrorMessageOnFailure, Is.EqualTo("Custom error message"));
        }

        [Test]
        public void ResultTest_SuccessAndErrorCanBeSetAndRead()
        {
            var exception = new InvalidOperationException("Something went wrong.");
            var error = new Error
            {
                Message = "Unable to join strings.",
                AdditionalInfo = exception,
            };

            var result = new Result
            {
                Success = true,
                Error = error,
            };

            Assert.That(result.Success, Is.True);
            Assert.That(result.Error, Is.Not.Null);
            Assert.That(result.Error.Message, Is.EqualTo("Unable to join strings."));
            Assert.That(result.Error.AdditionalInfo, Is.SameAs(exception));
        }
    }
}
