using PublishSubscribe.Delegates;

namespace PublishSubscribe.Publishers;
public interface IPublisher
{
  void Subscribe(NumberDelegate numberHandler);
}