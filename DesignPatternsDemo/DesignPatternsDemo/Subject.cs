using System;
using System.Collections.Generic;

namespace DesignPatternsDemo
{
  public class Subject : IObservable<Payload>
  {
    private List<IObserver<Payload>> _observers; 
    public Subject()
    {
      _observers=new List<IObserver<Payload>>();
    }
    public IDisposable Subscribe(IObserver<Payload> observer)
    {
      if(!_observers.Contains(observer)) _observers.Add(observer);

      return new Unsubscriber(_observers,observer);
    }

    public void SendMessage(Payload? payload)
    {
      
      foreach (var observer in _observers)
      {
        if (!payload.HasValue)
          observer.OnError(new MessageUnknownException());
        else
          observer.OnNext(payload.Value);
      }
    }

    public void EndTransmission()
    {
      foreach (var observer in _observers.ToArray())
        if (_observers.Contains(observer))
          observer.OnCompleted();

      _observers.Clear();
    }

  }

  public class MessageUnknownException : Exception
  {
    internal MessageUnknownException()
    {
    }
  }
}
