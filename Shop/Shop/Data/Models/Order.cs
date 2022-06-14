using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Ім'я")]
        [StringLength(2)]
        [Required(ErrorMessage = "Довжина імені менше 2 символів")]
        public string name { get; set; }

        [Display(Name = "Прізвище")]
        [StringLength(5)]
        [Required(ErrorMessage = "Довжина призвища менше 5 символів")]
        public string surname { get; set; }

        [Display(Name = "Адреса")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина адреси менше 15 символів")]
        public string adress { get; set; }

        [Display(Name = "Номер телефону")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Довжина номеру менше 10 символів")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина email менше 10 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
