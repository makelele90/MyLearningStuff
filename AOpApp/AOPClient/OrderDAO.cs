using System;
namespace AOPClient
{
  
  public class OrderDao : IOrderDao
  {
   
    public void CreateOrder()
    {
     
      Console.WriteLine("Creating order");
    }
  }

  public interface IOrderDao
  {
    void CreateOrder();
  }
}
