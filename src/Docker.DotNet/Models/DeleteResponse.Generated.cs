namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class DeleteResponse // (image.DeleteResponse)
{
    [DataMember(Name = "Deleted", EmitDefaultValue = false)]
    public string Deleted { get; set; }

    [DataMember(Name = "Untagged", EmitDefaultValue = false)]
    public string Untagged { get; set; }
}
