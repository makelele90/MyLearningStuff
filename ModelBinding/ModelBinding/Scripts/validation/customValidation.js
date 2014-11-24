
/// <reference path="../jquery-2.1.1-vsdoc.js" />
/// <reference path="../jquery.validate-vsdoc.js" />


(function ($) {
  $.validator.addMethod("fullname", function (value,element) {

    var firstname = $("#FirstName").val();
    var lastName = $("#LastName").val();

    if (firstname === "" || lastName === "") {

      return false;
    }

    return true;
  });

  $.validator.unobtrusive.adapters.add('fullname', [], function (options) {
    //let pass some parameters
    options.rules['fullname'] = [];
    options.messages['fullname'] = options.message;
  });
})(jQuery);
  


