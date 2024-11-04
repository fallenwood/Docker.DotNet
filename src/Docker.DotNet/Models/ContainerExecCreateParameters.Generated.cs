namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class ContainerExecCreateParameters // (main.ContainerExecCreateParameters)
{
    [DataMember(Name = "User", EmitDefaultValue = false)]
    [JsonPropertyName("User")]
    public string User { get; set; }

    [DataMember(Name = "Privileged", EmitDefaultValue = false)]
    [JsonPropertyName("Privileged")]
    public bool Privileged { get; set; }

    [DataMember(Name = "Tty", EmitDefaultValue = false)]
    [JsonPropertyName("Tty")]
    public bool Tty { get; set; }

    [DataMember(Name = "ConsoleSize", EmitDefaultValue = false)]
    [JsonPropertyName("ConsoleSize")]
    public ulong[] ConsoleSize { get; set; }

    [DataMember(Name = "AttachStdin", EmitDefaultValue = false)]
    [JsonPropertyName("AttachStdin")]
    public bool AttachStdin { get; set; }

    [DataMember(Name = "AttachStderr", EmitDefaultValue = false)]
    [JsonPropertyName("AttachStderr")]
    public bool AttachStderr { get; set; }

    [DataMember(Name = "AttachStdout", EmitDefaultValue = false)]
    [JsonPropertyName("AttachStdout")]
    public bool AttachStdout { get; set; }

    [DataMember(Name = "Detach", EmitDefaultValue = false)]
    [JsonPropertyName("Detach")]
    public bool Detach { get; set; }

    [DataMember(Name = "DetachKeys", EmitDefaultValue = false)]
    [JsonPropertyName("DetachKeys")]
    public string DetachKeys { get; set; }

    [DataMember(Name = "Env", EmitDefaultValue = false)]
    [JsonPropertyName("Env")]
    public IList<string> Env { get; set; }

    [DataMember(Name = "WorkingDir", EmitDefaultValue = false)]
    [JsonPropertyName("WorkingDir")]
    public string WorkingDir { get; set; }

    [DataMember(Name = "Cmd", EmitDefaultValue = false)]
    [JsonPropertyName("Cmd")]
    public IList<string> Cmd { get; set; }
}
