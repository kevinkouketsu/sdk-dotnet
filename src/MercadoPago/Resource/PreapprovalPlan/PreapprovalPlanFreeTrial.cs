namespace MercadoPago.Resource.PreapprovalPlan
{
    /// <summary>
    /// Pre approval plan free trial
    /// </summary>
    public class PreapprovalPlanFreeTrial
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
