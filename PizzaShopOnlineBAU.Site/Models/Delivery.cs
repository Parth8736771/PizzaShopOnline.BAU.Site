using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace PizzaShopOnlineBAU.Site.Models
{
    public class Delivery
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Telephone Number")]
        public int Telephone { get; set; }

    }
}
