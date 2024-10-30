namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class Ulimit // (units.Ulimit)
{
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "Hard", EmitDefaultValue = false)]
    public long Hard { get; set; }

    [DataMember(Name = "Soft", EmitDefaultValue = false)]
    public long Soft { get; set; }
}
