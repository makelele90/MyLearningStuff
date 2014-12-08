using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;

namespace WebApiFromTemplate.Controllers
{
    public class CoursesController : ApiController
    {
      private static List<course> _courses = InitCourses();

      [HttpGet]
      public IEnumerable<course> AllCourse()
      {
        return _courses;
      }

      public HttpResponseMessage Get(int id)
      {
        HttpResponseMessage msg = null;

        var course=_courses.SingleOrDefault(c => c.id == id);

        if (course==null)
        {
          msg = Request.CreateResponse(HttpStatusCode.NotFound);
        }
        else
        {
          msg = Request.CreateResponse(HttpStatusCode.OK, course);
        }

        //if course is null retun 404
        return msg;
      }

      public HttpResponseMessage Post([FromBody]course c)
      {
        c.id = _courses.Count();

        _courses.Add(c);

       var msg= Request.CreateResponse(HttpStatusCode.Created);

        msg.Headers.Location =  new Uri(Request.RequestUri +"/"+ c.id.ToString());
        //return 201 with location header


        return msg;
      }

      public void Put(int id, [FromBody] course c)
      {
        var course = _courses.SingleOrDefault(cs => cs.id == id);

        if (course!=null)
        {
          _courses.Remove(course);
          course.title = c.title;

          _courses.Add(course);

        }
       
        
      }

      public void Delete(int id)
      {
        var course = _courses.SingleOrDefault(c => c.id == id);

        _courses.Remove(course);
      }

      private static List<course> InitCourses()
      {
        var courses = new List<course>()
          {
            new course() {id = 0, title = "Wep api"},
            new course() {id = 1, title = "Mobile app using html5"},
            new course() {id = 2, title = "C# design pattern"}
          };

        return courses;
      } 
    }

    public class course
    {
      public int id;
      public string title;
    }
}
