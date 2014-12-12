using System.Collections.Generic;
using TeachMe.BLL.Services.Interfaces;
using TeachMe.DAL.Repository.Interfaces;
using TeachMe.DataContainer;
using System.Linq;

namespace TeachMe.BLL.Services.Classes
{
  public class AuthenticationService : IAuthenticationService
  {
    private readonly IRepository<User> _userRepository;

    public AuthenticationService(IRepository<User> userRepository)
    {
      _userRepository = userRepository;
    }

    public bool Login(string username, string password)
    {
      var user = _userRepository.Single(new User() {Username = username, Password = password});

      return user != null;
    }
  }
}
