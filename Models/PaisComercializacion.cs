using System;
using System.Collections.Generic;

#nullable disable

namespace WebFinal.Models
{
    public partial class PaisComercializacion
    {
        public PaisComercializacion()
        {
            ModelosPaises = new HashSet<ModeloPaises>();
        }

        public int IdPais { get; set; }
        public string NombrePais { get; set; }

        public virtual ICollection<ModeloPaises> ModelosPaises { get; set; }
    }
}
