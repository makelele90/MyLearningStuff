
using System.ComponentModel.DataAnnotations;

namespace ModelBinding.Models
{
  public class CustomerModel
  {
   [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName{ get; set; }
  }
}