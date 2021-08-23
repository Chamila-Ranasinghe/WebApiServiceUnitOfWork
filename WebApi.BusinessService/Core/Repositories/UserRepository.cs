using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.BusinessService.Core.IRepositories;
using WebApi.DataAccess;
using WebApi.DataAccess.Models;

namespace WebApi.BusinessService.Core.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public UserRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        { }

        public override async Task<IEnumerable<User>> All()
        {
            try
            {
                return await dbSet.ToListAsync();

            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(UserRepository));
                return new List<User>();
            }
        }

        public override async Task<bool> Update(User entity)
        {
            try
            {
                var existingUser = await dbSet.Where(x => x.UserId == entity.UserId).FirstOrDefaultAsync();

                if (existingUser != null)
                {
                    existingUser.FirstName = entity.FirstName;
                    existingUser.LastName = entity.LastName;
                    existingUser.Email = entity.Email;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Update method error", typeof(UserRepository));
                return false;
            }
        }

        public override async Task<bool> Delete()
        {
            return base.Delete(entity);
        }
    }
}
