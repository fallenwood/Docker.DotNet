namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class CreateContainerResponse // (container.CreateResponse)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "Warnings", EmitDefaultValue = false)]
    [JsonPropertyName("Warnings")]
    public IList<string> Warnings { get; set; }
}
