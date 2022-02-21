using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Restaurantapp.Models
{
    public class RestaurantDbEntities
    {
        public RestaurantDbEntities()
           : base("name=RestaurantDbEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        [Serializable]
        private class UnintentionalCodeFirstException : Exception
        {
            public UnintentionalCodeFirstException()
            {
            }

            public UnintentionalCodeFirstException(string message) : base(message)
            {
            }

            public UnintentionalCodeFirstException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected UnintentionalCodeFirstException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }

        public class DbModelBuilder
        {
        }

        public class DbSet<T>
        {
        }
    }
}