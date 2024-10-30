namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class SecretCreateResponse // (main.SecretCreateResponse)
{
    [DataMember(Name = "ID", EmitDefaultValue = false)]
    public string ID { get; set; }
}
