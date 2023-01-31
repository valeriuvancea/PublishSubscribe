using PublishSubscribe.Publishers;
using PublishSubscribe.Subscribers;

namespace PublishSubscribeTest;

[TestClass]
public class PublisherTest
{
  private static double? _result;

  class FakeSubscriber : ISubscriber
  {
    public void Display(double result)
    {
      _result = result;
    }
  }

  [TestInitialize]
  public void TestInitialize()
  {
    _result = null;
  }

  [TestMethod]
  public async Task TestPublisher()
  {
    var publisher = new Publisher();
    publisher.Subscribe(new FakeSubscriber().Display);

    Console.SetIn(new StringReader("0"));
    new Task(() => publisher.Start()).Start();

    await AwaitUtility.Until(() => _result != null);
    Assert.AreEqual(0, _result);
  }

  [TestMethod]
  public void TestPublisherShouldThrowExceptionForStringInput()
  {
    var publisher = new Publisher();

    publisher.Subscribe(new FakeSubscriber().Display);

    Assert.ThrowsException<FormatException>(() =>
    {
      Console.SetIn(new StringReader("test"));
      publisher.Start();
    });
  }

  [TestMethod]
  public void TestPublisherShouldThrowExceptionForDoubleInput()
  {
    var publisher = new Publisher();

    publisher.Subscribe(new FakeSubscriber().Display);

    Assert.ThrowsException<FormatException>(() =>
    {
      Console.SetIn(new StringReader("1.2"));
      publisher.Start();
    });
  }
}