
namespace PublishSubscribeTest;

public class AwaitUtility
{
  public static async Task Until(
    Func<bool> until,
    int pollInterval = 100,
    int timeout = 5000)
  {
    var timerExpired = false;
    var timer = new System.Timers.Timer(timeout);
    timer.Elapsed += (_, _) => timerExpired = true;

    while (!until() && !timerExpired)
    {
      await Task.Delay(pollInterval);
    }

    if (timerExpired)
    {
      throw new TimeoutException("AwaitUtility timer expired");
    }
  }
}