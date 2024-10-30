namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public sealed class ServiceListParameters // (main.ServiceListParameters)
{
    [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
    public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }

    [QueryStringParameter("status", false, typeof(BoolQueryStringConverter))]
    public bool? Status { get; set; }
}
