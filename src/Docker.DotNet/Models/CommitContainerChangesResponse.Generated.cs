namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class CommitContainerChangesResponse // (main.CommitContainerChangesResponse)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    public string ID { get; set; }
}
