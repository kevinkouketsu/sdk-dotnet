using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoPago.Resource.PreapprovalPlan
{
    /// <summary>
    /// Payment methods enabled at checkout.
    /// </summary>
    public class PreapprovalPlanPaymentMethodsAllowed
    {
        /// <summary>
        /// 
        /// </summary>
        public PreapprovalPlanPaymentTypes[] PaymentTypes { get; set; }
    }
}
