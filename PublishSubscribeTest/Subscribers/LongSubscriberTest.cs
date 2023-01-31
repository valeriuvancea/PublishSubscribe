using PublishSubscribe.Subscribers;

namespace PublishSubscribeTest;

[TestClass]
public class LongSubscriberTest : BaseSubscriberTest
{
  [TestMethod]
  public void TestDisplay()
  {
    double number = 1.2;
    new LongSubscriber().Display(number);
    var expected = $"Long result: {Convert.ToInt64(number)}" + Environment.NewLine;
    var actual = stringWriter.ToString();
    Assert.AreEqual(expected, actual);
  }
}