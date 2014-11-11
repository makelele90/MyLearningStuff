using System;

namespace DelegateDemo
{
  class DelegateChainingAndException
  {

    public void Start()
    {
      Action del =(Action)Moo + BeNasty + Goo;

      foreach (Action d in del.GetInvocationList())
      {
        try
        {
          d();
        }
        catch (Exception)
        {
        }

      }
      
    }

    public void Moo()
    {
      Console.WriteLine("Moo()");
    }
    public void BeNasty()
    {
      throw new Exception("nasty");
    }
    public void Goo()
    {
      Console.WriteLine("Goo()");
    }
  }
}
