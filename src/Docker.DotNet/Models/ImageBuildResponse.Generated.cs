namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ImageBuildResponse // (types.ImageBuildResponse)
{
    [DataMember(Name = "Body", EmitDefaultValue = false)]
    public object Body { get; set; }

    [DataMember(Name = "OSType", EmitDefaultValue = false)]
    public string OSType { get; set; }
}
