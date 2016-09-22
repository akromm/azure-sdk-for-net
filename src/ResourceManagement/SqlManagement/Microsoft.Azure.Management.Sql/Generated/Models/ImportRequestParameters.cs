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
    /// Import Azure SQL Database parameters.
    /// </summary>
    public partial class ImportRequestParameters : ExportRequestParameters
    {
        /// <summary>
        /// Initializes a new instance of the ImportRequestParameters class.
        /// </summary>
        public ImportRequestParameters() { }

        /// <summary>
        /// Initializes a new instance of the ImportRequestParameters class.
        /// </summary>
        /// <param name="storageKeyType">Gets or sets the type of the storage
        /// key to use. Valid values are StorageAccessKey and
        /// SharedAccessKey.</param>
        /// <param name="storageKey">Gets or sets the storage key to
        /// use.</param>
        /// <param name="storageUri">Gets or sets the storage uri to
        /// use.</param>
        /// <param name="administratorLogin">Gets or sets the name of the SQL
        /// administrator.</param>
        /// <param name="administratorLoginPassword">Gets or sets the password
        /// of the SQL administrator.</param>
        /// <param name="authenticationType">Gets or sets the authentication
        /// type.</param>
        /// <param name="databaseName">Gets or sets the name of the Azure SQL
        /// database to import.</param>
        /// <param name="edition">Gets or sets the edition for the Azure Sql
        /// Database being created.</param>
        /// <param name="serviceObjectiveName">Gets or sets the name of the
        /// service objective to assign to the Azure SQL Database.</param>
        /// <param name="maxSizeBytes">Gets or sets the maximum size for the
        /// newly imported database.</param>
        public ImportRequestParameters(string storageKeyType = default(string), string storageKey = default(string), string storageUri = default(string), string administratorLogin = default(string), string administratorLoginPassword = default(string), string authenticationType = default(string), string databaseName = default(string), string edition = default(string), string serviceObjectiveName = default(string), string maxSizeBytes = default(string))
            : base(storageKeyType, storageKey, storageUri, administratorLogin, administratorLoginPassword, authenticationType)
        {
            DatabaseName = databaseName;
            Edition = edition;
            ServiceObjectiveName = serviceObjectiveName;
            MaxSizeBytes = maxSizeBytes;
        }

        /// <summary>
        /// Gets or sets the name of the Azure SQL database to import.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the edition for the Azure Sql Database being created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the name of the service objective to assign to the
        /// Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceObjectiveName")]
        public string ServiceObjectiveName { get; set; }

        /// <summary>
        /// Gets or sets the maximum size for the newly imported database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxSizeBytes")]
        public string MaxSizeBytes { get; set; }

    }
}