using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Carsales.Application.Cars;
using Carsales.Application.Cars.Dto;

namespace Carsales.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;

        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<List<CarDto>> GetAll(string make, string model)
        {
            var input = new GetCarListInput() { 
                Model = model,
                Make = make
            };

            return await _carService.GetCarList(input);
        }

        [HttpPost]
        [Route("AddOrUpdate")]
        public async Task AddOrUpdate(AddOrUpdateCarInput input)
        {
            await _carService.AddOrUpdateCar(input);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _carService.DeleteCar(id);
        }
    }
}
