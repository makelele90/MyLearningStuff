using System;

namespace GarbageCollectionDemo
{
  public class Customer:IDisposable
  {

    ~Customer()
    {
      Dispose(false);
    }

    public void Dispose()
    {
      Dispose(true);
    }
    private void Dispose(bool disposing)
    {
      if (disposing)
      {
        Console.WriteLine("Killing the customer object the right way");
        GC.SuppressFinalize(this);
      }
      else
      {
        Console.WriteLine("Killing the customer Mappppppppppppppppp!!!!!!!!!!!!!");
      }
    }
  }
}
