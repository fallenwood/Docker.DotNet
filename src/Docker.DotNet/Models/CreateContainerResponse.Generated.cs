namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class CreateContainerResponse // (container.CreateResponse)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    public string ID { get; set; }

    [DataMember(Name = "Warnings", EmitDefaultValue = false)]
    public IList<string> Warnings { get; set; }
}
