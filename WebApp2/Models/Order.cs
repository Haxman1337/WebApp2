using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class Order
    {
        public Order() { }
        public Order(string id, string customer, string regdate, string value, string status)
        {
            Id = id;
            Customer = customer;
            Regdate = regdate;
            Value = value;
            Status = status;
        }
        public string Id { get; set; }
        public string Customer { get; set; }
        public string Regdate { get; set; }
        public string Value { get; set; }
        public string Status { get; set; }
    }
}