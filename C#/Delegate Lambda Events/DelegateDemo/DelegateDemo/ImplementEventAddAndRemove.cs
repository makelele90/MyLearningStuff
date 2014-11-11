
using System;

namespace DelegateDemo
{
  public class ImplementEventAddAndRemove
  {

    private event Action mooing;
    public event Action Mooing
    {
      add
      {
        mooing += value;
      }
      remove
      {
        mooing -= value;
      }
    }

    public void Moo()
    {
      if (mooing!=null)
      {
        mooing();
      }
    }
  }
}
