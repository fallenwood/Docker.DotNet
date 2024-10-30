namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerResizeParameters // (main.ContainerResizeParameters)
{
    [QueryStringParameter("h", false)]
    public long? Height { get; set; }

    [QueryStringParameter("w", false)]
    public long? Width { get; set; }
}
