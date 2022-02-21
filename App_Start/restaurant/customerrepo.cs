using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurantapp.App_Start.restaurant
{
    public class CustomerRepository
    {
        public class CustomerRepository
        {
            RestaurantDbEntities db;

            public CustomerRepository()
            {
                db = new RestaurantDbEntities();
            }
            public IEnumerable<SelectListItem> GetAllCustomers()
            {
                IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
                objSelectListItems = (from obj in db.Customers
                                      select new SelectListItem()
                                      {
                                          Text = obj.Name,
                                          Value = obj.CustomerID.ToString(),
                                          Selected = true

                                      }).ToList();
                return objSelectListItems;
            }
}

        internal IEnumerable<SelectListItem> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
