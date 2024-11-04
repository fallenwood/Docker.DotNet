namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ImageHistoryResponse // (image.HistoryResponseItem)
{
    [DataMember(Name = "Comment", EmitDefaultValue = false)]
    [JsonPropertyName("Comment")]
    public string Comment { get; set; }

    [DataMember(Name = "Created", EmitDefaultValue = false)]
    [JsonPropertyName("Created")]
    public DateTime Created { get; set; }

    [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
    [JsonPropertyName("CreatedBy")]
    public string CreatedBy { get; set; }

    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "Size", EmitDefaultValue = false)]
    [JsonPropertyName("Size")]
    public long Size { get; set; }

    [DataMember(Name = "Tags", EmitDefaultValue = false)]
    [JsonPropertyName("Tags")]
    public IList<string> Tags { get; set; }
}
