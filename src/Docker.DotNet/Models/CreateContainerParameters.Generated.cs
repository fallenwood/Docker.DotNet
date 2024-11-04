namespace Docker.DotNet.Models;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class CreateContainerParameters // (main.CreateContainerParameters)
{
    public CreateContainerParameters()
    {
    }

    public CreateContainerParameters(Config Config)
    {
        if (Config != null)
        {
            this.Hostname = Config.Hostname;
            this.Domainname = Config.Domainname;
            this.User = Config.User;
            this.AttachStdin = Config.AttachStdin;
            this.AttachStdout = Config.AttachStdout;
            this.AttachStderr = Config.AttachStderr;
            this.ExposedPorts = Config.ExposedPorts;
            this.Tty = Config.Tty;
            this.OpenStdin = Config.OpenStdin;
            this.StdinOnce = Config.StdinOnce;
            this.Env = Config.Env;
            this.Cmd = Config.Cmd;
            this.Healthcheck = Config.Healthcheck;
            this.ArgsEscaped = Config.ArgsEscaped;
            this.Image = Config.Image;
            this.Volumes = Config.Volumes;
            this.WorkingDir = Config.WorkingDir;
            this.Entrypoint = Config.Entrypoint;
            this.NetworkDisabled = Config.NetworkDisabled;
            this.MacAddress = Config.MacAddress;
            this.OnBuild = Config.OnBuild;
            this.Labels = Config.Labels;
            this.StopSignal = Config.StopSignal;
            this.StopTimeout = Config.StopTimeout;
            this.Shell = Config.Shell;
        }
    }

    [QueryStringParameter("name", false)]
    public string Name { get; set; }

    [QueryStringParameter("platform", false)]
    public string Platform { get; set; }

    [DataMember(Name = "Hostname", EmitDefaultValue = false)]
    [JsonPropertyName("Hostname")]
    public string Hostname { get; set; }

    [DataMember(Name = "Domainname", EmitDefaultValue = false)]
    [JsonPropertyName("Domainname")]
    public string Domainname { get; set; }

    [DataMember(Name = "User", EmitDefaultValue = false)]
    [JsonPropertyName("User")]
    public string User { get; set; }

    [DataMember(Name = "AttachStdin", EmitDefaultValue = false)]
    [JsonPropertyName("AttachStdin")]
    public bool AttachStdin { get; set; }

    [DataMember(Name = "AttachStdout", EmitDefaultValue = false)]
    [JsonPropertyName("AttachStdout")]
    public bool AttachStdout { get; set; }

    [DataMember(Name = "AttachStderr", EmitDefaultValue = false)]
    [JsonPropertyName("AttachStderr")]
    public bool AttachStderr { get; set; }

    [DataMember(Name = "ExposedPorts", EmitDefaultValue = false)]
    [JsonPropertyName("ExposedPorts")]
    public IDictionary<string, EmptyStruct> ExposedPorts { get; set; }

    [DataMember(Name = "Tty", EmitDefaultValue = false)]
    [JsonPropertyName("Tty")]
    public bool Tty { get; set; }

    [DataMember(Name = "OpenStdin", EmitDefaultValue = false)]
    [JsonPropertyName("OpenStdin")]
    public bool OpenStdin { get; set; }

    [DataMember(Name = "StdinOnce", EmitDefaultValue = false)]
    [JsonPropertyName("StdinOnce")]
    public bool StdinOnce { get; set; }

    [DataMember(Name = "Env", EmitDefaultValue = false)]
    [JsonPropertyName("Env")]
    public IList<string> Env { get; set; }

    [DataMember(Name = "Cmd", EmitDefaultValue = false)]
    [JsonPropertyName("Cmd")]
    public IList<string> Cmd { get; set; }

    [DataMember(Name = "Healthcheck", EmitDefaultValue = false)]
    [JsonPropertyName("Healthcheck")]
    public HealthcheckConfig Healthcheck { get; set; }

    [DataMember(Name = "ArgsEscaped", EmitDefaultValue = false)]
    [JsonPropertyName("ArgsEscaped")]
    public bool ArgsEscaped { get; set; }

    [DataMember(Name = "Image", EmitDefaultValue = false)]
    [JsonPropertyName("Image")]
    public string Image { get; set; }

    [DataMember(Name = "Volumes", EmitDefaultValue = false)]
    [JsonPropertyName("Volumes")]
    public IDictionary<string, EmptyStruct> Volumes { get; set; }

    [DataMember(Name = "WorkingDir", EmitDefaultValue = false)]
    [JsonPropertyName("WorkingDir")]
    public string WorkingDir { get; set; }

    [DataMember(Name = "Entrypoint", EmitDefaultValue = false)]
    [JsonPropertyName("Entrypoint")]
    public IList<string> Entrypoint { get; set; }

    [DataMember(Name = "NetworkDisabled", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkDisabled")]
    public bool NetworkDisabled { get; set; }

    [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
    [JsonPropertyName("MacAddress")]
    public string MacAddress { get; set; }

    [DataMember(Name = "OnBuild", EmitDefaultValue = false)]
    [JsonPropertyName("OnBuild")]
    public IList<string> OnBuild { get; set; }

    [DataMember(Name = "Labels", EmitDefaultValue = false)]
    [JsonPropertyName("Labels")]
    public IDictionary<string, string> Labels { get; set; }

    [DataMember(Name = "StopSignal", EmitDefaultValue = false)]
    [JsonPropertyName("StopSignal")]
    public string StopSignal { get; set; }

    [DataMember(Name = "StopTimeout", EmitDefaultValue = false)]
    [JsonPropertyName("StopTimeout")]
    [JsonConverter(typeof(TimeSpanSecondsConverter))]
    public TimeSpan? StopTimeout { get; set; }

    [DataMember(Name = "Shell", EmitDefaultValue = false)]
    [JsonPropertyName("Shell")]
    public IList<string> Shell { get; set; }

    [DataMember(Name = "HostConfig", EmitDefaultValue = false)]
    [JsonPropertyName("HostConfig")]
    public HostConfig HostConfig { get; set; }

    [DataMember(Name = "NetworkingConfig", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkingConfig")]
    public NetworkingConfig NetworkingConfig { get; set; }
}
