// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{

    /// <summary>
    /// Defines values for ImportExportOperationStatus.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportExportOperationStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = "Running")]
        Running,
        [System.Runtime.Serialization.EnumMember(Value = "RunningAfterRestart")]
        RunningAfterRestart,
        [System.Runtime.Serialization.EnumMember(Value = "Pending")]
        Pending,
        [System.Runtime.Serialization.EnumMember(Value = "Completed")]
        Completed,
        [System.Runtime.Serialization.EnumMember(Value = "Failed")]
        Failed
    }
}