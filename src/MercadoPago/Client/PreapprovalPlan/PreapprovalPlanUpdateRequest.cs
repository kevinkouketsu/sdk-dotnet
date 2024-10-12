namespace MercadoPago.Client.PreapprovalPlan
{
    /// <summary>
    /// 
    /// </summary>
    public class PreapprovalPlanUpdateRequest
    {
        /// <summary>
        /// Return URL.
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// Preapproval plan title.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Recurring data.
        /// </summary>
        public PreapprovalPlanAutoRecurringUpdateRequest AutoRecurring { get; set; }
    }
}
