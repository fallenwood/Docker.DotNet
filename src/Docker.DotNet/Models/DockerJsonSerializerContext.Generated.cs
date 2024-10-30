namespace Docker.DotNet.Models;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

[JsonSerializable(typeof(IList<string>))]
[JsonSerializable(typeof(Dictionary<string, string>[]))]
[JsonSerializable(typeof(NetworksDeleteUnusedParameters))]
[JsonSerializable(typeof(GenericResource))]
[JsonSerializable(typeof(NetworkSettings))]
[JsonSerializable(typeof(Privileges))]
[JsonSerializable(typeof(ContainerStatsParameters))]
[JsonSerializable(typeof(JSONError))]
[JsonSerializable(typeof(PluginUpgradeParameters))]
[JsonSerializable(typeof(SecretReferenceFileTarget))]
[JsonSerializable(typeof(TasksListParameters))]
[JsonSerializable(typeof(ContainerStatus))]
[JsonSerializable(typeof(Mount))]
[JsonSerializable(typeof(PluginInterfaceType))]
[JsonSerializable(typeof(PluginRemoveParameters))]
[JsonSerializable(typeof(VolumesPruneResponse))]
[JsonSerializable(typeof(SwarmUpdateConfigParameters))]
[JsonSerializable(typeof(NetworkAttachmentSpec))]
[JsonSerializable(typeof(ContainerAttachParameters))]
[JsonSerializable(typeof(ImagePushParameters))]
[JsonSerializable(typeof(ImageTagParameters))]
[JsonSerializable(typeof(VolumesCreateParameters))]
[JsonSerializable(typeof(DNSConfig))]
[JsonSerializable(typeof(ClusterOptions))]
[JsonSerializable(typeof(ContainerStartParameters))]
[JsonSerializable(typeof(RaftConfig))]
[JsonSerializable(typeof(TaskSpec))]
[JsonSerializable(typeof(ReplicatedService))]
[JsonSerializable(typeof(GlobalService))]
[JsonSerializable(typeof(ContainerExecInspectResponse))]
[JsonSerializable(typeof(NetworksListParameters))]
[JsonSerializable(typeof(EngineDescription))]
[JsonSerializable(typeof(NetworkingConfig))]
[JsonSerializable(typeof(ContainerListResponse[]))][JsonSerializable(typeof(IList<ContainerListResponse>))][JsonSerializable(typeof(ContainerListResponse))]
[JsonSerializable(typeof(JSONMessage))]
[JsonSerializable(typeof(PluginDevice))]
[JsonSerializable(typeof(ConfigReferenceRuntimeTarget))]
[JsonSerializable(typeof(Platform))]
[JsonSerializable(typeof(PortStatus))]
[JsonSerializable(typeof(HealthcheckConfig))]
[JsonSerializable(typeof(NetworkSettingsBase))]
[JsonSerializable(typeof(ContainerRenameParameters))]
[JsonSerializable(typeof(CPUStats))]
[JsonSerializable(typeof(Actor))]
[JsonSerializable(typeof(ReplicatedJob))]
[JsonSerializable(typeof(NetworkAttachment))]
[JsonSerializable(typeof(ContainersPruneResponse))]
[JsonSerializable(typeof(EndpointResource))]
[JsonSerializable(typeof(NetworkConnectParameters))]
[JsonSerializable(typeof(Plugin[]))][JsonSerializable(typeof(Plugin))]
[JsonSerializable(typeof(PluginConfigNetwork))]
[JsonSerializable(typeof(UpdateStatus))]
[JsonSerializable(typeof(HostConfig))]
[JsonSerializable(typeof(Version))]
[JsonSerializable(typeof(VolumeSecret))]
[JsonSerializable(typeof(ContainerPathStatResponse))]
[JsonSerializable(typeof(ThrottlingData))]
[JsonSerializable(typeof(EncryptionConfig))]
[JsonSerializable(typeof(CPUUsage))]
[JsonSerializable(typeof(EndpointSpec))]
[JsonSerializable(typeof(PluginMount))]
[JsonSerializable(typeof(Spec))]
[JsonSerializable(typeof(NodeCSIInfo))]
[JsonSerializable(typeof(ImagesPruneParameters))]
[JsonSerializable(typeof(PluginEnableParameters))]
[JsonSerializable(typeof(Message))]
[JsonSerializable(typeof(PluginConfig))]
[JsonSerializable(typeof(CommitContainerChangesResponse))]
[JsonSerializable(typeof(ContainerInspectParameters))]
[JsonSerializable(typeof(PluginConfigRootfs))]
[JsonSerializable(typeof(VolumesListResponse))]
[JsonSerializable(typeof(SwarmDriver))]
[JsonSerializable(typeof(ServiceUpdateParameters))]
[JsonSerializable(typeof(ImagesCreateParameters))]
[JsonSerializable(typeof(ImagesPruneResponse))]
[JsonSerializable(typeof(GlobalJob))]
[JsonSerializable(typeof(ImageInspectParameters))]
[JsonSerializable(typeof(WeightDevice))]
[JsonSerializable(typeof(EndpointSettings))]
[JsonSerializable(typeof(Health))]
[JsonSerializable(typeof(Address))]
[JsonSerializable(typeof(ContainerListProcessesParameters))]
[JsonSerializable(typeof(ContainerProcessesResponse))]
[JsonSerializable(typeof(ImagesSearchParameters))]
[JsonSerializable(typeof(SwarmJoinParameters))]
[JsonSerializable(typeof(SwarmResources))]
[JsonSerializable(typeof(Topology))]
[JsonSerializable(typeof(IList<Secret>))][JsonSerializable(typeof(Secret))]
[JsonSerializable(typeof(NamedGenericResource))]
[JsonSerializable(typeof(ContainerKillParameters))]
[JsonSerializable(typeof(ConfigReference))]
[JsonSerializable(typeof(PluginInstallParameters))]
[JsonSerializable(typeof(TypeMount))]
[JsonSerializable(typeof(SELinuxContext))]
[JsonSerializable(typeof(SwarmUpdateConfig))]
[JsonSerializable(typeof(AuthResponse))]
[JsonSerializable(typeof(HealthcheckResult))]
[JsonSerializable(typeof(ContainerUpdateParameters))]
[JsonSerializable(typeof(PluginConfigArgs))]
[JsonSerializable(typeof(JobStatus))]
[JsonSerializable(typeof(ImageBuildParameters))]
[JsonSerializable(typeof(TopologyRequirement))]
[JsonSerializable(typeof(TaskDefaults))]
[JsonSerializable(typeof(CredentialSpec))]
[JsonSerializable(typeof(PluginSpec))]
[JsonSerializable(typeof(VolumeAttachment))]
[JsonSerializable(typeof(ContainerJSONBase))]
[JsonSerializable(typeof(NetworkDisconnectParameters))]
[JsonSerializable(typeof(PluginConfigInterface))]
[JsonSerializable(typeof(Placement))]
[JsonSerializable(typeof(DeviceRequest))]
[JsonSerializable(typeof(MountPoint))]
[JsonSerializable(typeof(PluginConfigUser))]
[JsonSerializable(typeof(SwarmInspectResponse))]
[JsonSerializable(typeof(Dictionary<string, AuthConfig>))][JsonSerializable(typeof(AuthConfig))]
[JsonSerializable(typeof(SecretReference))]
[JsonSerializable(typeof(TmpfsOptions))]
[JsonSerializable(typeof(ImageInspectResponse))]
[JsonSerializable(typeof(ServiceCreateParameters))]
[JsonSerializable(typeof(Config))]
[JsonSerializable(typeof(WaitExitError))]
[JsonSerializable(typeof(SecretSpec))]
[JsonSerializable(typeof(ImageBuildResponse))]
[JsonSerializable(typeof(ContainerRestartParameters))]
[JsonSerializable(typeof(ImageHistoryResponse[]))][JsonSerializable(typeof(ImageHistoryResponse))]
[JsonSerializable(typeof(ThrottleDevice))]
[JsonSerializable(typeof(ContainerStopParameters))]
[JsonSerializable(typeof(PlacementPreference))]
[JsonSerializable(typeof(VolumeOptions))]
[JsonSerializable(typeof(Port))]
[JsonSerializable(typeof(PeerInfo))]
[JsonSerializable(typeof(NetworksCreateResponse))]
[JsonSerializable(typeof(PluginGetPrivilegeParameters))]
[JsonSerializable(typeof(Meta))]
[JsonSerializable(typeof(RuntimePluginPrivilege))]
[JsonSerializable(typeof(BindOptions))]
[JsonSerializable(typeof(ContainerStatsResponse))]
[JsonSerializable(typeof(VersionResponse))]
[JsonSerializable(typeof(SwarmInitParameters))]
[JsonSerializable(typeof(ResourceRequirements))]
[JsonSerializable(typeof(NetworkStats))]
[JsonSerializable(typeof(CreateOptions))]
[JsonSerializable(typeof(PluginCreateParameters))]
[JsonSerializable(typeof(IList<SwarmConfig>))][JsonSerializable(typeof(SwarmConfig))]
[JsonSerializable(typeof(PortConfig))]
[JsonSerializable(typeof(PluginDescription))]
[JsonSerializable(typeof(NodeStatus))]
[JsonSerializable(typeof(DeleteResponse))]
[JsonSerializable(typeof(CapacityRange))]
[JsonSerializable(typeof(BlkioStatEntry))]
[JsonSerializable(typeof(ServiceInfo))]
[JsonSerializable(typeof(PluginListParameters))]
[JsonSerializable(typeof(DefaultNetworkSettings))]
[JsonSerializable(typeof(ContainerUpdateResponse))]
[JsonSerializable(typeof(SwarmUnlockResponse))]
[JsonSerializable(typeof(SwarmCreateConfigResponse))]
[JsonSerializable(typeof(ServiceMode))]
[JsonSerializable(typeof(ContainersPruneParameters))]
[JsonSerializable(typeof(ContainerExecCreateParameters))]
[JsonSerializable(typeof(RootFS))]
[JsonSerializable(typeof(IPAM))]
[JsonSerializable(typeof(Endpoint))]
[JsonSerializable(typeof(IList<TaskResponse>))][JsonSerializable(typeof(TaskResponse))]
[JsonSerializable(typeof(NetworkSpec))]
[JsonSerializable(typeof(GraphDriverData))]
[JsonSerializable(typeof(ImageLoadParameters))]
[JsonSerializable(typeof(SwarmConfigReference))]
[JsonSerializable(typeof(ContainerSpec))]
[JsonSerializable(typeof(ServiceSpec))]
[JsonSerializable(typeof(PortBinding))]
[JsonSerializable(typeof(RestartPolicy))]
[JsonSerializable(typeof(Resources))]
[JsonSerializable(typeof(ContainerRemoveParameters))]
[JsonSerializable(typeof(PluginDisableParameters))]
[JsonSerializable(typeof(TypeBlock))]
[JsonSerializable(typeof(ClusterInfo))]
[JsonSerializable(typeof(NetworksCreateParameters))]
[JsonSerializable(typeof(ClusterVolume))]
[JsonSerializable(typeof(ContainerExecStartParameters))]
[JsonSerializable(typeof(ImagesLoadResponse))]
[JsonSerializable(typeof(ImageDeleteParameters))]
[JsonSerializable(typeof(PluginEnv))]
[JsonSerializable(typeof(CAConfig))]
[JsonSerializable(typeof(ExternalCA))]
[JsonSerializable(typeof(SwarmLimit))]
[JsonSerializable(typeof(DeviceMapping))]
[JsonSerializable(typeof(ServiceLogsParameters))]
[JsonSerializable(typeof(ContainerInspectResponse))]
[JsonSerializable(typeof(TaskStatus))]
[JsonSerializable(typeof(ContainerExecCreateResponse))]
[JsonSerializable(typeof(Stats))]
[JsonSerializable(typeof(MemoryStats))]
[JsonSerializable(typeof(UpdateConfig))]
[JsonSerializable(typeof(SwarmService[]))][JsonSerializable(typeof(SwarmService))]
[JsonSerializable(typeof(SeccompOpts))]
[JsonSerializable(typeof(CreateContainerResponse))]
[JsonSerializable(typeof(IPAMConfig))]
[JsonSerializable(typeof(PluginConfigLinux))]
[JsonSerializable(typeof(SwarmRestartPolicy))]
[JsonSerializable(typeof(ServiceStatus))]
[JsonSerializable(typeof(LogConfig))]
[JsonSerializable(typeof(EndpointIPAMConfig))]
[JsonSerializable(typeof(StorageStats))]
[JsonSerializable(typeof(NetworkTask))]
[JsonSerializable(typeof(ConfigReferenceFileTarget))]
[JsonSerializable(typeof(NodeUpdateParameters))]
[JsonSerializable(typeof(ContainerPathStatParameters))]
[JsonSerializable(typeof(ContainerState))]
[JsonSerializable(typeof(PluginSettings))]
[JsonSerializable(typeof(UsageData))]
[JsonSerializable(typeof(SwarmCreateConfigParameters))]
[JsonSerializable(typeof(AppArmorOpts))]
[JsonSerializable(typeof(Driver))]
[JsonSerializable(typeof(NetworkResponse[]))][JsonSerializable(typeof(NetworkResponse))]
[JsonSerializable(typeof(DispatcherConfig))]
[JsonSerializable(typeof(CreateContainerParameters))]
[JsonSerializable(typeof(NodeListResponse[]))][JsonSerializable(typeof(NodeListResponse))]
[JsonSerializable(typeof(ContainerFileSystemChangeResponse[]))][JsonSerializable(typeof(IList<ContainerFileSystemChangeResponse>))][JsonSerializable(typeof(ContainerFileSystemChangeResponse))]
[JsonSerializable(typeof(SwarmIPAMConfig))]
[JsonSerializable(typeof(NodeDescription))]
[JsonSerializable(typeof(ContainerLogsParameters))]
[JsonSerializable(typeof(NetworksPruneResponse))]
[JsonSerializable(typeof(VolumeTopology))]
[JsonSerializable(typeof(NetworkAttachmentConfig))]
[JsonSerializable(typeof(ContainerEventsParameters))]
[JsonSerializable(typeof(JSONProgress))]
[JsonSerializable(typeof(VolumesPruneParameters))]
[JsonSerializable(typeof(SwarmUpdateParameters))]
[JsonSerializable(typeof(SwarmUnlockParameters))]
[JsonSerializable(typeof(ServiceListParameters))]
[JsonSerializable(typeof(Network))]
[JsonSerializable(typeof(VolumesListParameters))]
[JsonSerializable(typeof(SecretCreateResponse))]
[JsonSerializable(typeof(EndpointVirtualIP))]
[JsonSerializable(typeof(ContainersListParameters))]
[JsonSerializable(typeof(ContainerWaitResponse))]
[JsonSerializable(typeof(VolumeResponse))]
[JsonSerializable(typeof(ContainerNode))]
[JsonSerializable(typeof(Metadata))]
[JsonSerializable(typeof(PluginConfigureParameters))]
[JsonSerializable(typeof(SwarmLeaveParameters))]
[JsonSerializable(typeof(TLSInfo))]
[JsonSerializable(typeof(SwarmConfigSpec))]
[JsonSerializable(typeof(SpreadOver))]
[JsonSerializable(typeof(CommitContainerChangesParameters))]
[JsonSerializable(typeof(ImageSearchResponse[]))][JsonSerializable(typeof(IList<ImageSearchResponse>))][JsonSerializable(typeof(ImageSearchResponse))]
[JsonSerializable(typeof(ComponentVersion))]
[JsonSerializable(typeof(ClusterVolumeSpec))]
[JsonSerializable(typeof(VolumeInfo))]
[JsonSerializable(typeof(DiscreteGenericResource))]
[JsonSerializable(typeof(ManagerStatus))]
[JsonSerializable(typeof(Ulimit))]
[JsonSerializable(typeof(SummaryNetworkSettings))]
[JsonSerializable(typeof(ContainerResizeParameters))]
[JsonSerializable(typeof(PidsStats))]
[JsonSerializable(typeof(PluginPrivilege[]))][JsonSerializable(typeof(IList<PluginPrivilege>))][JsonSerializable(typeof(PluginPrivilege))]
[JsonSerializable(typeof(PublishStatus))]
[JsonSerializable(typeof(Annotations))]
[JsonSerializable(typeof(BlkioStats))]
[JsonSerializable(typeof(AccessMode))]
[JsonSerializable(typeof(OrchestrationConfig))]
[JsonSerializable(typeof(JoinTokens))]
[JsonSerializable(typeof(IPAMOptions))]
public sealed partial class DockerJsonSerializerContext : JsonSerializerContext
{
}
