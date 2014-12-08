using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace TweeterClientMvc.Controllers
{
  public class HttpHeader
  {
    [JsonProperty("Accept-Language")]
    public string Language { get; set; }

    [JsonProperty("Host")]
    public string Host { get; set; }

    [JsonProperty("User-Agent")]
    public string Agent { get; set; }
  }
}
