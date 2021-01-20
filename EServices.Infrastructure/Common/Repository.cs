using EServices.Core.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EServices.Infrastructure.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ServiceCatalogContext _database;
        private readonly DbSet<T> _dataSet;

        public Repository(ServiceCatalogContext database)
        {
            _database = database;
            _dataSet = _database.Set<T>();
        }

        public DbSet<T> DataSet => _dataSet;

        public async Task Delete(object id)
        {
            T existing = await _dataSet.FindAsync(id);
            _dataSet.Remove(existing);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dataSet.ToListAsync();
        }

        public async Task<T> GetById(object id)
        {
            return await _dataSet.FindAsync(id);
        }


        public async Task<List<T>> Get(Expression<Func<T,bool>> whereCluase, params Expression<Func<T, object>>[] includes)
        {
            var expr = _dataSet.Where(whereCluase);

            if(includes != null && includes.Length > 0)
            {
               foreach(var inc in includes)
                {
                    expr = expr.Include(inc);
                }
            }

            return await expr.ToListAsync();
        }

        public async Task Insert(T obj)
        {
            await _dataSet.AddAsync(obj);
        }

        public async Task Save()
        {
            await _database.SaveChangesAsync();
        }
    }
}
