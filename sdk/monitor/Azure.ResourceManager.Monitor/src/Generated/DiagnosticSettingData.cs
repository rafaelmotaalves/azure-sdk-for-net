// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing the DiagnosticSetting data model.
    /// The diagnostic setting resource.
    /// </summary>
    public partial class DiagnosticSettingData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DiagnosticSettingData"/>. </summary>
        public DiagnosticSettingData()
        {
            Metrics = new ChangeTrackingList<MetricSettings>();
            Logs = new ChangeTrackingList<LogSettings>();
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticSettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="storageAccountId"> The resource ID of the storage account to which you would like to send Diagnostic Logs. </param>
        /// <param name="serviceBusRuleId"> The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility. </param>
        /// <param name="eventHubAuthorizationRuleId"> The resource Id for the event hub authorization rule. </param>
        /// <param name="eventHubName"> The name of the event hub. If none is specified, the default event hub will be selected. </param>
        /// <param name="metrics"> The list of metric settings. </param>
        /// <param name="logs"> The list of logs settings. </param>
        /// <param name="workspaceId"> The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2. </param>
        /// <param name="marketplacePartnerId"> The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs. </param>
        /// <param name="logAnalyticsDestinationType"> A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics, or use a destination type constructed as follows: &lt;normalized service identity&gt;_&lt;normalized category name&gt;. Possible values are: Dedicated and null (null is default.). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier storageAccountId, ResourceIdentifier serviceBusRuleId, ResourceIdentifier eventHubAuthorizationRuleId, string eventHubName, IList<MetricSettings> metrics, IList<LogSettings> logs, ResourceIdentifier workspaceId, ResourceIdentifier marketplacePartnerId, string logAnalyticsDestinationType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            EventHubAuthorizationRuleId = eventHubAuthorizationRuleId;
            EventHubName = eventHubName;
            Metrics = metrics;
            Logs = logs;
            WorkspaceId = workspaceId;
            MarketplacePartnerId = marketplacePartnerId;
            LogAnalyticsDestinationType = logAnalyticsDestinationType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the storage account to which you would like to send Diagnostic Logs. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary> The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility. </summary>
        public ResourceIdentifier ServiceBusRuleId { get; set; }
        /// <summary> The resource Id for the event hub authorization rule. </summary>
        public ResourceIdentifier EventHubAuthorizationRuleId { get; set; }
        /// <summary> The name of the event hub. If none is specified, the default event hub will be selected. </summary>
        public string EventHubName { get; set; }
        /// <summary> The list of metric settings. </summary>
        public IList<MetricSettings> Metrics { get; }
        /// <summary> The list of logs settings. </summary>
        public IList<LogSettings> Logs { get; }
        /// <summary> The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2. </summary>
        public ResourceIdentifier WorkspaceId { get; set; }
        /// <summary> The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs. </summary>
        public ResourceIdentifier MarketplacePartnerId { get; set; }
        /// <summary> A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics, or use a destination type constructed as follows: &lt;normalized service identity&gt;_&lt;normalized category name&gt;. Possible values are: Dedicated and null (null is default.). </summary>
        public string LogAnalyticsDestinationType { get; set; }
    }
}
