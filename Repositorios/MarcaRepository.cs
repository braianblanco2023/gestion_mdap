using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFinal.Models;

namespace WebFinal.Repositorios
{
    public class MarcaRepository
    {
        private readonly PracticasContext _context;
        public MarcaRepository(PracticasContext context)
        {
            _context = context;
        }
        public void Add (Models.Marcas marca)
        {
            _context.Add(marca);
        }
        public int GetId(Models.Marcas marca)
        {
            _context.Add(marca);
            int id = 0;
            return id;
        }
    }
}
