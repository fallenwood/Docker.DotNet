namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerExecCreateResponse // (main.ContainerExecCreateResponse)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    public string ID { get; set; }
}
