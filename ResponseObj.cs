using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("carbonMonoxide")]
    public double carbonMonoxide { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("gb-defra-index")]
    public int gbdefraindex { get; set; }

    [JsonProperty("nitrogenDioxide")]
    public int nitrogenDioxide { get; set; }

    [JsonProperty("ozone")]
    public double ozone { get; set; }

    [JsonProperty("pm10")]
    public double pm10 { get; set; }

    [JsonProperty("pm2_5")]
    public double pm25 { get; set; }

    [JsonProperty("recommendation")]
    public string recommendation { get; set; }

    [JsonProperty("sulfurdioxide")]
    public double sulfurdioxide { get; set; }

    [JsonProperty("us-epa-index")]
    public int usepaindex { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
