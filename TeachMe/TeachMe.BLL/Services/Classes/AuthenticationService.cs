using System.Collections.Generic;
using TeachMe.BLL.Services.Interfaces;
using TeachMe.DAL.Repository.Interfaces;
using TeachMe.DataContainer.Data;

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
      var user = _userRepository.Single(u => u.Username == username && u.Password == password);

      return user != null;
    }

    public IEnumerable<User> FindAll()
    {
      return _userRepository.FindAll();
    }

    public User Find(string username)
    {
      return _userRepository.Single(u => u.Username == username);
    }

    public User GetSingle(int id)
    {
      return _userRepository.Single(u => u.Id == id);
    }

    public bool CreateUser(User user)
    {
      
      var result=_userRepository.Create(user);

      return result.Status;
    }

    public bool UpdateUser(User user)
    {
      var result = _userRepository.Update(user);

      return result.Status;
    }

    public bool RemoveUser(int id)
    {
      var user = _userRepository.Single(u => u.Id == id);
      
      var result = _userRepository.Delete(user);

      return result.Status;
    }
  }
}
