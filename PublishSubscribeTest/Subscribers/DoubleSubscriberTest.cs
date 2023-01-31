using PublishSubscribe.Subscribers;

namespace PublishSubscribeTest;

[TestClass]
public class DoubleSubscriberTest : BaseSubscriberTest
{
  [TestMethod]
  public void TestDisplay()
  {
    double number = 1.2;
    new DoubleSubscriber().Display(number);
    var expected = $"Double result: {number}" + Environment.NewLine;
    var actual = stringWriter.ToString();
    Assert.AreEqual(expected, actual);
  }
}