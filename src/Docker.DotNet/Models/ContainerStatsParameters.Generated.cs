namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerStatsParameters // (main.ContainerStatsParameters)
{
    [QueryStringParameter("stream", true, typeof(BoolQueryStringConverter))]
    public bool Stream { get; set; } = true;

    [QueryStringParameter("one-shot", false, typeof(BoolQueryStringConverter))]
    public bool? OneShot { get; set; }
}
