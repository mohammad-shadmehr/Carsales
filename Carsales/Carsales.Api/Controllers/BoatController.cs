using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Carsales.Application.Boats;
using Carsales.Application.Boats.Dto;

namespace Carsales.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoatController : ControllerBase
    {
        private readonly ILogger<BoatController> _logger;
        private readonly IBoatService _boatService;

        public BoatController(ILogger<BoatController> logger, IBoatService boatService)
        {
            _logger = logger;
            _boatService = boatService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<List<BoatDto>> GetAll(string make, string model)
        {
            var input = new GetBoatListInput() { 
                Make = make,
                Model = model
            };

            return await _boatService.GetBoatList(input);
        }

        [HttpPost]
        [Route("AddOrUpdate")]
        public async Task AddOrUpdate(AddOrUpdateBoatInput input)
        {
            await _boatService.AddOrUpdateBoat(input);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _boatService.DeleteBoat(id);
        }
    }
}
