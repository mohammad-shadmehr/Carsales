using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.Core;

namespace Carsales.EntityFrameworkCore.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        Task<List<T>> GetAllListAsync();
        Task<T> GetAsync(int id);
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
    }
}
