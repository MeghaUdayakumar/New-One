using Microsoft.EntityFrameworkCore;
using WebsiteAPI.Models;

namespace WebsiteAPI.Data
{
    public class OutletContext : DbContext
    {
        //Creating DbContext for Outlet
        public OutletContext(DbContextOptions<OutletContext> options) : base(options)
        {
            
        }
        //declaring Outlet to DbSet
        public DbSet<Outlet> Outlets { get; set; }
        
        
    }
}