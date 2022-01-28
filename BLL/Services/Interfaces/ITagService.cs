using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BLL.Managers.Interfaces
{
    public interface ITagService
    {
        void Add(Tag tag);
        Tag GetTagByName(string name);

        void Edit(Guid id, Tag tag);
        List<Tag> GetAll();
        Tag FindOne(Expression<Func<Tag, bool>> filter = null);
        List<Tag> FindMany(Expression<Func<Tag, bool>> filter = null);
    }
}
