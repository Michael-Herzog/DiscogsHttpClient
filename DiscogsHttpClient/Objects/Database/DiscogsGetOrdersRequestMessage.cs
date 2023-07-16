using Discogs.Objects.Common;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Discogs.Objects.Database
{
    public class DiscogsGetOrdersRequestMessage : DiscogsPaginationRequest
    {
        /// <summary>
        /// Only show orders with this status. 
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderStatus Status { get; set; } = OrderStatus.All;

        /// <summary>
        /// Only show orders created after this time.
        /// </summary>
        [JsonProperty("created_after", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CreatedAfter { get; set; }

        /// <summary>
        /// Only show orders created before this time.
        /// </summary>
        [JsonProperty("created_before", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CreatedBefore { get; set; }

        /// <summary>
        /// The country to filter (Example: Belgium)
        /// </summary>
        [JsonProperty("archived", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Archived { get; set; }

        [JsonProperty("sort")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderSort SortBy { get; set; }

        [JsonProperty("sort_order")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DiscogsSortOrder SortOrder { get; set; }
    }

    public enum OrderStatus
    {
        [EnumMember(Value = "All")]
        All,

        [EnumMember(Value = "New Order")]
        NewOrder,

        [EnumMember(Value = "Buyer Contacted")]
        BuyerContacted,

        [EnumMember(Value = "Invoice Sent")]
        InvoiceSent,

        [EnumMember(Value = "Payment Pending")]
        PaymentPending,

        [EnumMember(Value = "Payment Received In Progress Shipped")]
        PaymentReceivedInProgressShipped,

        [EnumMember(Value = "Merged")]
        Merged,

        [EnumMember(Value = "Order Changed")]
        OrderChanged,

        [EnumMember(Value = "Refund Sent")]
        RefundSent,

        [EnumMember(Value = "Cancelled")]
        Cancelled,

        [EnumMember(Value = "Cancelled (Non-Paying Buyer)")]
        CancelledNonPayingBuyer,

        [EnumMember(Value = "Cancelled (Item Unavailable)")]
        CancelledItemUnavailable,

        [EnumMember(Value = "Cancelled (Per Buyer's Request) Cancelled (Refund Received)")]
        CancelledPerBuyersRequestCancelledRefundReceived
    }

    public enum OrderSort
    {
        [EnumMember(Value = "id")]
        Id,

        [EnumMember(Value = "buyer")]
        Buyer,

        [EnumMember(Value = "created")]
        Created,

        [EnumMember(Value = "status")]
        Status,

        [EnumMember(Value = "last_activity")]
        LastActivity
    }
}