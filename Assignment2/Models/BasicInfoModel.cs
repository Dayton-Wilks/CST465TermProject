using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class BasicInfoModel
    {
        [Required(ErrorMessage = "You need to enter a name!")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to enter a phone number!")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You need to enter an email!")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Message")]
        public string Message { get; set; }
    }
}
