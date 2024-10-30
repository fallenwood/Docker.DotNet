namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SwarmUnlockResponse // (main.SwarmUnlockResponse)
{
    [DataMember(Name = "UnlockKey", EmitDefaultValue = false)]
    public string UnlockKey { get; set; }
}
