namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PluginDisableParameters // (main.PluginDisableParameters)
{
    [QueryStringParameter("force", false, typeof(BoolQueryStringConverter))]
    public bool? Force { get; set; }
}
