using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Docker.DotNet;

internal class JsonVersionConverter : JsonConverter<Version>
{
    public override Version Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var strVal = reader.GetString();
        if (strVal == null)
        {
            var valueType = "<null>";
            throw new InvalidOperationException($"Cannot deserialize value of type '{valueType}' to 'Version' ");
        }

        return Version.Parse(strVal);
    }

    public override void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}