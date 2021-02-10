using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
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
        /*
        [Required(ErrorMessage = "Не указан id")]
        //[RegularExpression(@"^\d+$", ErrorMessage = "Некорректный id")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        //[RegularExpression(@"^[A-Za-zFА-Яа-я]+$", ErrorMessage = "Некорректное имя")]
        //[StringLength(50, MinimumLength = 0, ErrorMessage = "Длина строки не может быть более 50 символов")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указана дата рождения")]
        //[RegularExpression(@"\d{2}[.]\d{2}[.]\d{4}", ErrorMessage = "Некорректная дата")]
        public string Birdate { get; set; }
        [Required(ErrorMessage = "Не указана дата регистрации")]
       // [RegularExpression(@"\d{2}[.]\d{2}[.]\d{4}", ErrorMessage = "Некорректная дата")]
        public string Regdate { get; set; }
        [Required(ErrorMessage = "Не указана почта")]
      //  [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес почты")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указан телефон")]
     //   [RegularExpression(@"^[+][7][(]\d{3}[)]\d{3}[-]\d{2}[-]\d{2}", ErrorMessage = "Некорректный номер телефона")]
        public string Phone { get; set; }*/

        
        public string Id { get; set; }

        [Required]
        [Display(Name = "ФИО")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Za-zFА-Яа-я ]+$", ErrorMessage = "Некорректное имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Дата рож.")]
        [DataType(DataType.Date)]
        public string Birdate { get; set; }

        [Required]
        [Display(Name = "Дата рег.")]
        [DataType(DataType.Date)]
        public string Regdate { get; set; }

        [Required]
        [Display(Name = "Почта")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[+][7][(]\d{3}[)]\d{3}[-]\d{2}[-]\d{2}", ErrorMessage = "Некорректный номер телефона")]
        public string Phone { get; set; }
    }
}