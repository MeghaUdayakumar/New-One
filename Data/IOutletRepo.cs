using System.Collections.Generic;
using WebsiteAPI.Models;

namespace WebsiteAPI.Data
{
    //Creating interface for Outlet
    public interface IOutletRepo
    {
        bool SaveChanges();
        
        //defining the methods
         IEnumerable<Outlet> GetAllOutlets();
         Outlet GetOutletById(int id);
         
         void CreateOutlet(Outlet outlets);
         void UpdateOutlet(Outlet outlets);
         
         void DeleteOutlet(Outlet outlets);
    }
}