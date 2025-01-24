using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFinal.Models;

namespace WebFinal.Repositorios
{
    public class PaisRepository
    {
        private readonly PracticasContext _context;
        public PaisRepository(PracticasContext context)
        {
            _context = context;
        }
        public void Add(Models.PaisComercializacion pais)
        {
            _context.Add(pais);
        }
    }
}
