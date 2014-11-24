using System;
using System.Collections.Generic;

namespace DesignPatternsDemo
{
  public class Unsubscriber : IDisposable
  {
    private readonly List<IObserver<Payload>> _observers;
    private readonly IObserver<Payload> _observer;

    public Unsubscriber(List<IObserver<Payload>> observers, IObserver<Payload> observer)
    {
      _observers = observers;
      _observer = observer;
    }

    public void Dispose()
    {
      if (_observer != null && _observers.Contains(_observer))
        _observers.Remove(_observer);
    }
  }
}