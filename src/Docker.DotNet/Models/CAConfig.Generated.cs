namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class CAConfig // (swarm.CAConfig)
{
    [DataMember(Name = "NodeCertExpiry", EmitDefaultValue = false)]
    [JsonPropertyName("NodeCertExpiry")]
    public long NodeCertExpiry { get; set; }

    [DataMember(Name = "ExternalCAs", EmitDefaultValue = false)]
    [JsonPropertyName("ExternalCAs")]
    public IList<ExternalCA> ExternalCAs { get; set; }

    [DataMember(Name = "SigningCACert", EmitDefaultValue = false)]
    [JsonPropertyName("SigningCACert")]
    public string SigningCACert { get; set; }

    [DataMember(Name = "SigningCAKey", EmitDefaultValue = false)]
    [JsonPropertyName("SigningCAKey")]
    public string SigningCAKey { get; set; }

    [DataMember(Name = "ForceRotate", EmitDefaultValue = false)]
    [JsonPropertyName("ForceRotate")]
    public ulong ForceRotate { get; set; }
}
