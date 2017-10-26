using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Please enter your Phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify wheter you will attend the party")]
        public bool? WillAttend { get; set; }
            


    }
}
