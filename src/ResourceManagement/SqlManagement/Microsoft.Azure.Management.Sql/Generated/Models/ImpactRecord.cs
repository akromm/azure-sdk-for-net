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

    public partial class ImpactRecord
    {
        /// <summary>
        /// Initializes a new instance of the ImpactRecord class.
        /// </summary>
        public ImpactRecord() { }

        /// <summary>
        /// Initializes a new instance of the ImpactRecord class.
        /// </summary>
        public ImpactRecord(string dimensionName = default(string), string unit = default(string), double? absoluteValue = default(double?), double? changeValueAbsolute = default(double?), double? changeValueRelative = default(double?))
        {
            DimensionName = dimensionName;
            Unit = unit;
            AbsoluteValue = absoluteValue;
            ChangeValueAbsolute = changeValueAbsolute;
            ChangeValueRelative = changeValueRelative;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dimensionName")]
        public string DimensionName { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "absoluteValue")]
        public double? AbsoluteValue { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "changeValueAbsolute")]
        public double? ChangeValueAbsolute { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "changeValueRelative")]
        public double? ChangeValueRelative { get; set; }

    }
}
