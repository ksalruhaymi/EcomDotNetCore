using System;
using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;

namespace Ecom.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        public readonly ApplicationDbContext _context;
        public ICategoryRepository CategoryRepository {get; }
        public IProductRepository ProductRepository { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(_context);
            ProductRepository = new ProductRepository(_context);
        }
    }
}

