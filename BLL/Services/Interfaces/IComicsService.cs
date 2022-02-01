using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IComicsService
    {
        void Add(Comics comics);
        Comics GetTagByName(string name);
        void Delete(int id);
        void Edit(int id, Comics comics);
        List<Comics> GetAll();
        Comics FindOne(Expression<Func<Comics, bool>> filter = null);
        List<Comics> FindMany(Expression<Func<Comics, bool>> filter = null);
    }
}
