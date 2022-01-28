using BLL.Repositories.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories.Classes
{
    public class ComicsRepository : IComicsRepository
    {
        public void Add(Comics entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Comics entity)
        {
            throw new NotImplementedException();
        }

        public Comics FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Comics> FindMany(Expression<Func<Comics, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Comics FindOne(Expression<Func<Comics, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Comics> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
