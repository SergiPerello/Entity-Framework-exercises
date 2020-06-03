using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    class ComicCRUD
    {
        public static void Create(string[] data)
        {
            using (var context = new ComicContext())
            {
                Comic a = new Comic()
                {
                    Title = data[0],
                    Description = data[1],
                    Date = DateTime.Parse(data[2]),
                    NumberPages = int.Parse(data[3])
                };
                context.Comics.Add(a);
                context.SaveChanges();
            }
        }
        public static void Read()
        {
            using (var context = new ComicContext())
            {
                foreach (Comic a in context.Comics)
                {
                    Console.WriteLine($"{a.Id} - {a.Title} - " +
                        $"{a.Description} - {a.Date} - {a.NumberPages}");
                }
            }
        }
        public static void Update(int id, string[] data)
        {
            using (var context = new ComicContext())
            {
                Comic a = context.Comics.Find(id);
                if (a != null)
                {
                    if (data[0] != "") a.Title = data[0];
                    if (data[1] != "") a.Description = data[1];
                    if (data[2] != "") a.Date = DateTime.Parse(data[2]);
                    if (data[3] != "") a.NumberPages = int.Parse(data[3]);
                    context.SaveChanges();
                }
            }
        }
        public static void Delete(int id)
        {
            using (var context = new ComicContext())
            {
                Comic a = context.Comics.Find(id);
                if (a != null)
                {
                    context.Comics.Remove(a);
                    context.SaveChanges();
                }
            }
        }
    }
}
