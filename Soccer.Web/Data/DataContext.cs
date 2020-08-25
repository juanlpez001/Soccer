using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soccer.Web.Data.Entities;

namespace Soccer.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base (options)
        {

        }

        public DbSet<TeamEntity> Teams { get; set; }
    }
}
