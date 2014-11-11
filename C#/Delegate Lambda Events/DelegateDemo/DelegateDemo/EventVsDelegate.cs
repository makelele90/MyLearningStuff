
using System;

namespace DelegateDemo
{
  public class EventVsDelegate
  {
    public event Action TrainComing;

    public void TheTrainIsComming()
    {
      if (TrainComing!=null)
      {
        TrainComing();
      }
      
    }
  }

  public class Car
  {
    public Car(EventVsDelegate deEventVsDelegate)
    {
      deEventVsDelegate.TrainComing += Stop;
    }

    private void Stop()
    {
      Console.WriteLine("Big stop train is comming");
    }
  }
}
