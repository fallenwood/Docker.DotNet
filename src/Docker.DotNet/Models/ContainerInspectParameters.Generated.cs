namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerInspectParameters // (main.ContainerInspectParameters)
{
    [QueryStringParameter("size", false, typeof(BoolQueryStringConverter))]
    public bool? IncludeSize { get; set; }
}
