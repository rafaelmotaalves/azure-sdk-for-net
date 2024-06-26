// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing the ChaosCapability data model.
    /// Model that represents a Capability resource.
    /// </summary>
    public partial class ChaosCapabilityData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChaosCapabilityData"/>. </summary>
        public ChaosCapabilityData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChaosCapabilityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publisher"> String of the Publisher that this Capability extends. </param>
        /// <param name="targetType"> String of the Target Type that this Capability extends. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="parametersSchema"> URL to retrieve JSON schema of the Capability parameters. </param>
        /// <param name="urn"> String of the URN for this Capability Type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChaosCapabilityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string publisher, string targetType, string description, string parametersSchema, string urn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Publisher = publisher;
            TargetType = targetType;
            Description = description;
            ParametersSchema = parametersSchema;
            Urn = urn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> String of the Publisher that this Capability extends. </summary>
        public string Publisher { get; }
        /// <summary> String of the Target Type that this Capability extends. </summary>
        public string TargetType { get; }
        /// <summary> Localized string of the description. </summary>
        public string Description { get; }
        /// <summary> URL to retrieve JSON schema of the Capability parameters. </summary>
        public string ParametersSchema { get; }
        /// <summary> String of the URN for this Capability Type. </summary>
        public string Urn { get; }
    }
}
