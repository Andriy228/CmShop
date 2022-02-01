using BLL.Exceptions;
using BLL.Repositories.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL.Repositories.Classes
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationContext context;
        public AuthorRepository() { 
            context = new ApplicationContext();
        }
        public void Add(Author entity)
        {
            entity.CreationDate = DateTimeRandom.RandomDay();
            entity.BirthDate = DateTimeRandom.RandomDay();
            context.Authors.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = context.Authors.Find(id);
            context.Authors.Remove(obj);
            context.SaveChanges();
        }

        public void Edit(int id, Author entity)
        {
            var obj = context.Authors.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                if (entity.FirstName != null){ obj.FirstName = entity.FirstName; }
                if (entity.LastName != null){ obj.LastName = entity.LastName; }
            }
            else {
                throw new AuthorException("Author doesn't exists!");
            }
            context.SaveChanges();
        }

        public Author FindByName(string name)
        {
            return context.Authors.FirstOrDefault(x => x.FirstName == name);
        }

        public List<Author> FindMany(Expression<Func<Author, bool>> filter = null)
        {
            if (filter != null) {
                return context.Authors.Where(filter.Compile()).ToList();
            }

            return context.Authors.ToList();
        }

        public Author FindOne(Expression<Func<Author, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Authors.Where(filter.Compile()).FirstOrDefault();
            }

            return context.Authors.FirstOrDefault();
        }

        public List<Author> GetAll()
        {
            return context.Authors.ToList();
        }
    }
}
