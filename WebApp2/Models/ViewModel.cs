using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApp2.Models
{
    public class ViewModel
    {
        [Required]
        public List<Customer> Customers { get; set; }
        [Required]
        public List<Order> Orders { get; set; }
    }
}