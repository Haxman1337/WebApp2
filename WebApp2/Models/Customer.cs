using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    [Serializable]
    public class Customer
    {
        public Customer() { }
        public Customer(string id, string name, string birdate, string regdate, string email, string phone)
        {
            Id = id;
            Name = name;
            Birdate = birdate;
            Regdate = regdate;
            Email = email;
            Phone = phone;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birdate { get; set; }
        public string Regdate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}