using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int NumberPages { get; set; }
        public Categoria Categoria { get; set; }
    }
}
