using SmartFitness.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitness.DataLayer.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<User> Users { get; }
        Task Save();
    }
}
