namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class NetworksCreateResponse // (network.CreateResponse)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    public string ID { get; set; }

    [DataMember(Name = "Warning", EmitDefaultValue = false)]
    public string Warning { get; set; }
}
