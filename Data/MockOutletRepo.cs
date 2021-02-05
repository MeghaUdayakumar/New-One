using System.Collections.Generic;
using WebsiteAPI.Models;

namespace WebsiteAPI.Data
{
    public class MockOutletRepo : IOutletRepo
    {
        //implementing the interface Methods
        public void CreateOutlet(Outlet outlets)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOutlet(Outlet outlets)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Outlet> GetAllOutlets()
        {
            var Outlets= new List<Outlet>
            {
                new Outlet{id=1, OutletName="NNN"},
                new Outlet{id=2, OutletName="MMM"}

            };
            return Outlets;
        }

        public Outlet GetOutletById(int id)
        {
            return new Outlet{id=1, OutletName="NNN"};

        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOutlet(Outlet outlets)
        {
            throw new System.NotImplementedException();
        }
    }
}