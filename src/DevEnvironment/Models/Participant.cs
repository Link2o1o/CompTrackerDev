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
        [Required(ErrorMessage = "Please enter your name.")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(64, MinimumLength = 6, ErrorMessage = "Password cannot be greater than 64, or less than 6.")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string HSName { get; set; }
        [DataType(DataType.Text)]
        public string NextCollege { get; set; }
        [DataType(DataType.MultilineText)]
        public string Awards { get; set; }
        [DataType(DataType.MultilineText)]
        public string Experience { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
