
using System;

namespace TeachMe.DataContainer.Data
{
  public class User
  {
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime?  UpdateOn { get; set; }
    public UserProfile UserProfile { get; set; }
  }
}
