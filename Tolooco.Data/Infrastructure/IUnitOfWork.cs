using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolooco.Data.Repositories;

namespace Tolooco.Data.Infrastructure
{
    public interface IUnitOfWork<TContext>:IDisposable where TContext:DbContext
    {
        UserRepository UserRepository { get; }
        void Commit();

        Task<int> CommitAsync();
    }
}
