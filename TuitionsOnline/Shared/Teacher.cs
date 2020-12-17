using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnline.Shared
{
    public class Teacher
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter your full name.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        public string TeachersFullName { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "This does not seem like an email address. Please check and enter again.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [MinLength(10, ErrorMessage = "Please enter a phone number of minimum 10 characters.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please enter a valid phone number.")]
        public string ContactPhoneNumber { get; set; }


        //Commented by JP on 17.12.2020 As per GJ requirement
        //To avoid null expection "0000" was hardcoded
        //[Required(ErrorMessage = "Please select year of birth.")]
        public string YearOfBirth { get; set; } = "0000";

        [Required(ErrorMessage = "Please mention the name of the city you live in.")]
        public string ResidentialCity { get; set; }

        [Required(ErrorMessage = "Please enter the pin code of your residence.")]
        [MinLength(6, ErrorMessage = "Please enter a zip code of minimum 6 characters.")]
        public string ResidentialPinCode { get; set; }
        public bool Graduate { get; set; }

        [RequiredIf(nameof(Graduate), ErrorMessage = "Please enter the required information.")]
        public string GraduateField { get; set; }

        public bool PostGraduate { get; set; }
        [RequiredIf(nameof(PostGraduate), ErrorMessage = "Please enter the required information.")]
        public string PostGraduateField { get; set; }

        public bool Doctorate { get; set; }
        [RequiredIf(nameof(Doctorate), ErrorMessage = "Please enter the required information.")]
        public string DoctrateField { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter the required information.")]
        public int ExperienceInYears { get; set; }

        [Range(0, 99999, ErrorMessage = "Please enter the required information.")]
        public int RatePerClassInRupees { get; set; }

        [Required(ErrorMessage = "Please enter the subjects you wish to teach.")]
        public string SubjectYouWishToTeach { get; set; }

        [Required(ErrorMessage = "Please enter the preferred language")]
        public string PrefferedLanguage { get; set; }

        public string AlternativeLanguage { get; set; }
        public Byte[] UploadYourIdentificationDocument { get; set; }
        public string UploadYourIdentificationDocumentBloburl { get; set; }
        public DateTime ApplicationReceivedDate { get; set; }
        public DateTime ApprovedDate { get; set; }
    }
}



