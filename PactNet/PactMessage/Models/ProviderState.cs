﻿using Newtonsoft.Json;

namespace PactNet.PactMessage.Models
{
    public class ProviderState
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        //[JsonProperty(PropertyName = "params")]
        //public string Params { get; set; }
    }
}