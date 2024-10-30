namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class RootFS // (types.RootFS)
{
    [DataMember(Name = "Type", EmitDefaultValue = false)]
    public string Type { get; set; }

    [DataMember(Name = "Layers", EmitDefaultValue = false)]
    public IList<string> Layers { get; set; }
}
