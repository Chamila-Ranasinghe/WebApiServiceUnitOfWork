using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.BusinessService.Core.IRepositories;

namespace WebApi.BusinessService.Core
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task CompleteAsync();
    }
}
