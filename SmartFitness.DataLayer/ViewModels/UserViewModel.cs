using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartFitness.DataLayer.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        public string Password { get; set; }
        public bool UserStatus { get; set; }
    }
}
