namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ImagesSearchParameters // (main.ImagesSearchParameters)
{
    [QueryStringParameter("term", false)]
    public string Term { get; set; }

    [QueryStringParameter("limit", false)]
    public long? Limit { get; set; }

    [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
    public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }

    [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
    [JsonPropertyName("RegistryAuth")]
    public AuthConfig RegistryAuth { get; set; }
}
