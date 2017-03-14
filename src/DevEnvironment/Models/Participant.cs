using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEnvironment.Models
{
    public class Participant
    {
        //First name 
        [Required(ErrorMessage = "Please enter your name.")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        //Last name
        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        //Username
        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        //Password
        [Required]
        [DataType(DataType.Password)]
        [StringLength(64, MinimumLength = 6, ErrorMessage = "Password cannot be greater than 64, or less than 6.")]
        public string Password { get; set; }

        //Compares Password with this field
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        //Birthday
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        //Gender
        [Required]
        public string Gender { get; set; }

        //Email
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //High School name
        [Required]
        [DataType(DataType.Text)]
        public string HSName { get; set; }

        //Desired College
        [DataType(DataType.Text)]
        public string NextCollege { get; set; }

        //Awards
        [DataType(DataType.MultilineText)]
        public string Awards { get; set; }

        //Previous Experience
        [DataType(DataType.MultilineText)]
        public string Experience { get; set; }
    }
}
