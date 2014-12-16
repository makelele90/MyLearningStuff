
using System.Collections.Generic;
using System.Data.Entity;
using TeachMe.DAL.DataEngine;
using TeachMe.DataContainer.Data;

namespace TeachMe.DAL.DatabaseInitialiser
{
  public class TeachMeInitialialiser : DropCreateDatabaseAlways<TeachMeContext>
   {
    protected override void Seed(TeachMeContext context)
    {
      var users = new List<User>()
      {
        new User() {Username = "pat", Password = "123"},
        new User() {Username = "joanna", Password = "patate"},
        new User() {Username = "mary", Password = "manate"}
      };

      context.Users.AddRange(users);
      base.Seed(context);
    }
   }
}
