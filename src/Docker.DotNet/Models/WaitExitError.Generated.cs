namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class WaitExitError // (container.WaitExitError)
{
    [DataMember(Name = "Message", EmitDefaultValue = false)]
    public string Message { get; set; }
}
