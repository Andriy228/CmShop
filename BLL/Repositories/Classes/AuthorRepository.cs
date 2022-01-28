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
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Guid id, Author entity)
        {
            throw new NotImplementedException();
        }

        public Author FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Author> FindMany(Expression<Func<Author, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Author FindOne(Expression<Func<Author, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
