using Castle.Windsor;

namespace AOPClient
{
  public class BootStrapper
  {
    private static readonly IWindsorContainer Container=new WindsorContainer();

    public static IWindsorContainer RegisterAll()
    {
      Container.Register(new MyTypeRegistration());

      return Container;
    }
  }
}
