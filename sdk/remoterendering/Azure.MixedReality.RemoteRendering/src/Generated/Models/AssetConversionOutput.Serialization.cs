// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    public partial class AssetConversionOutput
    {
        internal static AssetConversionOutput DeserializeAssetConversionOutput(JsonElement element)
        {
            Optional<string> outputAssetUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputAssetUri"))
                {
                    outputAssetUri = property.Value.GetString();
                    continue;
                }
            }
            return new AssetConversionOutput(outputAssetUri.Value);
        }
    }
}
