using System;
using System.Linq.Expressions;
using NUnit.Framework;
using TeachMe.BLL.Services.Classes;
using TeachMe.BLL.Services.Interfaces;

using TeachMe.DAL.Repository.Interfaces;
using TeachMe.DataContainer.Data;
using Rhino.Mocks;

namespace TeachMe.BLL.Test
{
  [TestFixture]
  public class AuthenticationTest
  {
    private IAuthenticationService _authenticationService;
    private IRepository<User> _repoMock;

    [SetUp]
    public void Initialise()
    {
      _repoMock = MockRepository.GenerateMock<IRepository<User>>();
      _authenticationService = new AuthenticationService(_repoMock);
    }
    [Test]
    public void Login_should_return_false_if_Authentication_is_unsucessful()
    {
      _repoMock.Stub(x => x.Single(Arg<Expression<Func<User, bool>>>.Is.Anything)).Return(null);

      var isLogin = _authenticationService.Login("kamo","123");

      Assert.IsFalse(isLogin);
    }
    [Test]
    public void Login_should_return_true_if_Authentication_is_sucessful()
    {
      _repoMock.Stub(x => x.Single(Arg<Expression<Func<User, bool>>>.Is.Anything)).Return(new User());
      var isLogin = _authenticationService.Login("pat", "123");

      Assert.IsTrue(isLogin);
    }
  }
}
