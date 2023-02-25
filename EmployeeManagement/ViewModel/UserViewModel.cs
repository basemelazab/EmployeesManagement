using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.ViewModel
{
    public class UserViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name Is Required")]
        public string UserName { get; set; }
        [Display(Name = "User Email")]
        [Required(ErrorMessage = "User Email Is Required")]
        public string UserEmail { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Is Required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Is Required")]
        public string LastName { get; set; }
        [Display(Name = "User Password")]
        [Required(ErrorMessage = "User Password Is Required")]
        public string UserPassword { get; set; }
        [Display(Name = "Comfirm Password")]
        [Required(ErrorMessage = "UComfirm Password Is Required")]
        public string ComfirmPassword { get; set; }

    }
}