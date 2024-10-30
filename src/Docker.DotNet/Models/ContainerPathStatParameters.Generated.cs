namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class ContainerPathStatParameters // (main.ContainerPathStatParameters)
{
    [QueryStringParameter("path", true)]
    public string Path { get; set; }

    [QueryStringParameter("noOverwriteDirNonDir", false, typeof(BoolQueryStringConverter))]
    public bool? AllowOverwriteDirWithFile { get; set; }
}
