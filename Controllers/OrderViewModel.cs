﻿using System.Collections.Generic;

namespace Restaurantapp.Controllers
{
    public class OrderViewModel
    {
        {
            public int OrderId { get; set; }
            public int PaymentTypeId { get; set; }
            public int CustomerId { get; set; }
            public string OrderNumber { get; set; }
            public DateTime OrderDate { get; set; }
            public decimal FinalTotal { get; set; }
            public IEnumerable<OrderDetailViewModel> ListOfOrderDetailViewModel { get; set; }
        }
    }
}