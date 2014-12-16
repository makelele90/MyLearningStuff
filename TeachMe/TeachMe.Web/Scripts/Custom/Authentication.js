/// <reference path="../jquery-2.1.1-vsdoc.js" />
/// <reference path="../jquery.validate.unobtrusive.js" />


(function ($) {

  $('#loginBtn').click(function () {

    var isValid = $('#loginForm').valid();

    if (isValid === false) return false;

    $.post('/api/Authentication/Login', $('#loginForm').serialize()).done(function (data) {

      if (typeof (data) === 'undefined') 
      {
        $('.welcome').text('no record found');
      }
      else 
      {
        $('.welcome').text('welcome ' + data.Username);
      }

    });

    return false;

  });

})(jQuery);

