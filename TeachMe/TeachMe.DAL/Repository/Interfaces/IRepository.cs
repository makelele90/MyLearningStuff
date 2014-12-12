using System.Collections.Generic;
using TeachMe.DataContainer.DTO;

namespace TeachMe.DAL.Repository.Interfaces
{
  public interface IRepository<T>
  {
    T Single(T u);
    IEnumerable<T> FindAll();
    OperationStatus Create(T u);
    OperationStatus Update(T u);
    OperationStatus Delete(T u);
  }
}
