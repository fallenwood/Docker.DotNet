namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PluginRemoveParameters // (main.PluginRemoveParameters)
{
    [QueryStringParameter("force", false, typeof(BoolQueryStringConverter))]
    public bool? Force { get; set; }
}
