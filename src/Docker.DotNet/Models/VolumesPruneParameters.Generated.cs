namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class VolumesPruneParameters // (main.VolumesPruneParameters)
{
    [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
    public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }
}
