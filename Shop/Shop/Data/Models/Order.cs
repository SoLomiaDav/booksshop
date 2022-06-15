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
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина імені більше 20 символів")]
        public string name { get; set; }

        [Display(Name = "Прізвище")]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина прізвища більше 20 символів")]
        public string surname { get; set; }

        [Display(Name = "Адреса")]
        [StringLength(50)]
        [Required(ErrorMessage = "Довжина адреси більше 50 символів")]
        public string adress { get; set; }

        [Display(Name = "Номер телефону")]
        [StringLength(13)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Довжина номеру більше 13 символів")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        [Required(ErrorMessage = "Довжина email більше 40 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
