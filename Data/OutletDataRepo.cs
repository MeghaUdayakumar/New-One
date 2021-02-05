using System;
using System.Collections.Generic;
using System.Linq;
using WebsiteAPI.Models;

namespace WebsiteAPI.Data
{
    //iplementing the interface by converting into real data
    public class OutletDataRepo : IOutletRepo
    {
        private readonly OutletContext _context;

        //passing DbContext to OutletDataRepo
        public OutletDataRepo(OutletContext context)
        {
            _context = context;
        }

        //Creating the outlet 
        public void CreateOutlet(Outlet outlets)
        {
            //validation check
            if(outlets == null)
            {
                throw new ArgumentNullException(nameof(outlets));
            }
            _context.Outlets.Add(outlets);
        }

        //Delete Method
        public void DeleteOutlet(Outlet outlets)
        {
            //validation check
             if(outlets == null)
            {
                throw new ArgumentNullException(nameof(outlets));
            }
            _context.Outlets.Remove(outlets);
        }

        // List of Outlets
        public IEnumerable<Outlet> GetAllOutlets()
        {
            return _context.Outlets.ToList();
        }

        public Outlet GetOutletById(int id)
        {
            //getting the id
            return _context.Outlets.FirstOrDefault(p => p.id ==id);
        }
        //Save changes 
        public bool SaveChanges()
        {
            return(_context.SaveChanges()>=0);
        }

        // update method
        public void UpdateOutlet(Outlet outlets)
        {
            //Nothing
        }
    }
}