namespace Docker.DotNet.Models;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract]
public sealed class UpdateConfig // (container.UpdateConfig)
{
    public UpdateConfig()
    {
    }

    public UpdateConfig(Resources Resources)
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

    [DataMember(Name = "RestartPolicy", EmitDefaultValue = false)]
    [JsonPropertyName("RestartPolicy")]
    public RestartPolicy RestartPolicy { get; set; }
}
