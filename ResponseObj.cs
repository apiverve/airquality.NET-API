using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("pm2_5")]
        public double Pm25 { get; set; }

        [JsonProperty("pm10")]
        public double Pm10 { get; set; }

        [JsonProperty("us-epa-index")]
        public int Usepaindex { get; set; }

        [JsonProperty("gb-defra-index")]
        public int Gbdefraindex { get; set; }

        [JsonProperty("carbonMonoxide")]
        public double CarbonMonoxide { get; set; }

        [JsonProperty("ozone")]
        public int Ozone { get; set; }

        [JsonProperty("nitrogenDioxide")]
        public double NitrogenDioxide { get; set; }

        [JsonProperty("sulfurdioxide")]
        public double Sulfurdioxide { get; set; }

        [JsonProperty("recommendation")]
        public string Recommendation { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
