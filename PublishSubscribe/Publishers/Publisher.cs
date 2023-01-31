using PublishSubscribe.Processors;
using PublishSubscribe.Delegates;

namespace PublishSubscribe.Publishers;
public class Publisher : IPublisher
{
  private event NumberDelegate? _numberEvent;
  public void Subscribe(NumberDelegate numberHandler)
  {
    _numberEvent += numberHandler;
  }

  public void Start()
  {
    string? line = null;
    do
    {
      Console.WriteLine("Input an integer and press enter:");
      line = Console.ReadLine();

      if (!String.IsNullOrEmpty(line))
      {
        var number = long.Parse(line);
        _numberEvent?.Invoke(NumberProcessor.processNumber(number));
      }
    } while (line != null);
  }
}