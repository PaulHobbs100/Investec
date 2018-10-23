using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany
{
    public class CustomerOrders
    {
        //private int v1;
        //private object v2;
        //private DateTime dateTime;
        //private string v3;
        //private object v4;
        //private object v5;
        //private object v6;

        //public CustomerOrders(int v1, object v2, DateTime dateTime, string v3, object v4, object v5, object v6)
        //{
        //    this.v1 = v1;
        //    this.v2 = v2;
        //    this.dateTime = dateTime;
        //    this.v3 = v3;
        //    this.v4 = v4;
        //    this.v5 = v5;
        //    this.v6 = v6;
        //}

        public int CustomerId { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public double VAT { get; set; }

    }
}
