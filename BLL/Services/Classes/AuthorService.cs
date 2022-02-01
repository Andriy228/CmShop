using BLL.Repositories.Classes;
using BLL.Repositories.Interfaces;
using BLL.Services.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Classes
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorService() {
            authorRepository = new AuthorRepository();
        }
        public void Add(Author author)
        {
            authorRepository.Add(author);
        }

        public void Delete(int id)
        {
            authorRepository.Delete(id);
        }

        public void Edit(int id, Author author)
        {
            authorRepository.Edit(id, author);
        }

        public List<Author> FindMany(Expression<Func<Author, bool>> filter = null)
        {
            return authorRepository.FindMany(filter);
        }

        public Author FindOne(Expression<Func<Author, bool>> filter = null)
        {
            return authorRepository.FindOne(filter);
        }

        public List<Author> GetAll()
        {
            return authorRepository.GetAll();
        }

        public Author GetTagByName(string name)
        {
            return authorRepository.FindByName(name);
        }
    }
}
