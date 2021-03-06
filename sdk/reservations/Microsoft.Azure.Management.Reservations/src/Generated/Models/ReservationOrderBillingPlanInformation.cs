// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information describing the type of billing plan for this reservation.
    /// </summary>
    public partial class ReservationOrderBillingPlanInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReservationOrderBillingPlanInformation class.
        /// </summary>
        public ReservationOrderBillingPlanInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReservationOrderBillingPlanInformation class.
        /// </summary>
        /// <param name="pricingCurrencyTotal">Amount of money to be paid for
        /// the Order. Tax is not included.</param>
        /// <param name="startDate">Date when the billing plan has
        /// started.</param>
        /// <param name="nextPaymentDueDate">For recurring billing plans,
        /// indicates the date when next payment will be processed. Null when
        /// total is paid off.</param>
        public ReservationOrderBillingPlanInformation(Price pricingCurrencyTotal = default(Price), System.DateTime? startDate = default(System.DateTime?), System.DateTime? nextPaymentDueDate = default(System.DateTime?), IList<PaymentDetail> transactions = default(IList<PaymentDetail>))
        {
            PricingCurrencyTotal = pricingCurrencyTotal;
            StartDate = startDate;
            NextPaymentDueDate = nextPaymentDueDate;
            Transactions = transactions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets amount of money to be paid for the Order. Tax is not
        /// included.
        /// </summary>
        [JsonProperty(PropertyName = "pricingCurrencyTotal")]
        public Price PricingCurrencyTotal { get; set; }

        /// <summary>
        /// Gets or sets date when the billing plan has started.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets for recurring billing plans, indicates the date when
        /// next payment will be processed. Null when total is paid off.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "nextPaymentDueDate")]
        public System.DateTime? NextPaymentDueDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactions")]
        public IList<PaymentDetail> Transactions { get; set; }

    }
}
