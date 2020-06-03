using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Comic> Comics { get; set; }
    }
}
