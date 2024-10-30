namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class JoinTokens // (swarm.JoinTokens)
{
    [DataMember(Name = "Worker", EmitDefaultValue = false)]
    public string Worker { get; set; }

    [DataMember(Name = "Manager", EmitDefaultValue = false)]
    public string Manager { get; set; }
}
