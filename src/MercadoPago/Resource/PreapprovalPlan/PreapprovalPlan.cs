using MercadoPago.Http;
using System;

namespace MercadoPago.Resource.PreapprovalPlan
{
    /// <summary>
    /// Preapproval Plan resource.
    /// </summary>
    /// <remarks>
    /// For more information check the documentation
    /// <a href="https://www.mercadopago.com.br/developers/en/reference/subscriptions/resource/">here</a>
    /// </remarks>
    public class PreapprovalPlan : IResource
    {
        /// <summary>
        /// Preapproval Plan ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Application ID.
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Seller ID.
        /// </summary>
        public long? CollectorId { get; set; }

        /// <summary>
        /// Preapproval title.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Auto recurring
        /// </summary>
        public PreapprovalPlanAutoRecurring AutoRecurring { get; set; }

        /// <summary>
        /// Payment methods enabled at checkout.
        /// </summary>
        public PreapprovalPlanPaymentMethodsAllowed PaymentMethodsAllowed { get; set; }

        /// <summary>
        /// Return URL.
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// Preapproval plan reference value.
        /// </summary>
        public string ExternalReference { get; set; }

        /// <summary>
        /// Preapproval polan checkout link.
        /// </summary>
        public string InitPoint { get; set; }

        /// <summary>
        /// Creation date.
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Last modified date.
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Preapproval status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Subscribed to the plan
        /// </summary>
        public int Subscribed { get; set; }

        /// <summary>
        /// Response from API.
        /// </summary>
        public MercadoPagoResponse ApiResponse { get; set; }
    }
}
