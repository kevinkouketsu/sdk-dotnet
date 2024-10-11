namespace MercadoPago.Client.PreapprovalPlan
{
    /// <summary>
    /// Free trial
    /// </summary>
    public class PreapprovalPlanFreeTrialCreateRequest
    {
        /// <summary>
        /// Recurring frequency.
        /// </summary>
        public int? Frequency { get; set; }

        /// <summary>
        /// Recurring frequency type (days or months).
        /// </summary>
        public string FrequencyType { get; set; }
    }
}
