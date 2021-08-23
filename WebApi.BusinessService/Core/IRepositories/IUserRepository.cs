using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.DataAccess.Models;

namespace WebApi.BusinessService.Core.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        ////can declare the customize methods
        ////Task<string> GetFirstNameAndLastName(string Id);
    }
}
