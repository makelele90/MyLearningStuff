/// <reference path="../jquery.validate-vsdoc.js" />
/// <reference path="../jquery-2.1.1-vsdoc.js" />


//IT IS IMPORTANT TO REVISIT FIRST HOW JQUERY VALIDATION WORKS
$(document).ready(function () {

  //get the form
  var form = $("#myform");

  //validate the form
  var validator = form.validate({
    debug: false,
    message: "invalid data",
    //elements with class <ignore> will be ignored
    ignore: ".ignore",
    errorPlacement: function (error, element) {

      //place the error message after the element
      element.after(error);
      if (element.attr("name") == "FirstName" || element.attr("name") == "LastName") {
        error.insertAfter("#Lastname");
      } 
      else {
        error.insertAfter(element);
      }
    },
    //add a validation group
    groups: {
      name: "FirstName LastName"
    },
    success: function (errorPlaceHolder) {
      errorPlaceHolder.addClass("valid").text("Ok!");
    },
    //override the default span placegholder with a div
    errorElement: "div"

  });

  //adding a method to validate
  $.validator.addMethod("containLetterI", function (value, element, params) {

    return value == "makelele90";
  });

  //add some rules for a DOM Element
  $('#Username').rules('add', {
    required: true,
    minlength: 10,
    containLetterI: [1, 2],
    messages: {
      required: "Username is required",
      minlength: "username length must be at least 10 letters",
      containLetterI: "you are not makelele90"
    }
  });

  $('#FirstName').rules('add', {
    required: true,
    messages: {
      required: "Name is required is required"
    }

  });
  $('#LastName').rules('add', {
    required: true,
    messages: {
      required: "Name is required is required"
    }

  });

  $("#mybutton").on("click", function () {


    var isValid = $("#myform").valid();



    if (isValid == true) {

      $("#myform").submit();
    }

  });

});

