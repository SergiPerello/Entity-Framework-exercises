using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Aeropuerto
{
    class Piloto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Sueldo { get; set; }
        public List<Vuelo> Vuelos { get; set; }
    }
}
