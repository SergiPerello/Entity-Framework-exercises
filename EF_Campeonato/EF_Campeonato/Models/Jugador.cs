using System;
using System.Collections.Generic;

namespace EF_Campeonato.Models
{
    public partial class Jugador
    {
        public Jugador()
        {
            Partidos = new HashSet<Partidos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Puntos { get; set; }
        public string Alias { get; set; }

        public virtual ICollection<Partidos> Partidos { get; set; }
    }
}
