using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IAuthorService
    {
        void Add(Author author);
        Author GetTagByName(string name);
        void Delete(int id);
        void Edit(int id, Author author);
        List<Author> GetAll();
        Author FindOne(Expression<Func<Author, bool>> filter = null);
        List<Author> FindMany(Expression<Func<Author, bool>> filter = null);
    }
}
