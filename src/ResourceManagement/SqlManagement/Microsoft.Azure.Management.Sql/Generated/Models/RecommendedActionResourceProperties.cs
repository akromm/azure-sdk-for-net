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

    public partial class RecommendedActionResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecommendedActionResourceProperties class.
        /// </summary>
        public RecommendedActionResourceProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RecommendedActionResourceProperties class.
        /// </summary>
        public RecommendedActionResourceProperties(string recommendationReason = default(string), System.DateTime? validSince = default(System.DateTime?), System.DateTime? lastRefresh = default(System.DateTime?), StateInfo state = default(StateInfo), bool? isExecutableAction = default(bool?), bool? isRevertableAction = default(bool?), bool? isArchivedAction = default(bool?), System.DateTime? executeActionStartTime = default(System.DateTime?), string executeActionDuration = default(string), System.DateTime? revertActionStartTime = default(System.DateTime?), string revertActionDuration = default(string), string executeActionInitiatedBy = default(string), System.DateTime? executeActionInitiatedTime = default(System.DateTime?), string revertActionInitiatedBy = default(string), System.DateTime? revertActionInitiatedTime = default(System.DateTime?), int? score = default(int?), ImplementationInfo implementationDetails = default(ImplementationInfo), ErrorInfo errorDetails = default(ErrorInfo), System.Collections.Generic.IList<ImpactRecord> estimatedImpact = default(System.Collections.Generic.IList<ImpactRecord>), System.Collections.Generic.IList<ImpactRecord> observedImpact = default(System.Collections.Generic.IList<ImpactRecord>), System.Collections.Generic.IList<MetricInfo> timeSeries = default(System.Collections.Generic.IList<MetricInfo>), System.Collections.Generic.IList<string> linkedObjects = default(System.Collections.Generic.IList<string>), object details = default(object))
        {
            RecommendationReason = recommendationReason;
            ValidSince = validSince;
            LastRefresh = lastRefresh;
            State = state;
            IsExecutableAction = isExecutableAction;
            IsRevertableAction = isRevertableAction;
            IsArchivedAction = isArchivedAction;
            ExecuteActionStartTime = executeActionStartTime;
            ExecuteActionDuration = executeActionDuration;
            RevertActionStartTime = revertActionStartTime;
            RevertActionDuration = revertActionDuration;
            ExecuteActionInitiatedBy = executeActionInitiatedBy;
            ExecuteActionInitiatedTime = executeActionInitiatedTime;
            RevertActionInitiatedBy = revertActionInitiatedBy;
            RevertActionInitiatedTime = revertActionInitiatedTime;
            Score = score;
            ImplementationDetails = implementationDetails;
            ErrorDetails = errorDetails;
            EstimatedImpact = estimatedImpact;
            ObservedImpact = observedImpact;
            TimeSeries = timeSeries;
            LinkedObjects = linkedObjects;
            Details = details;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recommendationReason")]
        public string RecommendationReason { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "validSince")]
        public System.DateTime? ValidSince { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRefresh")]
        public System.DateTime? LastRefresh { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public StateInfo State { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isExecutableAction")]
        public bool? IsExecutableAction { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isRevertableAction")]
        public bool? IsRevertableAction { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isArchivedAction")]
        public bool? IsArchivedAction { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executeActionStartTime")]
        public System.DateTime? ExecuteActionStartTime { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executeActionDuration")]
        public string ExecuteActionDuration { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "revertActionStartTime")]
        public System.DateTime? RevertActionStartTime { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "revertActionDuration")]
        public string RevertActionDuration { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executeActionInitiatedBy")]
        public string ExecuteActionInitiatedBy { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executeActionInitiatedTime")]
        public System.DateTime? ExecuteActionInitiatedTime { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "revertActionInitiatedBy")]
        public string RevertActionInitiatedBy { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "revertActionInitiatedTime")]
        public System.DateTime? RevertActionInitiatedTime { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "score")]
        public int? Score { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "implementationDetails")]
        public ImplementationInfo ImplementationDetails { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorDetails")]
        public ErrorInfo ErrorDetails { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "estimatedImpact")]
        public System.Collections.Generic.IList<ImpactRecord> EstimatedImpact { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "observedImpact")]
        public System.Collections.Generic.IList<ImpactRecord> ObservedImpact { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timeSeries")]
        public System.Collections.Generic.IList<MetricInfo> TimeSeries { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "linkedObjects")]
        public System.Collections.Generic.IList<string> LinkedObjects { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "details")]
        public object Details { get; set; }

    }
}
