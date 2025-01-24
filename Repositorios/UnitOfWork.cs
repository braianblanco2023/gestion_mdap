using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFinal.Models;

namespace WebFinal.Repositorios
{
    public class UnitOfWork
    {
        private MarcaRepository _marcaRepository;
        private ModeloRepository _modeloRepository;
        private PaisRepository _paisRepository;
        private PracticasContext _context;
        public UnitOfWork(PracticasContext context)
        {
            _context = context;
        }
        public MarcaRepository MarcaRepo()
        {
            _marcaRepository = new MarcaRepository(_context);
            return _marcaRepository;
        }
        public ModeloRepository ModeloRepo()
        {
            _modeloRepository = new ModeloRepository(_context);
            return _modeloRepository;
        }
        public PaisRepository PaisRepo()
        {
            _paisRepository = new PaisRepository(_context);
            return _paisRepository;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
