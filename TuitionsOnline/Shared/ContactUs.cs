using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnline.Shared
{
    public class ContactUs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string DefenceForcesRank { get; set; }
        [Required(ErrorMessage = "Please enter your full name.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "This does not seem like an email address. Please check and enter again.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        [MinLength(10, ErrorMessage = "Please enter a phone number of minimum 10 characters.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        [MinLength(10, ErrorMessage = "Please enter a phone number of minimum 10 characters.")]
        public string HowCanWeHelpYou { get; set; }
    }
}
