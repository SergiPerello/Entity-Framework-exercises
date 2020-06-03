using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    class CategoriaCRUD
    {
        public static void Create(string[] data)
        {
            using (var context = new ComicContext())
            {
                Categoria a = new Categoria()
                {
                    Name = data[0],
                    Description = data[1]
                };
                context.Categories.Add(a);
                context.SaveChanges();
            }
        }
        public static void Read()
        {
            using (var context = new ComicContext())
            {
                foreach (Categoria a in context.Categories)
                {
                    Console.WriteLine($"{a.Id} - {a.Name} - {a.Description}");
                }
            }
        }
        public static void Update(int id, string[] data)
        {
            using (var context = new ComicContext())
            {
                Categoria a = context.Categories.Find(id);
                if (a != null)
                {
                    if (data[0] != "") a.Name = data[0];
                    if (data[1] != "") a.Description = data[1];
                    context.SaveChanges();
                }
            }
        }
        public static void Delete(int id)
        {
            using (var context = new ComicContext())
            {
                Categoria a = context.Categories.Find(id);
                if (a != null)
                {
                    context.Categories.Remove(a);
                    context.SaveChanges();
                }
            }
        }
    }
}
