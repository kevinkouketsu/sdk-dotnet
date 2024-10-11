namespace MercadoPago.Client.PreapprovalPlan
{
    /// <summary>
    /// 
    /// </summary>
    public class PreapprovalPlanCreateRequest
    {
        /// <summary>
        /// Return URL.
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// Seller ID.
        /// </summary>
        public long? CollectorId { get; set; }

        /// <summary>
        /// Preapproval plan title.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Recurring data.
        /// </summary>
        public PreapprovalPlanAutoRecurringCreateRequest AutoRecurring { get; set; }
    }
}
