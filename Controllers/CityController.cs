using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitofWorkRepositoryCRUDPattern.Interfaces;
using UnitofWorkRepositoryCRUDPattern.Models;

namespace UnitofWorkRepositoryCRUDPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CityController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await _unitOfWork.CityRepository.GetCitiesAsync();
            return Ok(cities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var city = await _unitOfWork.CityRepository.GetCityById(id);
            return Ok(city);
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(City city)
        {
            _unitOfWork.CityRepository.AddCity(city);
            await _unitOfWork.SaveChangesAsync();
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCity(int id, City city)
        {
            _unitOfWork.CityRepository.UpdateCity(id, city);
            await _unitOfWork.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteCity(int id)
        {
            _unitOfWork.CityRepository.DeleteCity(id);
            await _unitOfWork.SaveChangesAsync();
            return Ok(id);
        }

    }
}
