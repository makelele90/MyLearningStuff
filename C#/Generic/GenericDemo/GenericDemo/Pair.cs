
namespace GenericDemo
{
  public class Pair<T,TU>
  {
    public T First { get; set; }
    public TU Second { get; set; }

    public override string ToString()
    {
      return "{ First:" + First + " Second: " + Second + "}";
    }
  }
}
