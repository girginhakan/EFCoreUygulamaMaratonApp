using EFPlakApp;
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

       public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Album> Albumler { get; set; }
        public DbSet<Sanatci> Sanatcilar { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=HAKANPC;Initial Catalog=AlbumSanatciDb;Integrated Security=true;Encrypt=False");
        }
    }
}
