using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class WebApplication4Context : DbContext
    {
        public WebApplication4Context (DbContextOptions<WebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication4.Models.book> book { get; set; } = default!;

        public DbSet<WebApplication4.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<WebApplication4.Models.orders> orders { get; set; }
        public DbSet<WebApplication4.Models.report> report { get; set; }
    }
}
