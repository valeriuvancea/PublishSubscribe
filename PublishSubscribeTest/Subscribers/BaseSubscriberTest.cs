namespace PublishSubscribeTest;

public abstract class BaseSubscriberTest
{
  protected StringWriter stringWriter = new StringWriter();

  protected BaseSubscriberTest()
  {
    Console.SetOut(stringWriter);
  }
}