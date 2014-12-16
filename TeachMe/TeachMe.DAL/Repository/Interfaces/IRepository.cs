using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TeachMe.DataContainer.DTO;

namespace TeachMe.DAL.Repository.Interfaces
{
  public interface IRepository<T>
  {
    T Single(Expression<Func<T, bool>> predicate);
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    IEnumerable<T> FindAll();
    OperationStatus Create(T entity);
    OperationStatus Update(T entity);
    OperationStatus Delete(T entity);
  }
}
