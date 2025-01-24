using System;
using System.Collections.Generic;

#nullable disable

namespace WebFinal.Models
{
    public partial class Marcas
    {
        public Marcas()
        {
            Modelos = new HashSet<Modelos>();
        }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }

        public virtual ICollection<Modelos> Modelos { get; set; }
    }
}
