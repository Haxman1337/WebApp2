using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string Id { get; set; }

        [Required (ErrorMessage = "Не указано имя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [RegularExpression(@"[A-Za-zА-Яа-я\s]{3,}", ErrorMessage = "Недопустимые символы")]
        public string Name { get; set; }

        public string Birdate { get; set; }

        public string Regdate { get; set; }

        [Required(ErrorMessage = "Не указана почта")]
        [EmailAddress, ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        public string Phone { get; set; }
    }
}