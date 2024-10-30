namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ImageDeleteParameters // (main.ImageDeleteParameters)
{
    [QueryStringParameter("force", false, typeof(BoolQueryStringConverter))]
    public bool? Force { get; set; }

    [QueryStringParameter("noprune", false, typeof(BoolQueryStringConverter))]
    public bool? NoPrune { get; set; }
}
