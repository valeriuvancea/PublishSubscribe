namespace PublishSubscribe.Subscribers;
public class DoubleSubscriber : ISubscriber
{
  public void Display(double result)
  {
    Console.WriteLine($"Double result: {result}");
  }
}
