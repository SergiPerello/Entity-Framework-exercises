using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Aeropuerto
{
    class Vuelo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("Avion")]
        public int IdAvion { get; set; }
        public int IdPiloto { get; set; }
        public Avion Avion { get; set; }
        public Piloto Piloto { get; set; }
    }
}
