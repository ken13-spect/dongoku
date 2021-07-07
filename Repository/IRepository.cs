using System;
using System.Collections.Generic;

namespace AppUCA.Repository
{
    public interface IRepository<T>
    {
       List <T> GetAll();

       void Create(T item);
       
       void Delete(T item);
    }
    
  
}