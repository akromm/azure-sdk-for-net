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

    public partial class StateInfo
    {
        /// <summary>
        /// Initializes a new instance of the StateInfo class.
        /// </summary>
        public StateInfo() { }

        /// <summary>
        /// Initializes a new instance of the StateInfo class.
        /// </summary>
        public StateInfo(string currentValue = default(string), string actionInitiatedBy = default(string), System.DateTime? lastModified = default(System.DateTime?))
        {
            CurrentValue = currentValue;
            ActionInitiatedBy = actionInitiatedBy;
            LastModified = lastModified;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentValue")]
        public string CurrentValue { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionInitiatedBy")]
        public string ActionInitiatedBy { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

    }
}
