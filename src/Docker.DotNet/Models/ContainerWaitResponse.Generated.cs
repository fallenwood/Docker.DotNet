namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerWaitResponse // (main.ContainerWaitResponse)
{
    [DataMember(Name = "Error", EmitDefaultValue = false)]
    public WaitExitError Error { get; set; }

    [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
    public long StatusCode { get; set; }
}
