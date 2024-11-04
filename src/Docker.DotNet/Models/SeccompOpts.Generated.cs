namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class SeccompOpts // (swarm.SeccompOpts)
{
    [DataMember(Name = "Mode", EmitDefaultValue = false)]
    [JsonPropertyName("Mode")]
    public string Mode { get; set; }

    [DataMember(Name = "Profile", EmitDefaultValue = false)]
    [JsonPropertyName("Profile")]
    public IList<byte> Profile { get; set; }
}
