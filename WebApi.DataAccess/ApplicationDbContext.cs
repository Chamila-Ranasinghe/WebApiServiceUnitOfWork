using Microsoft.EntityFrameworkCore;
using System;
using WebApi.DataAccess.Models;

namespace WebApi.DataAccess
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        /// <summary>
        /// virtual so tht can be override the context 
        /// </summary>
        public virtual DbSet<User> Users { get; set; }
    }
}
