using System.ComponentModel.DataAnnotations;
using ValidationDemo.ValidationAttributes;

namespace ValidationDemo.Models
{
  public class RegistrationModel
  {
    [MustContainPat( ErrorMessage ="{0} must contain pat")]
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string  LastName { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
  }
}