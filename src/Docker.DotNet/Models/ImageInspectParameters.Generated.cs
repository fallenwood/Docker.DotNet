namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ImageInspectParameters // (main.ImageInspectParameters)
{
    [QueryStringParameter("size", false, typeof(BoolQueryStringConverter))]
    public bool? IncludeSize { get; set; }
}
