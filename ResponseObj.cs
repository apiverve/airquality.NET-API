using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("pm2_5")]
    public double pm25 { get; set; }

    [JsonProperty("pm10")]
    public double pm10 { get; set; }

    [JsonProperty("us-epa-index")]
    public int usepaindex { get; set; }

    [JsonProperty("gb-defra-index")]
    public int gbdefraindex { get; set; }

    [JsonProperty("carbonMonoxide")]
    public double carbonMonoxide { get; set; }

    [JsonProperty("ozone")]
    public int ozone { get; set; }

    [JsonProperty("nitrogenDioxide")]
    public double nitrogenDioxide { get; set; }

    [JsonProperty("sulfurdioxide")]
    public double sulfurdioxide { get; set; }

    [JsonProperty("recommendation")]
    public string recommendation { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
