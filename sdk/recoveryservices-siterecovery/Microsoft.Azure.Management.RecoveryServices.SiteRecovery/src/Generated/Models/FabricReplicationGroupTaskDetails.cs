// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This class represents the fabric replication group task details.
    /// </summary>
    public partial class FabricReplicationGroupTaskDetails : JobTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the FabricReplicationGroupTaskDetails
        /// class.
        /// </summary>
        public FabricReplicationGroupTaskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FabricReplicationGroupTaskDetails
        /// class.
        /// </summary>
        /// <param name="jobTask">The job entity.</param>
        /// <param name="skippedReason">The skipped reason.</param>
        /// <param name="skippedReasonString">The skipped reason
        /// string.</param>
        public FabricReplicationGroupTaskDetails(JobEntity jobTask = default(JobEntity), string skippedReason = default(string), string skippedReasonString = default(string))
            : base(jobTask)
        {
            SkippedReason = skippedReason;
            SkippedReasonString = skippedReasonString;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the skipped reason.
        /// </summary>
        [JsonProperty(PropertyName = "skippedReason")]
        public string SkippedReason { get; set; }

        /// <summary>
        /// Gets or sets the skipped reason string.
        /// </summary>
        [JsonProperty(PropertyName = "skippedReasonString")]
        public string SkippedReasonString { get; set; }

    }
}
