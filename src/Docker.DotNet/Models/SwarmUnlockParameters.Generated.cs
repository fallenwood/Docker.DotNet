namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SwarmUnlockParameters // (main.SwarmUnlockParameters)
{
    [DataMember(Name = "UnlockKey", EmitDefaultValue = false)]
    public string UnlockKey { get; set; }
}
