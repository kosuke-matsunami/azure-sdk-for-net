// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error that occurred when autoscaling a pool.
    /// </summary>
    public partial class AutoScaleRunError
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaleRunError class.
        /// </summary>
        public AutoScaleRunError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoScaleRunError class.
        /// </summary>
        /// <param name="code">An identifier for the error. Codes are invariant
        /// and are intended to be consumed programmatically.</param>
        /// <param name="message">A message describing the error, intended to
        /// be suitable for display in a user interface.</param>
        /// <param name="details">Additional details about the error.</param>
        public AutoScaleRunError(string code, string message, IList<AutoScaleRunError> details = default(IList<AutoScaleRunError>))
        {
            Code = code;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an identifier for the error. Codes are invariant and
        /// are intended to be consumed programmatically.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the error, intended to be
        /// suitable for display in a user interface.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets additional details about the error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<AutoScaleRunError> Details { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Details != null)
            {
                foreach (var element in Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}