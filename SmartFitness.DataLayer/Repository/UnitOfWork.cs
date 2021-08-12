using SmartFitness.DataLayer.Contracts;
using SmartFitness.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitness.DataLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SmartFitnessDbContext _smartFitnessDbContext;
        private IGenericRepository<User> _users;

        public UnitOfWork(SmartFitnessDbContext smartFitnessDbContext)
        {
            _smartFitnessDbContext = smartFitnessDbContext;
        }
        public IGenericRepository<User> Users => _users ?? new GenericRepository<User>(_smartFitnessDbContext);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool dispose)
        {
            if (dispose) _smartFitnessDbContext.Dispose();
        }
        public async Task Save()
        {
            await _smartFitnessDbContext.SaveChangesAsync();
        }
    }
}
