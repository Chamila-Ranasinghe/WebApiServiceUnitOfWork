using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.BusinessService.Core
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        Task<T> GetById(string id);

        Task<bool> Add(T entity);

        Task<bool> Delete(T entity);

        Task<bool> Update(T entity);

         
    }
}
