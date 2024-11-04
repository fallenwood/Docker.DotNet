namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class TLSInfo // (swarm.TLSInfo)
{
    [DataMember(Name = "TrustRoot", EmitDefaultValue = false)]
    [JsonPropertyName("TrustRoot")]
    public string TrustRoot { get; set; }

    [DataMember(Name = "CertIssuerSubject", EmitDefaultValue = false)]
    [JsonPropertyName("CertIssuerSubject")]
    public IList<byte> CertIssuerSubject { get; set; }

    [DataMember(Name = "CertIssuerPublicKey", EmitDefaultValue = false)]
    [JsonPropertyName("CertIssuerPublicKey")]
    public IList<byte> CertIssuerPublicKey { get; set; }
}
