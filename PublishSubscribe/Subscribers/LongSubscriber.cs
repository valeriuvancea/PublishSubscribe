namespace PublishSubscribe.Subscribers;

public class LongSubscriber : ISubscriber
{
  public void Display(double result)
  {
    Console.WriteLine($"Long result: {Convert.ToInt64(result)}");
  }
}
