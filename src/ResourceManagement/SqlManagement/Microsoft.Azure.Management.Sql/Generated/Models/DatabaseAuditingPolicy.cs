// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database auditing policy.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DatabaseAuditingPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseAuditingPolicy class.
        /// </summary>
        public DatabaseAuditingPolicy() { }

        /// <summary>
        /// Initializes a new instance of the DatabaseAuditingPolicy class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="useServerDefault">Indicates whether the default
        /// server auditing policy is used for that Azure SQL
        /// Database.</param>
        /// <param name="auditingState">Gets the auditing state of the Azure
        /// SQL Server auditing policy.</param>
        /// <param name="eventTypesToAudit">Gets the events types of the Azure
        /// SQL Server auditing policy.</param>
        /// <param name="storageAccountName">Gets the storage account name of
        /// the Azure SQL Server auditing policy.</param>
        /// <param name="storageAccountKey">Gets the primary storage account
        /// key of the Azure SQL Server auditing policy.</param>
        /// <param name="storageAccountSecondaryKey">Gets secondary key of the
        /// storage account of the Azure SQL Server auditing policy.</param>
        /// <param name="storageTableEndpoint">Gets the storage table endpoint
        /// of the Azure SQL Server auditing policy.</param>
        /// <param name="storageAccountResourceGroupName">Gets the resource
        /// group of the storage account of the Azure SQL Server auditing
        /// policy.</param>
        /// <param name="storageAccountSubscriptionId">Gets the subscription
        /// Id of the storage account of the Azure SQL Server auditing
        /// policy.</param>
        /// <param name="retentionDays">Gets the retention in days of the
        /// Azure SQL Database auditing policy.</param>
        /// <param name="auditLogsTableName">Gets the name of the table audit
        /// logs are written to in the Azure SQL Database auditing
        /// policy.</param>
        /// <param name="fullAuditLogsTableName">Gets the full name of the
        /// table audit logs are written to in the Azure SQL Database
        /// auditing policy.</param>
        public DatabaseAuditingPolicy(string location, string name = default(string), string id = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string useServerDefault = default(string), string auditingState = default(string), string eventTypesToAudit = default(string), string storageAccountName = default(string), string storageAccountKey = default(string), string storageAccountSecondaryKey = default(string), string storageTableEndpoint = default(string), string storageAccountResourceGroupName = default(string), string storageAccountSubscriptionId = default(string), string retentionDays = default(string), string auditLogsTableName = default(string), string fullAuditLogsTableName = default(string))
            : base(location, name, id, type, tags)
        {
            UseServerDefault = useServerDefault;
            AuditingState = auditingState;
            EventTypesToAudit = eventTypesToAudit;
            StorageAccountName = storageAccountName;
            StorageAccountKey = storageAccountKey;
            StorageAccountSecondaryKey = storageAccountSecondaryKey;
            StorageTableEndpoint = storageTableEndpoint;
            StorageAccountResourceGroupName = storageAccountResourceGroupName;
            StorageAccountSubscriptionId = storageAccountSubscriptionId;
            RetentionDays = retentionDays;
            AuditLogsTableName = auditLogsTableName;
            FullAuditLogsTableName = fullAuditLogsTableName;
        }

        /// <summary>
        /// Gets or sets indicates whether the default server auditing policy
        /// is used for that Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.useServerDefault")]
        public string UseServerDefault { get; set; }

        /// <summary>
        /// Gets the auditing state of the Azure SQL Server auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.auditingState")]
        public string AuditingState { get; set; }

        /// <summary>
        /// Gets the events types of the Azure SQL Server auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.eventTypesToAudit")]
        public string EventTypesToAudit { get; set; }

        /// <summary>
        /// Gets the storage account name of the Azure SQL Server auditing
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// Gets the primary storage account key of the Azure SQL Server
        /// auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountKey")]
        public string StorageAccountKey { get; set; }

        /// <summary>
        /// Gets secondary key of the storage account of the Azure SQL Server
        /// auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountSecondaryKey")]
        public string StorageAccountSecondaryKey { get; set; }

        /// <summary>
        /// Gets the storage table endpoint of the Azure SQL Server auditing
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageTableEndpoint")]
        public string StorageTableEndpoint { get; set; }

        /// <summary>
        /// Gets the resource group of the storage account of the Azure SQL
        /// Server auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountResourceGroupName")]
        public string StorageAccountResourceGroupName { get; set; }

        /// <summary>
        /// Gets the subscription Id of the storage account of the Azure SQL
        /// Server auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountSubscriptionId")]
        public string StorageAccountSubscriptionId { get; set; }

        /// <summary>
        /// Gets the retention in days of the Azure SQL Database auditing
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.retentionDays")]
        public string RetentionDays { get; set; }

        /// <summary>
        /// Gets the name of the table audit logs are written to in the Azure
        /// SQL Database auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.auditLogsTableName")]
        public string AuditLogsTableName { get; set; }

        /// <summary>
        /// Gets the full name of the table audit logs are written to in the
        /// Azure SQL Database auditing policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fullAuditLogsTableName")]
        public string FullAuditLogsTableName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
