using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TeachMe.Web.Models
{
  public class RegistrationModel
  {
    [Required(ErrorMessage = "{0} is required")]
    [DisplayName("Username")]
    [Remote("IsUsernameAvailable","Validation", HttpMethod = "Post")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "{0} is required")]
    [DisplayName("Firstname")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "{0} is required")]
    [DisplayName("Lastname")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "{0} is required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "{0} is required")]
    public string Password { get; set; }
    [DisplayName("Confirm password")]
    [Required(ErrorMessage = "Please re-enter your password")]
    [Compare("Password",ErrorMessage = "password doesn't match")]
    public string ConfirmPassword { get; set; }

  }
}