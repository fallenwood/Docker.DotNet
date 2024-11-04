namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerUpdateResponse // (main.ContainerUpdateResponse)
{
    [DataMember(Name = "Warnings", EmitDefaultValue = false)]
    [JsonPropertyName("Warnings")]
    public IList<string> Warnings { get; set; }
}
