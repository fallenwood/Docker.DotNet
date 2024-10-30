namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ImageTagParameters // (main.ImageTagParameters)
{
    [QueryStringParameter("repo", false)]
    public string RepositoryName { get; set; }

    [QueryStringParameter("tag", false)]
    public string Tag { get; set; }

    [QueryStringParameter("force", false, typeof(BoolQueryStringConverter))]
    public bool? Force { get; set; }
}
