using BLL.Managers.Interfaces;
using BLL.Services.Classes;
using Domain;
using Domain.Models;
using System;

namespace ComicsShop
{
    class Program
    {
        static readonly ITagService tagService;

        static Program()
        {
            tagService = new TagService();
        }

        static void Main(string[] args)
        {
            foreach (var item in tagService.FindMany(x=>x.Name[0] == 'M')) {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(tagService.FindOne(x => x.Name[0] == 'M').Name);
        }

        static Tag GetSpecialTags(string name)
        {
            return tagService.GetTagByName(name);
        } 
    }
}
