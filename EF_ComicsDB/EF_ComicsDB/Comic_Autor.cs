using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    public class Comic_Autor
    {
        public int Id { get; set; }
        public Comic Comic { get; set; }
        public Autor Autor { get; set; }
        public string Rol { get; set; }
    }
}
