
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;

namespace AOPClient
{
  public class MyTypeRegistration:IRegistration
  {
    public void Register(IKernelInternal kernel)
    {

      kernel.Register(Component.For<LoggingInterceptor>().ImplementedBy<LoggingInterceptor>());
      kernel.Register(Component.For<IOrderDao>().ImplementedBy<OrderDao>()
        .Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Anywhere
        );
    }
  }
}
