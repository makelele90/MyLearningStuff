
using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadingDemo
{
  class Program
  {
    private static Random _rand = new Random();
    static object _baton=new object();
    private static int _count = 0;
    static void Main()
    {

      /*  
        ThreadingDemo 1
       ---------------------------------------------------------
       Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        var issues = new ThreadSyncIssues();
        for (int i = 0; i < Environment.ProcessorCount; i++)
        {
          var thread = new Thread(issues.Start) { IsBackground = false };
          thread.Start(i);
        }

        Console.WriteLine("leaving main"); 
     
       */

      /* 
        ThreadingDemo 2
         ---------------------------------------------------------
        var thread1 = new Thread(IncrementCount);
        var thread2 = new Thread(IncrementCount);
        thread1.Start();
        Thread.Sleep(500);
        thread2.Start(); 
     
       */

      /* 
       ThreadingDemo 3
       ---------------------------------------------------------
       for (int i = 0; i < 5; i++)
        {
          new Thread(UserRestroomStall).Start();
        } */


      //Dealing with app domain

      var domainA = AppDomain.CreateDomain("DomainA");
      var domainB = AppDomain.CreateDomain("DomainB");

      domainA.SetData("DomainKey","DomainA38388");
      domainB.SetData("DomainKey", "DomainB7477");
      OutputCall();
      domainA.DoCallBack(OutputCall); //CrossAppDomainDelegate call
      domainB.DoCallBack(OutputCall); //CrossAppDomainDelegate call
      Console.Read();
    }
    static void IncrementCount()
    {
      while (true)
      {
        lock (_baton)
        {
          int temp = _count;
          Thread.Sleep(1000);
          _count = temp + 1;
          Console.WriteLine("Thread ID " + Thread.CurrentThread.ManagedThreadId + " incremented count to " + _count);
        }
        
      }

      
    }
    private static void UserRestroomStall()
    {
      Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" Trying to obtain the bathroom stall.....");

      lock (_baton)
      {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" obtained the lock.Doing my business...");
        Thread.Sleep(_rand.Next(2000));
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" Leaving the stall....");
      }
      Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" is leaving the restaurant.");
    }
    static  Queue<int> numbers=new Queue<int>();
    static Random rand=new Random();
    static int _numThreads = 3;
    static int[] _sums=new int[_numThreads];
    private static void ProduceNumbers()
    {
      for (int i = 0; i < 25; i++)
      {
        numbers.Enqueue(rand.Next(10));
        Thread.Sleep(rand.Next(1000));
      }
    }
    static void OutputCall()
    {
      var domain = AppDomain.CurrentDomain;
      Console.WriteLine("the value {0} was found in {1}, running on thread Id {2}",
                domain.GetData("DomainKey"), domain.FriendlyName,
                Thread.CurrentThread.ManagedThreadId);
    }
  }
}
