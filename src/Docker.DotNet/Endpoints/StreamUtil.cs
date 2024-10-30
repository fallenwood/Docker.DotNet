namespace Docker.DotNet.Models;

using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

internal static class StreamUtil
{
    internal static async Task MonitorStreamAsync(Task<Stream> streamTask, DockerClient client, CancellationToken cancellationToken, IProgress<string> progress)
    {
        var tcs = new TaskCompletionSource<string>();

        using (var stream = await streamTask)
        using (var reader = new StreamReader(stream, new UTF8Encoding(false)))
        using (cancellationToken.Register(() => tcs.TrySetCanceled(cancellationToken)))
        {
            string line;
            while ((line = await await Task.WhenAny(reader.ReadLineAsync(), tcs.Task)) != null)
            {
                progress.Report(line);
            }
        }
    }

    internal static async Task MonitorStreamForMessagesAsync<T>(Task<Stream> streamTask, DockerClient client, CancellationToken cancellationToken, IProgress<T> progress, JsonTypeInfo<T> jsonPropertyInfo)
    {
        var tcs = new TaskCompletionSource<bool>();

        using (var stream = await streamTask)
        using (var reader = new StreamReader(stream, new UTF8Encoding(false)))
        //using (var jsonReader = new JsonTextReader(reader) { SupportMultipleContent = true })
        using (cancellationToken.Register(() => tcs.TrySetCanceled(cancellationToken)))
        {
            //while (await await Task.WhenAny(jsonReader.ReadAsync(cancellationToken), tcs.Task))
            //{
            var events = JsonSerializer.DeserializeAsyncEnumerable(stream, jsonPropertyInfo, cancellationToken);

            await foreach (var ev in events)
            {
                progress.Report(ev);
            }
            //}
        }
    }

    internal static async Task MonitorResponseForMessagesAsync<T>(Task<HttpResponseMessage> responseTask, DockerClient client, CancellationToken cancel, IProgress<T> progress, JsonTypeInfo<T> jsonPropertyInfo)
    {
        using (var response = await responseTask)
        {
            await MonitorStreamForMessagesAsync<T>(response.Content.ReadAsStreamAsync(), client, cancel, progress, jsonPropertyInfo);
        }
    }
}
