using Docker.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Docker.DotNet;

internal class JsonRequestContent<T> : IRequestContent
{
    private readonly MediaTypeHeaderValue JsonMimeType = MediaTypeHeaderValue.Parse("application/json");

    private readonly T _value;
    private readonly JsonTypeInfo<T> _serializer;

    public JsonRequestContent(T val, JsonTypeInfo<T> serializer)
    {
        if (EqualityComparer<T>.Default.Equals(val))
        {
            throw new ArgumentNullException(nameof(val));
        }

        if (serializer == null)
        {
            throw new ArgumentNullException(nameof(serializer));
        }

        this._value = val;
        this._serializer = serializer;
    }

    public HttpContent GetContent()
    {
        var serializedObject = JsonSerializer.Serialize(this._value, this._serializer);
        return new StringContent(serializedObject, Encoding.UTF8, JsonMimeType);
    }
}