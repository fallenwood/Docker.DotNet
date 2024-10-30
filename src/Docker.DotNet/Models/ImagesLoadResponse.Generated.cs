namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ImagesLoadResponse // (image.LoadResponse)
{
    [DataMember(Name = "Body", EmitDefaultValue = false)]
    public object Body { get; set; }

    [DataMember(Name = "JSON", EmitDefaultValue = false)]
    public bool JSON { get; set; }
}
