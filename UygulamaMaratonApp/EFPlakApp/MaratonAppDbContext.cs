using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonApp.DAL.Context
{
    public class MaratonAppDbContext:DbContext
    {





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=HAKANPC;Initial Catalog=DietProjectDb;Integrated Security=true;Encrypt=False");
        }
    }
}
