using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab20.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)")]
        public string Email { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        public string Password { get; set; }
        [Required]
        public string FavoriteColor { get; set; }


    }
}
