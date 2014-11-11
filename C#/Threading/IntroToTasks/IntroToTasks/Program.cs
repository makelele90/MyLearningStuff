using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroToTasks
{
  class Program
  {
    static void Main()
    {
      //Task.Factory.StartNew(WhatTypeOfThreadAmI,TaskCreationOptions.LongRunning).Wait();
      //  Task.Factory.StartNew(() => Console.WriteLine("hello word")).Wait();

      //Task<int> t= Task.Factory.StartNew(() => Add(2000, 2000));
      
    //  Console.WriteLine(t.Result);

     
      
    //  UInt32 a=unchecked( (UInt32)(-1));
    //  Console.WriteLine(a);
      
      
    //  checked
    //  {
    //    Byte c = 100;
    //    c += 200;
    //  }
      
    //  string at= ""
    //  IEnumerable<int> array= new int[]{2,3,4,8,3};

    //  IEnumerator enumerator = array.GetEnumerator();

    //    Console.Read();

      var array = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

      var enumerator = array.GetEnumerator();

      while (enumerator.MoveNext())
      {
        Console.WriteLine(enumerator.Current.ToString());

        if ((int)enumerator.Current==5)
        {
          test(enumerator);
        }
      }
      
      Console.Read();
    }

    //static void WhatTypeOfThreadAmI()
    //{
    //  Console.WriteLine("I'm a {0} thread ",Thread.CurrentThread.IsThreadPoolThread?"Thread pool":"Custom");
    //  Console.Read();
    //}

    //static void Speak(string words)
    //{
    //  Console.WriteLine(words);
    //}

     public static int Add(int x, int y)
     {
       return x + y;
     }

     static void test(IEnumerator array)
     {
       while (array.MoveNext())
       {
         Console.WriteLine(array.Current.ToString());
       }
     }
  }
}
