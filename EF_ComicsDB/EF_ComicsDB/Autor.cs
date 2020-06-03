using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Comic_Autor> Roles { get; set; }
    }
}
