using DotNet5RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5RepositoryPattern.Configuration
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employee { get; }
        Task CompleteAsync();
        void Dispose();
    }
}
