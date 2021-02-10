using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp2.Models
{
    [Serializable]
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

        [Required]
        [Display(Name = "Клиент")]
        public string Customer { get; set; }
        [Required]
        [Display(Name = "Дата рег.")]
        [DataType(DataType.Date)]
        public string Regdate { get; set; }

        [Required]
        [Display(Name = "Сумма")]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d{1,}[.]\d{2}$", ErrorMessage = "Некорректная сумма")]
        public string Value { get; set; }
        [Required]
        [Display(Name = "Статус")]
        [DataType(DataType.Text)]
        public string Status { get; set; }
    }
}