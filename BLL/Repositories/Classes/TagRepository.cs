using BLL.Exceptions;
using BLL.Repositories.Interfaces;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Utilities;

namespace BLL.Repositories.Classes
{
    public class TagRepository : ITagRepository
    {
        private readonly ApplicationContext context;

        public TagRepository() {
            context = new ApplicationContext();
        }
        public void Add(Tag entity)
        {
            entity.CreationDate = DateTimeRandom.RandomDay();
            context.Tags.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = context.Tags.Find(id);
            context.Tags.Remove(obj);
            context.SaveChanges();
        }


        public void Edit(int id, Tag entity)
        {
            var obj = context.Tags.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                if (entity.Name != null){ obj.Name = entity.Name; }
                if (entity.ComicsId != 0){ obj.ComicsId = entity.ComicsId; }
            }
            else {
                throw new TagException("Tag doesn't exists!");
            }
            context.SaveChanges();
        }

        public Tag FindByName(string name)
        {
            return context.Tags.FirstOrDefault(x=>x.Name == name);
        }

        public List<Tag> FindMany(Expression<Func<Tag, bool>> filter = null)
        {
            if ( filter!= null )
            {
                return context.Tags.Where(filter.Compile()).ToList();
            }

            return context.Tags.ToList();
        }

        public Tag FindOne(Expression<Func<Tag, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Tags.Where(filter.Compile()).FirstOrDefault();
            }

            return context.Tags.FirstOrDefault();
        }

        public List<Tag> GetAll()
        {
            return context.Tags.ToList();
        }
    }
}
