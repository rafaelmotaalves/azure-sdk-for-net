// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProviderHubClient.
    /// </summary>
    public static partial class ProviderHubClientExtensions
    {
            /// <summary>
            /// Generates the manifest for the given provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='providerNamespace'>
            /// The name of the resource provider hosted within ProviderHub.
            /// </param>
            public static ResourceProviderManifest GenerateManifest(this IProviderHubClient operations, string providerNamespace)
            {
                return operations.GenerateManifestAsync(providerNamespace).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates the manifest for the given provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='providerNamespace'>
            /// The name of the resource provider hosted within ProviderHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceProviderManifest> GenerateManifestAsync(this IProviderHubClient operations, string providerNamespace, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateManifestWithHttpMessagesAsync(providerNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checkin the manifest.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='providerNamespace'>
            /// The name of the resource provider hosted within ProviderHub.
            /// </param>
            /// <param name='checkinManifestParams'>
            /// The required body parameters supplied to the checkin manifest operation.
            /// </param>
            public static CheckinManifestInfo CheckinManifest(this IProviderHubClient operations, string providerNamespace, CheckinManifestParams checkinManifestParams)
            {
                return operations.CheckinManifestAsync(providerNamespace, checkinManifestParams).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checkin the manifest.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='providerNamespace'>
            /// The name of the resource provider hosted within ProviderHub.
            /// </param>
            /// <param name='checkinManifestParams'>
            /// The required body parameters supplied to the checkin manifest operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckinManifestInfo> CheckinManifestAsync(this IProviderHubClient operations, string providerNamespace, CheckinManifestParams checkinManifestParams, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckinManifestWithHttpMessagesAsync(providerNamespace, checkinManifestParams, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
