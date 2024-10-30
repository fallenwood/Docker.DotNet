namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SwarmCreateConfigResponse // (main.SwarmCreateConfigResponse)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    public string ID { get; set; }
}
