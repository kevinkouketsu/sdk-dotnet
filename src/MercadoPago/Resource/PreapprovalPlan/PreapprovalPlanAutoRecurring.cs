namespace MercadoPago.Resource.PreapprovalPlan
{
    /// <summary>
    /// Recurring data.
    /// </summary>
    public class PreapprovalPlanAutoRecurring
    {
        /// <summary>
        /// Recurring frequency.
        /// </summary>
        public int? Frequency { get; set; }

        /// <summary>
        /// Recurring frequency type (days or months).
        /// </summary>
        public string FrequencyType { get; set; }

        /// <summary>
        ///  Repetitions
        /// </summary>
        public int Repetitions { get; set; }

        /// <summary>
        /// Billing day
        /// </summary>
        public int BillingDay { get; set; }

        /// <summary>
        /// Billing day proportional
        /// </summary>
        public bool BillingDayProportional { get; set; }

        /// <summary>
        /// Free trial
        /// </summary>
        public PreapprovalPlanFreeTrial FreeTrial { get; set; }

        /// <summary>
        /// Amount paid.
        /// </summary>
        public decimal? TransactionAmount { get; set; }

        /// <summary>
        /// Currency ID.
        /// </summary>
        public string CurrencyId { get; set; }
    }
}
