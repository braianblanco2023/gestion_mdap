using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFinal.Models;

namespace WebFinal.Repositorios
{
    public class ModeloRepository
    {
        private readonly PracticasContext _context;
        public ModeloRepository(PracticasContext context)
        {
            _context = context;
        }
        public void Add(Models.Modelos modelo)
        {
            _context.Add(modelo);
        }
    }
}
