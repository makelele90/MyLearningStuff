using System;

namespace DesignPatternsDemo
{
  public class Subscriber:IObserver<Payload>
  {
    private IDisposable _unsubscriber;
    public virtual void Subscribe(IObservable<Payload> subject)
    {
      if (subject!=null)
      {
        _unsubscriber = subject.Subscribe(this);
      }
    }
    public virtual void OnNext(Payload value)
    {
      Console.WriteLine("next is happening {0}",value.Message);
    }

    public virtual void OnError(Exception error)
    {
      Console.WriteLine("error is happening");
    }

    public virtual void OnCompleted()
    {
      Console.WriteLine("OnCompleted is happening");
    }

    public virtual void Unsubscriber()
    {
      _unsubscriber.Dispose();
    }
  }
}