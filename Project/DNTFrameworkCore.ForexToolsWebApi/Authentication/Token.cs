using Newtonsoft.Json;

namespace DNTFrameworkCore.ForexToolsWebApi.Authentication
{
    public class Token
    {
        [JsonProperty("token")]
        public string Value { get; set; }
    }

}