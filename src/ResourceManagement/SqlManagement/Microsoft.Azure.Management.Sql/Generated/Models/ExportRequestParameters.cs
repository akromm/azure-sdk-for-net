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
    /// Export Azure SQL Database parameters.
    /// </summary>
    public partial class ExportRequestParameters
    {
        /// <summary>
        /// Initializes a new instance of the ExportRequestParameters class.
        /// </summary>
        public ExportRequestParameters() { }

        /// <summary>
        /// Initializes a new instance of the ExportRequestParameters class.
        /// </summary>
        /// <param name="storageKeyType">The type of the storage key to use.
        /// Possible values include: 'StorageAccessKey',
        /// 'SharedAccessKey'</param>
        /// <param name="storageKey">The storage key to use.</param>
        /// <param name="storageUri">The storage uri to use.</param>
        /// <param name="administratorLogin">The name of the SQL
        /// administrator.</param>
        /// <param name="administratorLoginPassword">The password of the SQL
        /// administrator.</param>
        /// <param name="authenticationType">The authentication type.</param>
        public ExportRequestParameters(StorageKeyType? storageKeyType = default(StorageKeyType?), string storageKey = default(string), string storageUri = default(string), string administratorLogin = default(string), string administratorLoginPassword = default(string), string authenticationType = default(string))
        {
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            AuthenticationType = authenticationType;
        }

        /// <summary>
        /// Gets or sets the type of the storage key to use. Possible values
        /// include: 'StorageAccessKey', 'SharedAccessKey'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageKeyType")]
        public StorageKeyType? StorageKeyType { get; set; }

        /// <summary>
        /// Gets or sets the storage key to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageKey")]
        public string StorageKey { get; set; }

        /// <summary>
        /// Gets or sets the storage uri to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageUri")]
        public string StorageUri { get; set; }

        /// <summary>
        /// Gets or sets the name of the SQL administrator.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the password of the SQL administrator.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets the authentication type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "authenticationType")]
        public string AuthenticationType { get; set; }

    }
}
