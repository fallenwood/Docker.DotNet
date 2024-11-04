namespace Docker.DotNet.Models;

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class DeviceMapping // (container.DeviceMapping)
{
    [DataMember(Name = "PathOnHost", EmitDefaultValue = false)]
    [JsonPropertyName("PathOnHost")]
    public string PathOnHost { get; set; }

    [DataMember(Name = "PathInContainer", EmitDefaultValue = false)]
    [JsonPropertyName("PathInContainer")]
    public string PathInContainer { get; set; }

    [DataMember(Name = "CgroupPermissions", EmitDefaultValue = false)]
    [JsonPropertyName("CgroupPermissions")]
    public string CgroupPermissions { get; set; }
}
