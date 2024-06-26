// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the configuration of traffic analytics. </summary>
    public partial class TrafficAnalyticsConfigurationProperties
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

        /// <summary> Initializes a new instance of <see cref="TrafficAnalyticsConfigurationProperties"/>. </summary>
        public TrafficAnalyticsConfigurationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrafficAnalyticsConfigurationProperties"/>. </summary>
        /// <param name="enabled"> Flag to enable/disable traffic analytics. </param>
        /// <param name="workspaceId"> The resource guid of the attached workspace. </param>
        /// <param name="workspaceRegion"> The location of the attached workspace. </param>
        /// <param name="workspaceResourceId"> Resource Id of the attached workspace. </param>
        /// <param name="trafficAnalyticsIntervalInMinutes"> The interval in minutes which would decide how frequently TA service should do flow analytics. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficAnalyticsConfigurationProperties(bool? enabled, string workspaceId, string workspaceRegion, ResourceIdentifier workspaceResourceId, int? trafficAnalyticsIntervalInMinutes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            WorkspaceId = workspaceId;
            WorkspaceRegion = workspaceRegion;
            WorkspaceResourceId = workspaceResourceId;
            TrafficAnalyticsIntervalInMinutes = trafficAnalyticsIntervalInMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Flag to enable/disable traffic analytics. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The resource guid of the attached workspace. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> The location of the attached workspace. </summary>
        public string WorkspaceRegion { get; set; }
        /// <summary> Resource Id of the attached workspace. </summary>
        public ResourceIdentifier WorkspaceResourceId { get; set; }
        /// <summary> The interval in minutes which would decide how frequently TA service should do flow analytics. </summary>
        public int? TrafficAnalyticsIntervalInMinutes { get; set; }
    }
}
