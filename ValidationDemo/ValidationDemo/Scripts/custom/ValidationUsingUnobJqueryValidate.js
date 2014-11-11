/// <reference path="../jquery-2.1.1-vsdoc.js" />
/// <reference path="../jquery.validate.unobtrusive.js" />
$.validator.addMethod('mustcontainpat', function (value, element, param) {

  if (value)
    if (value.contains("pat")) return true;
  return false;
});

$.validator.unobtrusive.adapters.add('mustcontainpat', ["additional1", "additional2"], function (options) {
  //let pass some parameters
  options.rules['mustcontainpat'] =[options.params.additional1,options.params.additional2];
  options.messages['mustcontainpat'] = options.message;
});