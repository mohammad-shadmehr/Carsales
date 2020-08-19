using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.Application.Cars.Dto;
using Carsales.Core;
using Carsales.EntityFrameworkCore.EntityFrameworkCore.Repositories;
using Carsales.EntityFrameworkCore.Repositories;

namespace Carsales.Application.Cars
{
    public class CarService: CarsalesServiceBase<Car, CarRepository>, ICarService
    {
        private readonly IRepository<Car> _repository;

        public CarService(CarRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task AddOrUpdateCar(AddOrUpdateCarInput input)
        {
            if (input.Id.HasValue)
            {
                var car = await _repository.GetAsync(input.Id.Value);

                if (car == null)
                {
                    throw new Exception($"No Car was found with Id of {input.Id}");
                }

                car.BodyType = input.BodyType;
                car.Make = input.Make;
                car.Engine = input.Engine;
                car.Model = input.Model;
                car.NumberOfDoors = input.NumberOfDoors;
                car.NumberOfWheels = input.NumberOfWheels;

                await _repository.UpdateAsync(car);
            }
            else {
                var car = new Car()
                {
                    BodyType = input.BodyType,
                    Make = input.Make,
                    Engine = input.Engine,
                    Model = input.Model,
                    NumberOfDoors = input.NumberOfDoors,
                    NumberOfWheels = input.NumberOfWheels
            };

                await _repository.InsertAsync(car);
            }
        }

        public async Task DeleteCar(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<CarDto>> GetCarList(GetCarListInput input)
        {
            var cars = await _repository.GetAll()
                                .Where(car => (string.IsNullOrEmpty(input.Model) ? true : car.Model.Contains(input.Model)) &&
                                               (string.IsNullOrEmpty(input.Make) ? true : car.Make.Contains(input.Make)))
                                .Select(car => new CarDto() { 
                                                                Id = car.Id, 
                                                                Make = car.Make, 
                                                                Model = car.Model, 
                                                                BodyType = car.BodyType, 
                                                                NumberOfDoors = car.NumberOfDoors, 
                                                                NumberOfWheels = car.NumberOfWheels,
                                                                Engine = car.Engine
                                })
                                .ToListAsync();

            return cars;
        }
    }
}
