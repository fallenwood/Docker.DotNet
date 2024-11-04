namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerProcessesResponse // (container.ContainerTopOKBody)
{
    [DataMember(Name = "Processes", EmitDefaultValue = false)]
    [JsonPropertyName("Processes")]
    public IList<IList<string>> Processes { get; set; }

    [DataMember(Name = "Titles", EmitDefaultValue = false)]
    [JsonPropertyName("Titles")]
    public IList<string> Titles { get; set; }
}
