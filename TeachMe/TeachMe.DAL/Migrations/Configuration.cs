using System;
using System.Collections.Generic;
using TeachMe.DAL.DataEngine;
using TeachMe.DataContainer.Data;

namespace TeachMe.DAL.Migrations
{
  using System.Data.Entity.Migrations;

  internal sealed class Configuration : DbMigrationsConfiguration<TeachMeContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
      ContextKey = "TeachMe.DAL.DataEngine.TeachMeContext";
    }

    protected override void Seed(TeachMeContext context)
    {
      var users = new List<User>()
      {
        new User() {Username = "pat", Password = "123", CreatedOn = DateTime.Now},
        new User() {Username = "joanna", Password = "patate", CreatedOn = DateTime.Now},
        new User() {Username = "mary", Password = "manate", CreatedOn = DateTime.Now}
      };

      context.Users.AddRange(users);
      base.Seed(context);
    }
  }
}
