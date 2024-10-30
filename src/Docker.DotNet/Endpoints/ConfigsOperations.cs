namespace Docker.DotNet;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Docker.DotNet.Models;

internal class ConfigOperations : IConfigOperations
{
    private readonly DockerClient _client;

    internal ConfigOperations(DockerClient client)
    {
        this._client = client;
    }

    async Task<IList<SwarmConfig>> IConfigOperations.ListConfigsAsync(CancellationToken cancellationToken)
    {
        var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Get, "configs", cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize(response.Body, this._client.JsonSerializer.IListSwarmConfig);
    }

    async Task<SwarmCreateConfigResponse> IConfigOperations.CreateConfigAsync(SwarmCreateConfigParameters body, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(body);

        var data = new JsonRequestContent<SwarmConfigSpec>(body.Config, this._client.JsonSerializer.SwarmConfigSpec);
        var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Post, "configs/create", null, data, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize(response.Body, this._client.JsonSerializer.SwarmCreateConfigResponse);
    }

    async Task<SwarmConfig> IConfigOperations.InspectConfigAsync(string id, CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentNullException(nameof(id));
        }

        var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Get, $"configs/{id}", cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize(response.Body, this._client.JsonSerializer.SwarmConfig);
    }

    Task IConfigOperations.RemoveConfigAsync(string id, CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentNullException(nameof(id));
        }

        return this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Delete, $"configs/{id}", cancellationToken);
    }
}
