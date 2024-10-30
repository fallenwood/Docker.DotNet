namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ImagePushParameters // (main.ImagePushParameters)
{
    [QueryStringParameter("fromImage", false)]
    public string ImageID { get; set; }

    [QueryStringParameter("tag", false)]
    public string Tag { get; set; }

    [DataMember(Name = "RegistryAuth", EmitDefaultValue = false)]
    public AuthConfig RegistryAuth { get; set; }
}
