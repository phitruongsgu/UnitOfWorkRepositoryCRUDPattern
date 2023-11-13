
using Microsoft.EntityFrameworkCore;
using UnitofWorkRepositoryCRUDPattern.Data;
using UnitofWorkRepositoryCRUDPattern.Interfaces;
using UnitofWorkRepositoryCRUDPattern.Models;

namespace UnitofWorkRepositoryCRUDPattern.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;
        public CityRepository(DataContext context)
        {
            this._context = context;
        }
        public void AddCity(City city)
        {
            _context.Cities.Add(city);
        }

        public void DeleteCity(int CityId)
        {
            var city = _context.Cities.Find(CityId);
            _context.Cities.Remove(city);
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> GetCityById(int id)
        {
            return await _context.Cities.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public void UpdateCity(int id, City city)
        {
            var cityfindID = _context.Cities.Find(id);
            if(cityfindID != null)
            {
                cityfindID.Name = city.Name;
            }
        }
    }
}
