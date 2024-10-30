namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class JSONError // (jsonmessage.JSONError)
{
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public long Code { get; set; }

    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }
}
