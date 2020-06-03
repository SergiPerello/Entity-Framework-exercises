using System;
using System.Collections.Generic;

namespace EF_Campeonato.Models
{
    public partial class Partidos
    {
        public int Id { get; set; }
        public int Idjugador { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Jugador IdjugadorNavigation { get; set; }
    }
}
