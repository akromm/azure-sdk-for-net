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

    public partial class ImplementationInfo
    {
        /// <summary>
        /// Initializes a new instance of the ImplementationInfo class.
        /// </summary>
        public ImplementationInfo() { }

        /// <summary>
        /// Initializes a new instance of the ImplementationInfo class.
        /// </summary>
        public ImplementationInfo(string method = default(string), string script = default(string))
        {
            Method = method;
            Script = script;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "script")]
        public string Script { get; set; }

    }
}