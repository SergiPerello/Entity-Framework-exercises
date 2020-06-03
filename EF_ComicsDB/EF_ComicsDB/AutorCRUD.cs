using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    class AutorCRUD
    {
        public static void Create(string[] data)
        {
            using (var context = new ComicContext())
            {
                Autor a = new Autor()
                {
                    Name = data[0],
                    Nationality = data[1],
                    BirthDate = DateTime.Parse(data[2])
                };
                context.Autors.Add(a);
                context.SaveChanges();
            }
        }
        public static void Read()
        {
            using (var context = new ComicContext())
            {
                foreach (Autor a in context.Autors)
                {
                    Console.WriteLine($"{a.Id} - {a.Name} - {a.Nationality} - {a.BirthDate}");
                }
            }
        }
        public static void Update(int id, string[] data)
        {
            using (var context = new ComicContext())
            {
                Autor a = context.Autors.Find(id);
                if (a != null)
                {
                    if (data[0] != "") a.Name = data[0];
                    if (data[1] != "") a.Nationality = data[1];
                    if (data[2] != "") a.BirthDate = DateTime.Parse(data[2]);
                    context.SaveChanges();
                }
            }
        }
        public static void Delete(int id)
        {
            using (var context = new ComicContext())
            {
                Autor a = context.Autors.Find(id);
                if (a != null)
                {
                    context.Autors.Remove(a);
                    context.SaveChanges();
                }
            }
        }
    }
}
