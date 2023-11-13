using System.Net.Http.Headers;
using UnitofWorkRepositoryCRUDPattern.Models;

namespace UnitofWorkRepositoryCRUDPattern.Interfaces
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City> GetCityById(int id);

        void UpdateCity(int id, City city);
        void AddCity(City city);
        void DeleteCity(int CityId);
    }
}
