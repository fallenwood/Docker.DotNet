namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class HostConfig // (container.HostConfig)
{
    public HostConfig()
    {
    }

    public HostConfig(Resources Resources)
    {
        if (Resources != null)
        {
            this.CPUShares = Resources.CPUShares;
            this.Memory = Resources.Memory;
            this.NanoCPUs = Resources.NanoCPUs;
            this.CgroupParent = Resources.CgroupParent;
            this.BlkioWeight = Resources.BlkioWeight;
            this.BlkioWeightDevice = Resources.BlkioWeightDevice;
            this.BlkioDeviceReadBps = Resources.BlkioDeviceReadBps;
            this.BlkioDeviceWriteBps = Resources.BlkioDeviceWriteBps;
            this.BlkioDeviceReadIOps = Resources.BlkioDeviceReadIOps;
            this.BlkioDeviceWriteIOps = Resources.BlkioDeviceWriteIOps;
            this.CPUPeriod = Resources.CPUPeriod;
            this.CPUQuota = Resources.CPUQuota;
            this.CPURealtimePeriod = Resources.CPURealtimePeriod;
            this.CPURealtimeRuntime = Resources.CPURealtimeRuntime;
            this.CpusetCpus = Resources.CpusetCpus;
            this.CpusetMems = Resources.CpusetMems;
            this.Devices = Resources.Devices;
            this.DeviceCgroupRules = Resources.DeviceCgroupRules;
            this.DeviceRequests = Resources.DeviceRequests;
            this.KernelMemory = Resources.KernelMemory;
            this.KernelMemoryTCP = Resources.KernelMemoryTCP;
            this.MemoryReservation = Resources.MemoryReservation;
            this.MemorySwap = Resources.MemorySwap;
            this.MemorySwappiness = Resources.MemorySwappiness;
            this.OomKillDisable = Resources.OomKillDisable;
            this.PidsLimit = Resources.PidsLimit;
            this.Ulimits = Resources.Ulimits;
            this.CPUCount = Resources.CPUCount;
            this.CPUPercent = Resources.CPUPercent;
            this.IOMaximumIOps = Resources.IOMaximumIOps;
            this.IOMaximumBandwidth = Resources.IOMaximumBandwidth;
        }
    }

    [DataMember(Name = "Binds", EmitDefaultValue = false)]
    [JsonPropertyName("Binds")]
    public IList<string> Binds { get; set; }

    [DataMember(Name = "ContainerIDFile", EmitDefaultValue = false)]
    [JsonPropertyName("ContainerIDFile")]
    public string ContainerIDFile { get; set; }

    [DataMember(Name = "LogConfig", EmitDefaultValue = false)]
    [JsonPropertyName("LogConfig")]
    public LogConfig LogConfig { get; set; }

    [DataMember(Name = "NetworkMode", EmitDefaultValue = false)]
    [JsonPropertyName("NetworkMode")]
    public string NetworkMode { get; set; }

    [DataMember(Name = "PortBindings", EmitDefaultValue = false)]
    [JsonPropertyName("PortBindings")]
    public IDictionary<string, IList<PortBinding>> PortBindings { get; set; }

    [DataMember(Name = "RestartPolicy", EmitDefaultValue = false)]
    [JsonPropertyName("RestartPolicy")]
    public RestartPolicy RestartPolicy { get; set; }

    [DataMember(Name = "AutoRemove", EmitDefaultValue = false)]
    [JsonPropertyName("AutoRemove")]
    public bool AutoRemove { get; set; }

    [DataMember(Name = "VolumeDriver", EmitDefaultValue = false)]
    [JsonPropertyName("VolumeDriver")]
    public string VolumeDriver { get; set; }

    [DataMember(Name = "VolumesFrom", EmitDefaultValue = false)]
    [JsonPropertyName("VolumesFrom")]
    public IList<string> VolumesFrom { get; set; }

    [DataMember(Name = "ConsoleSize", EmitDefaultValue = false)]
    [JsonPropertyName("ConsoleSize")]
    public ulong[] ConsoleSize { get; set; }

    [DataMember(Name = "Annotations", EmitDefaultValue = false)]
    [JsonPropertyName("Annotations")]
    public IDictionary<string, string> Annotations { get; set; }

    [DataMember(Name = "CapAdd", EmitDefaultValue = false)]
    [JsonPropertyName("CapAdd")]
    public IList<string> CapAdd { get; set; }

    [DataMember(Name = "CapDrop", EmitDefaultValue = false)]
    [JsonPropertyName("CapDrop")]
    public IList<string> CapDrop { get; set; }

    [DataMember(Name = "CgroupnsMode", EmitDefaultValue = false)]
    [JsonPropertyName("CgroupnsMode")]
    public string CgroupnsMode { get; set; }

    [DataMember(Name = "Dns", EmitDefaultValue = false)]
    [JsonPropertyName("Dns")]
    public IList<string> DNS { get; set; }

    [DataMember(Name = "DnsOptions", EmitDefaultValue = false)]
    [JsonPropertyName("DnsOptions")]
    public IList<string> DNSOptions { get; set; }

    [DataMember(Name = "DnsSearch", EmitDefaultValue = false)]
    [JsonPropertyName("DnsSearch")]
    public IList<string> DNSSearch { get; set; }

    [DataMember(Name = "ExtraHosts", EmitDefaultValue = false)]
    [JsonPropertyName("ExtraHosts")]
    public IList<string> ExtraHosts { get; set; }

    [DataMember(Name = "GroupAdd", EmitDefaultValue = false)]
    [JsonPropertyName("GroupAdd")]
    public IList<string> GroupAdd { get; set; }

    [DataMember(Name = "IpcMode", EmitDefaultValue = false)]
    [JsonPropertyName("IpcMode")]
    public string IpcMode { get; set; }

    [DataMember(Name = "Cgroup", EmitDefaultValue = false)]
    [JsonPropertyName("Cgroup")]
    public string Cgroup { get; set; }

    [DataMember(Name = "Links", EmitDefaultValue = false)]
    [JsonPropertyName("Links")]
    public IList<string> Links { get; set; }

    [DataMember(Name = "OomScoreAdj", EmitDefaultValue = false)]
    [JsonPropertyName("OomScoreAdj")]
    public long OomScoreAdj { get; set; }

    [DataMember(Name = "PidMode", EmitDefaultValue = false)]
    [JsonPropertyName("PidMode")]
    public string PidMode { get; set; }

    [DataMember(Name = "Privileged", EmitDefaultValue = false)]
    [JsonPropertyName("Privileged")]
    public bool Privileged { get; set; }

    [DataMember(Name = "PublishAllPorts", EmitDefaultValue = false)]
    [JsonPropertyName("PublishAllPorts")]
    public bool PublishAllPorts { get; set; }

    [DataMember(Name = "ReadonlyRootfs", EmitDefaultValue = false)]
    [JsonPropertyName("ReadonlyRootfs")]
    public bool ReadonlyRootfs { get; set; }

    [DataMember(Name = "SecurityOpt", EmitDefaultValue = false)]
    [JsonPropertyName("SecurityOpt")]
    public IList<string> SecurityOpt { get; set; }

    [DataMember(Name = "StorageOpt", EmitDefaultValue = false)]
    [JsonPropertyName("StorageOpt")]
    public IDictionary<string, string> StorageOpt { get; set; }

    [DataMember(Name = "Tmpfs", EmitDefaultValue = false)]
    [JsonPropertyName("Tmpfs")]
    public IDictionary<string, string> Tmpfs { get; set; }

    [DataMember(Name = "UTSMode", EmitDefaultValue = false)]
    [JsonPropertyName("UTSMode")]
    public string UTSMode { get; set; }

    [DataMember(Name = "UsernsMode", EmitDefaultValue = false)]
    [JsonPropertyName("UsernsMode")]
    public string UsernsMode { get; set; }

    [DataMember(Name = "ShmSize", EmitDefaultValue = false)]
    [JsonPropertyName("ShmSize")]
    public long ShmSize { get; set; }

    [DataMember(Name = "Sysctls", EmitDefaultValue = false)]
    [JsonPropertyName("Sysctls")]
    public IDictionary<string, string> Sysctls { get; set; }

    [DataMember(Name = "Runtime", EmitDefaultValue = false)]
    [JsonPropertyName("Runtime")]
    public string Runtime { get; set; }

    [DataMember(Name = "Isolation", EmitDefaultValue = false)]
    [JsonPropertyName("Isolation")]
    public string Isolation { get; set; }

    [DataMember(Name = "CpuShares", EmitDefaultValue = false)]
    [JsonPropertyName("CpuShares")]
    public long CPUShares { get; set; }

    [DataMember(Name = "Memory", EmitDefaultValue = false)]
    [JsonPropertyName("Memory")]
    public long Memory { get; set; }

    [DataMember(Name = "NanoCpus", EmitDefaultValue = false)]
    [JsonPropertyName("NanoCpus")]
    public long NanoCPUs { get; set; }

    [DataMember(Name = "CgroupParent", EmitDefaultValue = false)]
    [JsonPropertyName("CgroupParent")]
    public string CgroupParent { get; set; }

    [DataMember(Name = "BlkioWeight", EmitDefaultValue = false)]
    [JsonPropertyName("BlkioWeight")]
    public ushort BlkioWeight { get; set; }

    [DataMember(Name = "BlkioWeightDevice", EmitDefaultValue = false)]
    [JsonPropertyName("BlkioWeightDevice")]
    public IList<WeightDevice> BlkioWeightDevice { get; set; }

    [DataMember(Name = "BlkioDeviceReadBps", EmitDefaultValue = false)]
    [JsonPropertyName("BlkioDeviceReadBps")]
    public IList<ThrottleDevice> BlkioDeviceReadBps { get; set; }

    [DataMember(Name = "BlkioDeviceWriteBps", EmitDefaultValue = false)]
    [JsonPropertyName("BlkioDeviceWriteBps")]
    public IList<ThrottleDevice> BlkioDeviceWriteBps { get; set; }

    [DataMember(Name = "BlkioDeviceReadIOps", EmitDefaultValue = false)]
    [JsonPropertyName("BlkioDeviceReadIOps")]
    public IList<ThrottleDevice> BlkioDeviceReadIOps { get; set; }

    [DataMember(Name = "BlkioDeviceWriteIOps", EmitDefaultValue = false)]
    [JsonPropertyName("BlkioDeviceWriteIOps")]
    public IList<ThrottleDevice> BlkioDeviceWriteIOps { get; set; }

    [DataMember(Name = "CpuPeriod", EmitDefaultValue = false)]
    [JsonPropertyName("CpuPeriod")]
    public long CPUPeriod { get; set; }

    [DataMember(Name = "CpuQuota", EmitDefaultValue = false)]
    [JsonPropertyName("CpuQuota")]
    public long CPUQuota { get; set; }

    [DataMember(Name = "CpuRealtimePeriod", EmitDefaultValue = false)]
    [JsonPropertyName("CpuRealtimePeriod")]
    public long CPURealtimePeriod { get; set; }

    [DataMember(Name = "CpuRealtimeRuntime", EmitDefaultValue = false)]
    [JsonPropertyName("CpuRealtimeRuntime")]
    public long CPURealtimeRuntime { get; set; }

    [DataMember(Name = "CpusetCpus", EmitDefaultValue = false)]
    [JsonPropertyName("CpusetCpus")]
    public string CpusetCpus { get; set; }

    [DataMember(Name = "CpusetMems", EmitDefaultValue = false)]
    [JsonPropertyName("CpusetMems")]
    public string CpusetMems { get; set; }

    [DataMember(Name = "Devices", EmitDefaultValue = false)]
    [JsonPropertyName("Devices")]
    public IList<DeviceMapping> Devices { get; set; }

    [DataMember(Name = "DeviceCgroupRules", EmitDefaultValue = false)]
    [JsonPropertyName("DeviceCgroupRules")]
    public IList<string> DeviceCgroupRules { get; set; }

    [DataMember(Name = "DeviceRequests", EmitDefaultValue = false)]
    [JsonPropertyName("DeviceRequests")]
    public IList<DeviceRequest> DeviceRequests { get; set; }

    [DataMember(Name = "KernelMemory", EmitDefaultValue = false)]
    [JsonPropertyName("KernelMemory")]
    public long KernelMemory { get; set; }

    [DataMember(Name = "KernelMemoryTCP", EmitDefaultValue = false)]
    [JsonPropertyName("KernelMemoryTCP")]
    public long KernelMemoryTCP { get; set; }

    [DataMember(Name = "MemoryReservation", EmitDefaultValue = false)]
    [JsonPropertyName("MemoryReservation")]
    public long MemoryReservation { get; set; }

    [DataMember(Name = "MemorySwap", EmitDefaultValue = false)]
    [JsonPropertyName("MemorySwap")]
    public long MemorySwap { get; set; }

    [DataMember(Name = "MemorySwappiness", EmitDefaultValue = false)]
    [JsonPropertyName("MemorySwappiness")]
    public long? MemorySwappiness { get; set; }

    [DataMember(Name = "OomKillDisable", EmitDefaultValue = false)]
    [JsonPropertyName("OomKillDisable")]
    public bool? OomKillDisable { get; set; }

    [DataMember(Name = "PidsLimit", EmitDefaultValue = false)]
    [JsonPropertyName("PidsLimit")]
    public long? PidsLimit { get; set; }

    [DataMember(Name = "Ulimits", EmitDefaultValue = false)]
    [JsonPropertyName("Ulimits")]
    public IList<Ulimit> Ulimits { get; set; }

    [DataMember(Name = "CpuCount", EmitDefaultValue = false)]
    [JsonPropertyName("CpuCount")]
    public long CPUCount { get; set; }

    [DataMember(Name = "CpuPercent", EmitDefaultValue = false)]
    [JsonPropertyName("CpuPercent")]
    public long CPUPercent { get; set; }

    [DataMember(Name = "IOMaximumIOps", EmitDefaultValue = false)]
    [JsonPropertyName("IOMaximumIOps")]
    public ulong IOMaximumIOps { get; set; }

    [DataMember(Name = "IOMaximumBandwidth", EmitDefaultValue = false)]
    [JsonPropertyName("IOMaximumBandwidth")]
    public ulong IOMaximumBandwidth { get; set; }

    [DataMember(Name = "Mounts", EmitDefaultValue = false)]
    [JsonPropertyName("Mounts")]
    public IList<Mount> Mounts { get; set; }

    [DataMember(Name = "MaskedPaths", EmitDefaultValue = false)]
    [JsonPropertyName("MaskedPaths")]
    public IList<string> MaskedPaths { get; set; }

    [DataMember(Name = "ReadonlyPaths", EmitDefaultValue = false)]
    [JsonPropertyName("ReadonlyPaths")]
    public IList<string> ReadonlyPaths { get; set; }

    [DataMember(Name = "Init", EmitDefaultValue = false)]
    [JsonPropertyName("Init")]
    public bool? Init { get; set; }
}
