using System.ComponentModel;
using System.Threading;
using Frends.TestTask.DoNothing.Definitions;

namespace Frends.TestTask.DoNothing;

/// <summary>
///  docs
/// </summary>
public static class TestTask
{
    /// <summary>
    /// TaskDescription
    /// [Documentation](https://tasks.frends.com/tasks/frends-tasks/Party-Echo-Execute)
    /// </summary>
    /// <param name="input">Essential parameters.</param>
    /// <param name="options">Additional parameters.</param>
    /// <param name="cancellationToken">A cancellation token provided by Frends Platform.</param>
    /// <returns>object { bool Success, string Output, object Error { string Message, Exception AdditionalInfo } }</returns>
    public static Result DoNothing(
        [PropertyTab] Input input,
        [PropertyTab] Options options,
        CancellationToken cancellationToken)
    {
        return new Result();
    }
}
