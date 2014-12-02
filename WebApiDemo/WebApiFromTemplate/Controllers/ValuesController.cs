using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFromTemplate.Controllers
{
  public class ValuesController : ApiController
  {
    // GET api/values
// ReSharper disable FieldCanBeMadeReadOnly.Local
   private static List<string> _values = new List<string>() { "value1", "value2" };
// ReSharper restore FieldCanBeMadeReadOnly.Local
    public IEnumerable<string> Get()
    {
      return _values;
    }

    // GET api/values/5
    public HttpResponseMessage Get(int id)
    {
      if (_values.Count>id)
      {
        return Request.CreateResponse(HttpStatusCode.OK, _values[id]);
      }
      else
      {
        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "item not found");
      }
     
    }

    // POST api/values
    public HttpResponseMessage Post([FromBody]string value)
    {
      _values.Add(value);

      var msg = Request.CreateResponse(HttpStatusCode.Created);

      msg.Headers.Location = new Uri(Request.RequestUri + (_values.Count-1).ToString());

      return msg;
    }

    // PUT api/values/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    public void Delete(int id)
    {
    }
  }
}