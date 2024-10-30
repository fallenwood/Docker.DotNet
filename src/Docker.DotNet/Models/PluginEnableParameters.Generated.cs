namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PluginEnableParameters // (main.PluginEnableParameters)
{
    [QueryStringParameter("timeout", false)]
    public long? Timeout { get; set; }
}
