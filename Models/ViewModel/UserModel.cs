﻿using System.ComponentModel.DataAnnotations;

namespace ENTJAVA_Week3.Models.ViewModel
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Created By")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name ="Registered Genres")]
        public int CreatedBy { get; set; }
    }

    public class UsersModel
    {
        public List<UserModel> Users { get; set; }
    }
}
