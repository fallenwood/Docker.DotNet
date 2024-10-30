namespace Docker.DotNet.Models;

using System.Runtime.Serialization;

[DataContract]
public sealed class PluginCreateParameters // (main.PluginCreateParameters)
{
    [QueryStringParameter("name", true)]
    public string Name { get; set; }
}
