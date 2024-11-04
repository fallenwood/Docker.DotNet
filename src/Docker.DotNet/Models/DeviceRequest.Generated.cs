namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class DeviceRequest // (container.DeviceRequest)
{
    [DataMember(Name = "Driver", EmitDefaultValue = false)]
    [JsonPropertyName("Driver")]
    public string Driver { get; set; }

    [DataMember(Name = "Count", EmitDefaultValue = false)]
    [JsonPropertyName("Count")]
    public long Count { get; set; }

    [DataMember(Name = "DeviceIDs", EmitDefaultValue = false)]
    [JsonPropertyName("DeviceIDs")]
    public IList<string> DeviceIDs { get; set; }

    [DataMember(Name = "Capabilities", EmitDefaultValue = false)]
    [JsonPropertyName("Capabilities")]
    public IList<IList<string>> Capabilities { get; set; }

    [DataMember(Name = "Options", EmitDefaultValue = false)]
    [JsonPropertyName("Options")]
    public IDictionary<string, string> Options { get; set; }
}
