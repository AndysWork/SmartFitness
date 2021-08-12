using Microsoft.EntityFrameworkCore.Query;
using SmartFitness.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitness.DataLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SmartFitnessDbContext _smartFitnessDbContext;
        private readonly DbSet<T> _db;

        public GenericRepository(SmartFitnessDbContext smartFitnessDbContext)
        {
            _smartFitnessDbContext = smartFitnessDbContext;
            _db = _smartFitnessDbContext.Set<T>();

        }
        public async Task Create(T entity)
        {
            await _db.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
        }

        public async Task<T> Find(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;
            if (includes != null)
            {
                query = includes(query);
            }
            return await query.FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> FindAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (includes != null)
            {
                query = includes(query);
            }
            if (orderby != null)
            {
                query = orderby(query);
            }
            return await query.ToListAsync();
        }

        public async Task<bool> IsExists(Expression<Func<T, bool>> expression = null)
        {
            IQueryable<T> query = _db;
            return await query.AnyAsync(expression);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
        }
    }
}
