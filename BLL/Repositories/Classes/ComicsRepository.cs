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
    public class ComicsRepository : IComicsRepository
    {
        private readonly ApplicationContext context;

        public ComicsRepository() {
            context = new ApplicationContext();
        }
        public void Add(Comics entity)
        {
            entity.CreationDate = DateTimeRandom.RandomDay();
            context.Comicses.Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var obj = context.Comicses.Find(id);
            context.Comicses.Remove(obj);
            context.SaveChanges();
        }

        public void Edit(int id,Comics entity)
        {
            var obj = context.Comicses.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                if (entity.Name != null){ obj.Name = entity.Name; }
                if (entity.Order != 0){ obj.Order = entity.Order; }
                if (entity.PublishingHouse != 0){ obj.PublishingHouse = entity.PublishingHouse; }
                if (entity.Pages != 0) { obj.Pages = entity.Pages; }
            }
            else {
                throw new ComicsException("Comics doesn't exists!");
            }
            context.SaveChanges();
        }

        public Comics FindByName(string name)
        {
            return context.Comicses.FirstOrDefault(x => x.Name == name);
        }

        public List<Comics> FindMany(Expression<Func<Comics, bool>> filter = null)
        {
            if (filter != null) {
                return context.Comicses.Where(filter.Compile()).ToList();
            }
            return context.Comicses.ToList();
        }

        public Comics FindOne(Expression<Func<Comics, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Comicses.Where(filter.Compile()).FirstOrDefault();
            }
            return context.Comicses.FirstOrDefault();
        }

        public List<Comics> GetAll()
        {
            return context.Comicses.ToList();
        }
    }
}
