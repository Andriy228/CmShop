using BLL.Services.Classes;
using BLL.Services.Interfaces;
using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;

namespace ComicsShop
{
    class WorkWithService { 
        private readonly IAuthorService authorService;
        private readonly IComicsService comicsService;
        private readonly ITagService tagService;
        public WorkWithService() {
            authorService = new AuthorService();
            comicsService = new ComicsService();
            tagService = new TagService();
        }

        public void AddData() {
            //Add new Authors:
            authorService.Add(new Author { FirstName = "Ivan", LastName = "Turhenev" });
            authorService.Add(new Author { FirstName = "Taras", LastName = "Shevchenko" });
            authorService.Add(new Author { FirstName = "Hruhoriy", LastName = "Tyutynnuk" });
            authorService.Add(new Author { FirstName = "Lesia", LastName = "Ukrainka" });
            authorService.Add(new Author { FirstName = "Ivan", LastName = "Hohol" });

            //Add new Comicses:
            comicsService.Add(new Comics { Name = "Chereshnya", AuthorId = 2, IsSpecial = true, Order = 12, Pages = 32, PublishingHouse = PublishingHouse.Marvel });
            comicsService.Add(new Comics { Name = "Urosya", AuthorId = 5, IsSpecial = false, Order = 42, Pages = 132, PublishingHouse = PublishingHouse.DC });
            comicsService.Add(new Comics { Name = "Basroh", AuthorId = 4, IsSpecial = true, Order = 37, Pages = 232, PublishingHouse = PublishingHouse.Other });
            comicsService.Add(new Comics { Name = "Herfa", AuthorId = 3, IsSpecial = false, Order = 21, Pages = 48, PublishingHouse = PublishingHouse.Marvel });
            comicsService.Add(new Comics { Name = "Kraken", AuthorId = 1, IsSpecial = true, Order = 69, Pages = 932, PublishingHouse = PublishingHouse.DC });

            //Add new Tags:
            tagService.Add(new Tag { Name = "Rnd", ComicsId = 3});
            tagService.Add(new Tag { Name = "Cbc", ComicsId = 2 });
            tagService.Add(new Tag { Name = "Neo", ComicsId = 4 });
            tagService.Add(new Tag { Name = "Bexa", ComicsId = 5 });
            tagService.Add(new Tag { Name = "Lasd", ComicsId = 1 });
        }
        public void Print() {
            foreach (var aut in authorService.GetAll()) {
                Console.WriteLine($"Author: {aut.FirstName}");
                foreach (var com in comicsService.FindMany(x=>x.AuthorId == aut.Id)) {
                    Console.WriteLine($"-{com.Name}");
                    foreach (var item in tagService.FindMany(x=>x.ComicsId == com.Id)) {
                        Console.WriteLine($"--{item.Name}");
                    }
                }
                Console.WriteLine();
            }
        }
        public void DeleteAuthorById(int id) { authorService.Delete(id); }
        public void DeleteComicsById(int id) { comicsService.Delete(id); }
        public void DeleteTagById(int id) { tagService.Delete(id); }
        public void EditAuthorById(int id,Author author) { authorService.Edit(id, author); }
        public void EditComicsById(int id, Comics comics) { comicsService.Edit(id, comics); }
        public void EditTagById(int id, Tag tag) { tagService.Edit(id, tag); }
        public List<Author> FindManyAuthor() { return authorService.FindMany(x => DateTime.Now.Year - x.BirthDate.Year >= 52); }
        public List<Comics> FindManyComics() { return comicsService.FindMany(x => x.CreationDate.Year > 1950); }
        public List<Tag> FindManyTags() { return tagService.FindMany(x => x.Name.StartsWith('C')); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithService workWithService = new WorkWithService();
            workWithService.Print();
        }
    }
}
