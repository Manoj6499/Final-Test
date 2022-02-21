﻿using Restaurantapp.App_Start.restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Restaurantapp.App_Start.restaurant.itemrep;

namespace Restaurantapp.Controllers
{
    public class HomeController : Controller
    {
            RestaurantDbEntities db;
            public HomeController()
            {
                db = new RestaurantDbEntities();
            }
            public ActionResult Index()
            {
                CustomerRepository objCustomerRepository = new CustomerRepository();
                ItemRepository objItemRepository = new ItemRepository();
                PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();
                var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                    (objCustomerRepository.GetAllCustomers(), objItemRepository.GetAllItems(), objPaymentTypeRepository.GetAllPaymentType());
                return View(objMultipleModels);
            }
            [HttpGet]
            public JsonResult getItemUnitPrice(int itemId)
            {
                decimal? unitPrice = db.Items.Single(model => model.ItemID == itemId).Price;
                return Json(unitPrice, JsonRequestBehavior.AllowGet);
            }
            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
            [HttpPost]
            public JsonResult Index(OrderViewModel objOrderViewModel)
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }

        private class RestaurantDbEntities
        {
            internal readonly object Items;

            public RestaurantDbEntities()
            {
            }
        }
    }

    internal class PaymentTypeRepository
    {
        internal IEnumerable<SelectListItem> GetAllPaymentType()
        {
            throw new NotImplementedException();
        }
    }