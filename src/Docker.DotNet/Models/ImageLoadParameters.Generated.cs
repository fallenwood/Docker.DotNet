namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ImageLoadParameters // (main.ImageLoadParameters)
{
    [QueryStringParameter("quiet", true, typeof(BoolQueryStringConverter))]
    public bool Quiet { get; set; }
}
