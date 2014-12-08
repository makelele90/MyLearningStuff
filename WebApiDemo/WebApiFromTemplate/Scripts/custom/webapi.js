/// <reference path="../jquery-1.7.1-vsdoc.js" />


(function($) {

  $.ajax({
    url: 'http://localhost:50576/api/courses',

    success: function (courses) {

      var list = $('#courses');


      for (var i = 0; i < courses.length; i++) {

        var course = courses[i];

        list.append('<li>' + course.title + '</li>');
      }
    }
  });
})(jQuery);
