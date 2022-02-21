using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace Restaurantapp.App_Start.restaurant
{
    public class PaymentTypeRepository
    {
        public class PaymentTypeRepository
        {
            RestaurantDbEntities db;
            public PaymentTypeRepository()


            {
                db = new RestaurantDbEntities();
            }
            public IEnumerable<SelectListItem> GetAllPaymentType()
            {
                IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
                objSelectListItems = (from obj in db.PaymentTypes
                                      select new SelectListItem()
                                      {
                                          Text = obj.PaymentTypeName,
                                          Value = obj.PaymentTypeId.ToString(),
                                          Selected = true

                                      }).ToList();
                return objSelectListItems;
            }
}