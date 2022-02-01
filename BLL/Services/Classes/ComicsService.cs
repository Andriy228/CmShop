using BLL.Repositories.Classes;
using BLL.Repositories.Interfaces;
using BLL.Services.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL.Services.Classes
{
    public class ComicsService : IComicsService
    {
        private readonly IComicsRepository comicsRepository;
        public ComicsService() {
            comicsRepository = new ComicsRepository();
        }
        public void Add(Comics comics)
        {
            comicsRepository.Add(comics);
        }

        public void Delete(int id)
        {
            comicsRepository.Delete(id);
        }

        public void Edit(int id, Comics comics)
        {
            comicsRepository.Edit(id, comics);
        }

        public List<Comics> FindMany(Expression<Func<Comics, bool>> filter = null)
        {
            return comicsRepository.FindMany(filter);
        }

        public Comics FindOne(Expression<Func<Comics, bool>> filter = null)
        {
            return comicsRepository.FindOne(filter);
        }

        public List<Comics> GetAll()
        {
            return comicsRepository.GetAll();
        }

        public Comics GetTagByName(string name)
        {
            return comicsRepository.FindByName(name);
        }
    }
}
