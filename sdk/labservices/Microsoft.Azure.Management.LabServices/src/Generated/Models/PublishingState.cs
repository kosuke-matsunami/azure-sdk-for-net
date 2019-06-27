// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{

    /// <summary>
    /// Defines values for PublishingState.
    /// </summary>
    public static class PublishingState
    {
        /// <summary>
        /// Initial state of an environment setting.
        /// </summary>
        public const string Draft = "Draft";
        /// <summary>
        /// Currently provisioning resources.
        /// </summary>
        public const string Publishing = "Publishing";
        /// <summary>
        /// All resources are currently provisioned.
        /// </summary>
        public const string Published = "Published";
        /// <summary>
        /// Failed to provision all the necessary resources.
        /// </summary>
        public const string PublishFailed = "PublishFailed";
        /// <summary>
        /// Currently provisioning resources without recreating VM image.
        /// </summary>
        public const string Scaling = "Scaling";
    }
}