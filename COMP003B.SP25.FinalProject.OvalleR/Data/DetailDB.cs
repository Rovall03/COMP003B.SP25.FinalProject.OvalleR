using COMP003B.SP25.FinalProject.OvalleR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.OvalleR.Data
{
    public class DetailDB : DbContext
    {
        public DetailDB(DbContextOptions<DetailDB> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}