namespace MercadoPago.Client.PreapprovalPlan
{
    using MercadoPago.Resource.PreapprovalPlan;
    using MercadoPago.Http;
    using MercadoPago.Serialization;
    using System.Threading.Tasks;
    using System.Threading;
    using MercadoPago.Error;

    /// <summary>
    /// Client that use the Preapproval APIs.
    /// </summary>
    public class PreapprovalPlanClient : MercadoPagoClient<PreapprovalPlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreapprovalPlanClient"/> class.
        /// </summary>
        /// <param name="httpClient">The http client that will be used in HTTP requests.</param>
        /// <param name="serializer">
        /// The serializer that will be used to serialize the HTTP requests content
        /// and to deserialize the HTTP response content.
        /// </param>
        public PreapprovalPlanClient(IHttpClient httpClient, ISerializer serializer) : base(httpClient, serializer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreapprovalPlanClient"/> class.
        /// </summary>
        /// <param name="httpClient">The http client that will be used in HTTP requests.</param>
        public PreapprovalPlanClient(IHttpClient httpClient)
            : this(httpClient, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreapprovalPlanClient"/> class.
        /// </summary>
        /// <param name="serializer">
        /// The serializer that will be used to serialize the HTTP requests content
        /// and to deserialize the HTTP response content.
        /// </param>
        public PreapprovalPlanClient(ISerializer serializer)
            : this(null, serializer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreapprovalPlanClient"/> class.
        /// </summary>
        public PreapprovalPlanClient()
            : this(null, null)
        {
        }

        /// <summary>
        /// Creates a Preapproval plan as an asynchronous operation.
        /// </summary>
        /// <param name="request">The data to create a Preapproval plan.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/></param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task whose the result is the created Preapproval.</returns>
        /// <exception cref="MercadoPagoException">If a unexpected exception occurs.</exception>
        /// <exception cref="MercadoPagoApiException">If the API returns a error.</exception>
        /// <remarks>
        /// Check the API documentation
        /// <a href="https://www.mercadopago.com/developers/en/reference/subscriptions/_preapproval/post/">here</a>.
        /// </remarks>
        public Task<PreapprovalPlan> CreateAsync(
            PreapprovalPlanCreateRequest request,
            RequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            return SendAsync("/preapproval_plan", HttpMethod.POST, request, requestOptions, cancellationToken);
        }
    }
}
