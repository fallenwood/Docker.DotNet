namespace Docker.DotNet;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Docker.DotNet.Models;

internal class TasksOperations : ITasksOperations
{
    private readonly DockerClient _client;

    internal TasksOperations(DockerClient client)
    {
        this._client = client;
    }

    Task<IList<TaskResponse>> ITasksOperations.ListAsync(CancellationToken cancellationToken)
    {
        return ((ITasksOperations)this).ListAsync(null, cancellationToken);
    }

    async Task<IList<TaskResponse>> ITasksOperations.ListAsync(TasksListParameters parameters, CancellationToken cancellationToken)
    {
        IQueryString query = null;
        if (parameters != null) {
            query = new QueryString<TasksListParameters>(parameters);
        }

        var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Get, "tasks", query, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize(response.Body, this._client.JsonSerializer.IListTaskResponse);
    }

    async Task<TaskResponse> ITasksOperations.InspectAsync(string id, CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentNullException(nameof(id));
        }

        var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Get, $"tasks/{id}", cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize(response.Body, this._client.JsonSerializer.TaskResponse);
    }
}