namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerListResponse // (types.Container)
{
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    [JsonPropertyName("Id")]
    public string ID { get; set; }

    [DataMember(Name = "Names", EmitDefaultValue = false)]
    [JsonPropertyName("Names")]
    public IList<string> Names { get; set; }

    [DataMember(Name = "Image", EmitDefaultValue = false)]
    [JsonPropertyName("Image")]
    public string Image { get; set; }

    [DataMember(Name = "ImageID", EmitDefaultValue = false)]
    [JsonPropertyName("ImageID")]
    public string ImageID { get; set; }

    [DataMember(Name = "Command", EmitDefaultValue = false)]
    [JsonPropertyName("Command")]
    public string Command { get; set; }

    [DataMember(Name = "Created", EmitDefaultValue = false)]
    [JsonPropertyName("Created")]
    public DateTime Created { get; set; }

    [DataMember(Name = "Ports", EmitDefaultValue = false)]
    [JsonPropertyName("Ports")]
    public IList<Port> Ports { get; set; }

    [DataMember(Name = "SizeRw", EmitDefaultValue = false)]
    [JsonPropertyName("SizeRw")]
    public long SizeRw { get; set; }

    [DataMember(Name = "SizeRootFs", EmitDefaultValue = false)]
    [JsonPropertyName("SizeRootFs")]
    public long SizeRootFs { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "State", EmitDefaultValue = false)]
    [JsonPropertyName("State")]
    public string State { get; set; }

    [DataMember(Name = "Status", EmitDefaultValue = false)]
    [JsonPropertyName("Status")]
    public string Status { get; set; }

    [DataMember(Name = "NetworkSettings", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkSettings")]
    public SummaryNetworkSettings NetworkSettings { get; set; }

    [DataMember(Name = "Mounts", EmitDefaultValue = false)]
    [JsonPropertyName("Mounts")]
    public IList<MountPoint> Mounts { get; set; }
}
