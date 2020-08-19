using Carsales.Core;
using Carsales.EntityFrameworkCore.Repositories;

namespace Carsales.Application
{
    public abstract class CarsalesServiceBase<TEntity, TRepository> where TEntity : class, IEntity where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public CarsalesServiceBase(TRepository repository)
        {
            _repository = repository;
        }
    }
}
