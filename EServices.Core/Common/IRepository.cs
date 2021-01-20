using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EServices.Core.Common
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> DataSet { get; }
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task Insert(T obj);
        Task Delete(object id);

        Task<List<T>> Get(Expression<Func<T, bool>> whereCluase, params Expression<Func<T, object>>[] includes);
        Task Save();
    }
}
