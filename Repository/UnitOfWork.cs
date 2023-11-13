using Microsoft.EntityFrameworkCore;
using UnitofWorkRepositoryCRUDPattern.Data;
using UnitofWorkRepositoryCRUDPattern.Interfaces;

namespace UnitofWorkRepositoryCRUDPattern.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            this._context = context;
        }
        public ICityRepository CityRepository => new CityRepository(_context);

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
