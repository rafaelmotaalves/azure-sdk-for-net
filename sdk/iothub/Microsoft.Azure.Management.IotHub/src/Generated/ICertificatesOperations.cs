// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CertificatesOperations operations.
    /// </summary>
    public partial interface ICertificatesOperations
    {
        /// <summary>
        /// Get the certificate list.
        /// </summary>
        /// <remarks>
        /// Returns the list of certificates.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateListDescription>> ListByIotHubWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the certificate.
        /// </summary>
        /// <remarks>
        /// Returns the certificate.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='certificateName'>
        /// The name of the certificate
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateDescription>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string certificateName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Upload the certificate to the IoT hub.
        /// </summary>
        /// <remarks>
        /// Adds new or replaces existing certificate.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='certificateName'>
        /// The name of the certificate
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Certificate. Do not specify for creating a brand new
        /// certificate. Required to update an existing certificate.
        /// </param>
        /// <param name='certificate'>
        /// base-64 representation of the X509 leaf certificate .cer file or
        /// just .pem file content.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateDescription>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string certificateName, string ifMatch = default(string), string certificate = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an X509 certificate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing X509 certificate or does nothing if it does not
        /// exist.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='certificateName'>
        /// The name of the certificate
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string certificateName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate verification code for proof of possession flow.
        /// </summary>
        /// <remarks>
        /// Generates verification code for proof of possession flow. The
        /// verification code will be used to generate a leaf certificate.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='certificateName'>
        /// The name of the certificate
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateWithNonceDescription>> GenerateVerificationCodeWithHttpMessagesAsync(string resourceGroupName, string resourceName, string certificateName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Verify certificate's private key possession.
        /// </summary>
        /// <remarks>
        /// Verifies the certificate's private key possession by providing the
        /// leaf cert issued by the verifying pre uploaded certificate.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='certificateName'>
        /// The name of the certificate
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Certificate.
        /// </param>
        /// <param name='certificate'>
        /// base-64 representation of X509 certificate .cer file or just .pem
        /// file content.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateDescription>> VerifyWithHttpMessagesAsync(string resourceGroupName, string resourceName, string certificateName, string ifMatch, string certificate = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
