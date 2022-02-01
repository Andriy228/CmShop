using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseModel
    {
        void Add(T entity);

        void Edit(int id,T entity);

        List<T> GetAll();

        T FindByName(string name);
        void Delete(int id);

        T FindOne(Expression<Func<T, bool>> filter = null);

        List<T> FindMany(Expression<Func<T, bool>> filter = null);
    }
}
