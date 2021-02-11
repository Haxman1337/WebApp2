using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApp2.Models
{
    [Serializable]
    public class ViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }
    }
}