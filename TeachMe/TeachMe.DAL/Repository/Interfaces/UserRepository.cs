using System.Collections.Generic;
using System.Linq;
using TeachMe.DataContainer;
using TeachMe.DataContainer.DTO;

namespace TeachMe.DAL.Repository.Interfaces
{
  public class UserRepository:IRepository<User>
  {
    private static readonly List<User> Users = new List<User>()
      {
        new User() {Username = "pat", Password = "123"},
        new User() {Username = "joanna", Password = "patate"},
        new User() {Username = "mary", Password = "manate"}
      };

    public User Single(User user)
    {
      return Users.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);
    }

    public IEnumerable<User> FindAll()
    {
      throw new System.NotImplementedException();
    }

    public OperationStatus Create(User u)
    {
      throw new System.NotImplementedException();
    }

    public OperationStatus Update(User u)
    {
      throw new System.NotImplementedException();
    }

    public OperationStatus Delete(User u)
    {
      throw new System.NotImplementedException();
    }
  }
}