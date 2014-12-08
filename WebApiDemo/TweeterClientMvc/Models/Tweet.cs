using System;
using Newtonsoft.Json;

namespace TweeterClientMvc.Controllers
{
 public  class Tweet
  {
    [JsonProperty("from_user")]
    public string  UserName { get; set; }
     [JsonProperty("text")]
    public string TweetText { get; set; }
  }
}
