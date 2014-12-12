using Rhino.Mocks;
using NUnit.Framework;
using TeachMe.BLL.Services.Classes;
using TeachMe.BLL.Services.Interfaces;
using TeachMe.DAL.Repository.Interfaces;
using TeachMe.DataContainer;

namespace TeachMe.BLL.Test
{
  [TestFixture]
  public class AuthenticationTest
  {
    private IAuthenticationService _authenticationService;
    private IRepository<User> _userRepository;

    [SetUp]
    public void Initialise()
    {
      _userRepository=new UserRepository();
      _authenticationService=new AuthenticationService(_userRepository);
    }
    [Test]
    public void Login_should_return_false_if_Authentication_is_unsucessful()
    {
      var isLogin = _authenticationService.Login("kamo","123");

      Assert.IsFalse(isLogin);
    }
    [Test]
    public void Login_should_return_true_if_Authentication_is_sucessful()
    {
      var isLogin = _authenticationService.Login("pat", "123");

      Assert.IsTrue(isLogin);
    }
  }
}
