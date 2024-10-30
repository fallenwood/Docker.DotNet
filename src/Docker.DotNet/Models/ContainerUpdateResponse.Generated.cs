namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerUpdateResponse // (main.ContainerUpdateResponse)
{
    [DataMember(Name = "Warnings", EmitDefaultValue = false)]
    public IList<string> Warnings { get; set; }
}
