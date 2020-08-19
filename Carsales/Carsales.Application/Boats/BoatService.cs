using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.Application.Boats.Dto;
using Carsales.Core;
using Carsales.EntityFrameworkCore.EntityFrameworkCore.Repositories;
using Carsales.EntityFrameworkCore.Repositories;

namespace Carsales.Application.Boats
{
    public class BoatService: CarsalesServiceBase<Boat, BoatRepository>, IBoatService
    {
        private readonly IRepository<Boat> _repository;

        public BoatService(BoatRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task AddOrUpdateBoat(AddOrUpdateBoatInput input)
        {
            if (input.Id.HasValue)
            {
                var boat = await _repository.GetAsync(input.Id.Value);

                if (boat == null)
                {
                    throw new Exception($"No boat was found with Id of {input.Id}");
                }

                boat.Make = input.Make;
                boat.Model = input.Model;
                boat.Segment = input.Segment;
                boat.Category = input.Category;

                await _repository.UpdateAsync(boat);
            }
            else {
                var boat = new Boat()
                {
                    Make = input.Make,
                    Model = input.Model,
                    Segment = input.Segment,
                    Category = input.Category
                };

                await _repository.InsertAsync(boat);
            }
        }

        public async Task DeleteBoat(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<BoatDto>> GetBoatList(GetBoatListInput input)
        {
            var boats = await _repository.GetAll()
                                .Where(boat => (string.IsNullOrEmpty(input.Make) ? true : boat.Make.Contains(input.Make)) &&
                                               (string.IsNullOrEmpty(input.Model) ? true : boat.Model.Contains(input.Model)))
                                .Select(boat => new BoatDto() { Id = boat.Id, Make = boat.Make, Model = boat.Model, Category = boat.Category, Segment = boat.Segment })
                                .ToListAsync();

            return boats;
        }
    }
}
