using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Carsales.Application.Cars.Dto;

namespace Carsales.Application.Cars
{
    public interface ICarService
    {
        Task<List<CarDto>> GetCarList(GetCarListInput input);
        Task AddOrUpdateCar(AddOrUpdateCarInput input);
        Task DeleteCar(int id);
    }
}
