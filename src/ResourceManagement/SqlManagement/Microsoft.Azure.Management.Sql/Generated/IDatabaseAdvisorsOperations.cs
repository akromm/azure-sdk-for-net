// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// DatabaseAdvisorsOperations operations.
    /// </summary>
    public partial interface IDatabaseAdvisorsOperations
    {
        /// <summary>
        /// Gets list of Azure SQL Database Advisors.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server on which the Azure SQL
        /// Database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ArmErrorResponseMessageException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AdvisorResourceList>> ListWithHttpMessagesAsync(string resourceGroupName, string serverName, string databaseName, Microsoft.Rest.Azure.OData.ODataQuery<AdvisorResource> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<AdvisorResource>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns details of an Azure SQL Database Advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server on which the Azure SQL
        /// Database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='advisorName'>
        /// The name of the Azure SQL Database Advisor.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ArmErrorResponseMessageException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AdvisorResource>> GetWithHttpMessagesAsync(string resourceGroupName, string serverName, string databaseName, string advisorName, Microsoft.Rest.Azure.OData.ODataQuery<AdvisorResource> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<AdvisorResource>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates an Azure SQL Database Advisor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the resource belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server on which the Azure SQL
        /// Database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the Azure SQL Database.
        /// </param>
        /// <param name='advisorName'>
        /// The name of the Azure SQL Database Advisor.
        /// </param>
        /// <param name='advisor'>
        /// The requested advisor resource state.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ArmErrorResponseMessageException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AdvisorResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string serverName, string databaseName, string advisorName, AdvisorResource advisor, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
