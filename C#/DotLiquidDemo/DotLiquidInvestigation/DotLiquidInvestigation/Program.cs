using System;
using DotLiquid;

namespace DotLiquidInvestigation
{
  class Program
  {
    static void Main(string[] args)
    {
     // var template = Template.Parse("hi {{user.name}}"); 
     // var parsedData=  template.Render(Hash.FromAnonymousObject(new { user =new {name="francis"} }));

     // var template = Template.Parse("{{'hi tobbi'}}");
      // var parsedData = template.Render();


      #region using filters
      //var template = Template.Parse("{{ 'tobi' | upcase }}");
      //var parsedData = template.Render();

     // var template = Template.Parse("Hello tobi has {{ 'francis' | size }} characters!");
     // var parsedData = template.Render();

     // var template = Template.Parse("Hello {{ '*francis*' | textilize | upcase }}");
     // var parsedData = template.Render();

      //var template = Template.Parse("{{ '<div>Hello now</div>' | strip_html }}");
      //var parsedData = template.Render();
      #endregion

      #region tags
      //var template = Template.Parse("We made 1 million dollars {% comment %} in losses {% endcomment %} this year");
     // var parsedData = template.Render();

     // var template = Template.Parse("{% raw %}In Handlebars, {{ this }} will be HTML-escaped, but {{{ that }}} will not.{% endraw %}");
      //var parsedData = template.Render();

      //var template = Template.Parse("{% if user %}Hello {{ user.name }}{% endif %}");
      //var parsedData = template.Render(Hash.FromAnonymousObject(new { user = new { name = "francis" } }));

      //var template = Template.Parse("{% if user.name == 'tobi' %} Hello tobi {% elsif user.name == 'bob' %} Hello bob{% endif %}");
      //var parsedData = template.Render(Hash.FromAnonymousObject(new { user = new { name = "bob" } }));


      var template = Template.Parse("{% for item in array %} massa {{ item }} {% endfor %}");
      var parsedData = template.Render(Hash.FromAnonymousObject(new {array=new []{1,2,3}}));

      #endregion
      
    
      Console.WriteLine(parsedData);

      Console.Read();
    }
  }
}
