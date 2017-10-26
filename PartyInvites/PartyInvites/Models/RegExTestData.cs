using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class RegExTestData
    { 
        [Required (ErrorMessage = "Please enter the Postal Code")]
        [RegularExpression(@"\d\d\d\d(-\d\d\d)?", ErrorMessage ="Invalid Postal Code")]
        public string PostalCode { get; set; }


        //License Plate
        [Required (ErrorMessage ="Please enter the License Place ")]
        [RegularExpression(@"[A-Z0-9]{2}-[A-Z0-9]{2}-[A-Z0-9]{2}", ErrorMessage = "Invalid License Plate")]
        public string LicensePlate { get; set; }

        //Phone

        [Required (ErrorMessage ="Please enter your Phone Number")]
        [RegularExpression(@"(2\d{8})|9[1236]\d{7}",ErrorMessage = "Invalid Phone Numeber")]
        public int PhoneNumber { get; set; }
    }
}
