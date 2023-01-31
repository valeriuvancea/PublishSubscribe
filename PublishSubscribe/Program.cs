using PublishSubscribe.Publishers;
using PublishSubscribe.Subscribers;

namespace PublishSubscribe;
class Program
{
  static void Main(string[] args)
  {
    var publisher = new Publisher();

    publisher.Subscribe(new LongSubscriber().Display);
    publisher.Subscribe(new DoubleSubscriber().Display);

    publisher.Start();
  }
}
