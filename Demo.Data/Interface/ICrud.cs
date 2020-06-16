using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Interface
{
    public interface ICrud<T> where T : class
    {
        List<T> Get();
        List<T> GetById(int id);
        string Insert(T entity);
        string Update(T entity);
        bool Delete(int id);
    }
}
