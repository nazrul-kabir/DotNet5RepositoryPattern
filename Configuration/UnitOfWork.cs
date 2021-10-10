using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using DotNet5RepositoryPattern.Configuration;
using DotNet5RepositoryPattern.Data;
using DotNet5RepositoryPattern.Repository;

namespace DotNet5RepositoryPattern.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DBContext _context;
        private readonly ILogger _logger;

        public IEmployeeRepository Employee { get; private set; }

        public UnitOfWork(DBContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Employee = new EmployeeRepository(context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
