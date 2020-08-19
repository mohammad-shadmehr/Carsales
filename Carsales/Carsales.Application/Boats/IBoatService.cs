using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Carsales.Application.Boats.Dto;

namespace Carsales.Application.Boats
{
    public interface IBoatService
    {
        Task<List<BoatDto>> GetBoatList(GetBoatListInput input);
        Task AddOrUpdateBoat(AddOrUpdateBoatInput input);
        Task DeleteBoat(int id);
    }
}
