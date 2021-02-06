using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class ViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }
    }
}