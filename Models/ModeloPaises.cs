using System;
using System.Collections.Generic;

#nullable disable

namespace WebFinal.Models
{
    public partial class ModeloPaises
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public int IdPais { get; set; }

        public virtual Modelos IdModeloNavigation { get; set; }
        public virtual PaisComercializacion IdPaisNavigation { get; set; }
    }
}
