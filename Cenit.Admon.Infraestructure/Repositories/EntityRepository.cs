using Cenit.Admon.Domain.Services.IRepository;
using Cenit.Admon.Infraestructure.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenit.Admon.Infraestructure.Repositories
{
    public class EntityRepository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseService _context;
        private readonly DbSet<T> _dbSet;

        public EntityRepository(DatabaseService context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
