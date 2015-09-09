using System.ComponentModel;

namespace ChargeBee.Models.Enums
{
    public enum EventTypeEnum
    {

        [Description("Unknown Enum")]
        UnKnown, /*Indicates unexpected value for this enum. You can get this when there is a
                dotnet-client version incompatibility. We suggest you to upgrade to the latest version */

        [Description("customer_created")]
         CustomerCreated,

        [Description("customer_changed")]
         CustomerChanged,

        [Description("subscription_created")]
         SubscriptionCreated,

        [Description("subscription_started")]
         SubscriptionStarted,

        [Description("subscription_trial_end_reminder")]
         SubscriptionTrialEndReminder,

        [Description("subscription_activated")]
         SubscriptionActivated,

        [Description("subscription_changed")]
         SubscriptionChanged,

        [Description("subscription_cancellation_scheduled")]
         SubscriptionCancellationScheduled,

        [Description("subscription_cancellation_reminder")]
         SubscriptionCancellationReminder,

        [Description("subscription_cancelled")]
         SubscriptionCancelled,

        [Description("subscription_reactivated")]
         SubscriptionReactivated,

        [Description("subscription_renewed")]
         SubscriptionRenewed,

        [Description("subscription_scheduled_cancellation_removed")]
         SubscriptionScheduledCancellationRemoved,

        [Description("subscription_shipping_address_updated")]
         SubscriptionShippingAddressUpdated,

        [Description("invoice_created")]
         InvoiceCreated,

        [Description("invoice_updated")]
         InvoiceUpdated,

        [Description("invoice_deleted")]
         InvoiceDeleted,

        [Description("subscription_renewal_reminder")]
         SubscriptionRenewalReminder,

        [Description("payment_succeeded")]
         PaymentSucceeded,

        [Description("payment_failed")]
         PaymentFailed,

        [Description("payment_refunded")]
         PaymentRefunded,

        [Description("card_added")]
         CardAdded,

        [Description("card_updated")]
         CardUpdated,

        [Description("card_expiry_reminder")]
         CardExpiryReminder,

        [Description("card_expired")]
         CardExpired,

        [Description("card_deleted")]
         CardDeleted,

    }
}