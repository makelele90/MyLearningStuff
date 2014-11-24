using System.Web.Mvc;
using ModelBinding.Models;

namespace ModelBinding.ModelBinder
{
  public class CustomerBinder :IModelBinder
  {
    
    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    {
      var valueProvider = bindingContext.ValueProvider;

      var firstName = valueProvider.GetValue("FirstName").AttemptedValue;
      var lastName = valueProvider.GetValue("LastName").AttemptedValue;
      var customer = new CustomerModel();

      if(string.IsNullOrWhiteSpace(firstName)|| string.IsNullOrWhiteSpace(lastName))
        bindingContext.ModelState.AddModelError("fullname","must provide both firstname and lastname");
      else
      {
        customer.FirstName = firstName;
        customer.LastName = lastName;
        customer.FullName = firstName + " " + lastName;

      }
      
      return customer;
    }
  }
}