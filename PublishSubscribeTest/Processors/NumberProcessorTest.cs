using PublishSubscribe.Processors;

namespace PublishSubscribeTest;

[TestClass]
public class NumberProcessorTest
{
  [TestMethod]
  public void TestProcessNumber()
  {
    var expected = 0;
    var actual = NumberProcessor.processNumber(0);
    Assert.AreEqual(expected, actual);
  }
}