using System;

namespace LinqDemo
{
  class LetClauseInDeep
  {
    public void Star()
    {
      var inputs = new[]
        {
          new {a=1,b=2,c=3},
           new {a=2,b=9,c=4},
            new {a=7,b=3,c=6}
        };

      var result = from coef in inputs

                   let negB = -coef.b
                   let descriminant = coef.b*coef.b - 4*coef.a*coef.c
                   let dividant = 2*coef.a

                   select new
                     {
                       Value1 = (negB - Math.Sqrt(descriminant))/dividant,
                       Value2 = (negB + Math.Sqrt(descriminant))/dividant
                     };


      var result2 = inputs.Select(coef => new {coef, negB = -coef.b})
                         .Select(tp1 => new {tp1, descri = tp1.coef.b*tp1.coef.b - 4*tp1.coef.a*tp1.coef.c})
                         .Select(tp2 => new {tp2, div = 2*tp2.tp1.coef.a})
                         .Select(tp3 => new
                           {

                             Value1 = (tp3.tp2.tp1.negB - Math.Sqrt(tp3.tp2.descri)) / tp3.div,
                             Value2 = (tp3.tp2.tp1.negB - Math.Sqrt(tp3.tp2.descri)) / tp3.div
                           });



      foreach (var coef in result2)
        Console.WriteLine("Val1: "+coef.Value1+" Val2: "+coef.Value2);


    }
  }
}
