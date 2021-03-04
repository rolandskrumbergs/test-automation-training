using System;
using System.ComponentModel.DataAnnotations;

namespace TestAutomationTraining.Models
{
    public class Order
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [Display(Prompt = "Ievadi grāmatu daudzumu", Name = "Grāmatu skaits")]
        [Range(0, 100)]
        public int AmountOfBooks { get; set; }

        [Required]
        [Display(Prompt = "Ievadi DVD daudzumu", Name = "DVD skaits")]
        [Range(0, 200)]
        public int AmountOfDvds { get; set; }

        [Required]
        [Display(Prompt = "Ievadi T-kreklu daudzumu", Name = "T-kreklu skaits")]
        [Range(0, 50)]
        public int AmountOfShirts { get; set; }

        [Required]
        [Display(Prompt = "Ievadi klienta vārdu, uzvārdu", Name = "Klienta vārds")]
        [MaxLength(50)]
        [MinLength(5)]
        public string CustomerName { get; set; }

        [Display(Prompt = "Ievadi klienta tālruni", Name = "Tālrunis")]
        [MaxLength(15)]
        [MinLength(5)]
        public string Phone { get; set; }

        [Display(Prompt = "Ievadi klienta e-pastu", Name = "E-pasts")]
        [MaxLength(30)]
        [MinLength(10)]
        public string Email { get; set; }

        [Required]
        [Display(Prompt = "Juridiska persona?", Name = "Juridiska persona")]
        public bool IsCompany { get; set; }

        [Display(Prompt = "Ievadi uzņēmuma adresi", Name = "Uzņēmuma adrese")]
        [MaxLength(100)]
        [MinLength(20)]
        public string Address { get; set; }

        [Display(Prompt = "Ievadi uzņēmuma reģ.nr.", Name = "Uzņēmuma reģ.nr.")]
        [MaxLength(11)]
        [MinLength(11)]
        public string RegistrationNumber { get; set; }

        [Display(Prompt = "Ievadi uzņēmuma PVN reģ.nr.", Name = "Uzņēmuma PVN reģ.nr.")]
        [MaxLength(13)]
        [MinLength(13)]
        public string PVNRegistrationNumber { get; set; }

        [Display(Prompt = "Ievadi piegādes adresi", Name = "Piegādes adrese")]
        [Required]
        [MaxLength(100)]
        [MinLength(20)]
        public string DeliveryAddress { get; set; }

        [Display(Prompt = "Ievadi piegādes detaļas", Name = "Piegādes detaļas")]
        [MaxLength(1000)]
        public string DeliveryDetails { get; set; }

        [Display(Prompt = "Ievadi piegādes datumu un laiku", Name = "Piegādes laiks")]
        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Ievadi datumu pareizā formātā!")]
        public DateTime DeliveryDateTime { get; set; }

        [Display(Prompt = "Ievadi apmaksas formātu", Name = "Apmaksas formāts")]
        [Required]
        public PaymentType PaymentType { get; set; }
    }
}
