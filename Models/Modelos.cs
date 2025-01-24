using System;
using System.Collections.Generic;

#nullable disable

namespace WebFinal.Models
{
    public partial class Modelos
    {
        public Modelos()
        {
            ModelosPaises = new HashSet<ModeloPaises>();
        }

        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public string NombreModelo { get; set; }

        public virtual Marcas IdMarcaNavigation { get; set; }
        public virtual ICollection<ModeloPaises> ModelosPaises { get; set; }
    }
}
