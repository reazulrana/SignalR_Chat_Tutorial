using Microsoft.EntityFrameworkCore;
using SignalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.DAL
{
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {


        }
        public DbSet<UsersAccount> UsersAccounts { get; set; }
    }
}
