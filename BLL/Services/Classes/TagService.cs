using BLL.Managers.Interfaces;
using BLL.Repositories.Classes;
using BLL.Repositories.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BLL.Services.Classes
{
    public class TagService : ITagService
    {
        private readonly ITagRepository tagRepository;

        public TagService()
        {
            tagRepository = new TagRepository();
        }
        public void Add(Tag tag) {
            tagRepository.Add(tag);
        }
        public void Edit(Guid id, Tag tag)
        {
            tagRepository.Edit(id, tag);
        }
        public Tag GetTagByName(string name)
        {
            return tagRepository.FindByName(name);
        }
        public List<Tag> GetAll() { 
            return tagRepository.GetAll();
        }
        public Tag FindOne(Expression<Func<Tag, bool>> filter = null) { 
            return tagRepository.FindOne(filter);
        }
        public List<Tag> FindMany(Expression<Func<Tag, bool>> filter = null) {
            return tagRepository.FindMany(filter);
        }
    }
}
