using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebApp2.Models;

namespace WebApp2.Tools
{
    public static class XmlWorks3
    {
        public static XDocument xDoc;
        public static List<Customer> Customers = new List<Customer>();
        public static List<Order> Orders = new List<Order>();
        static string pathToXdoc;

        public static void Init(string path)
        {
            xDoc = XDocument.Load(path);
            pathToXdoc = path;
            foreach(XElement el in xDoc.Element("root").Element("Customers").Elements("Customer"))
            {
                Customer c = new Customer(el.Attribute("Id").Value, el.Attribute("Name").Value, el.Attribute("Birdate").Value, el.Attribute("Regdate").Value, el.Attribute("Email").Value, el.Attribute("Phone").Value);
                Customers.Add(c);
            }
            foreach (XElement el in xDoc.Element("root").Element("Orders").Elements("Order"))
            {
                Order o = new Order(el.Attribute("Id").Value, el.Attribute("Customer").Value, el.Attribute("Regdate").Value, el.Attribute("Value").Value, el.Attribute("Status").Value);
                Orders.Add(o);
            }
        }

        public static void Save()
        {
            xDoc.Save(pathToXdoc);
        }
    }
}