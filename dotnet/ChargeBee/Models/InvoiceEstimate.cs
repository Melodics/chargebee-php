using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using ChargeBee.Internal;
using ChargeBee.Api;
using ChargeBee.Models.Enums;

namespace ChargeBee.Models
{

    public class InvoiceEstimate : Resource 
    {
    

        #region Methods
        #endregion
        
        #region Properties
        public bool Recurring 
        {
            get { return GetValue<bool>("recurring", true); }
        }
        public bool CollectNow 
        {
            get { return GetValue<bool>("collect_now", true); }
        }
        public int SubTotal 
        {
            get { return GetValue<int>("sub_total", true); }
        }
        public int? Total 
        {
            get { return GetValue<int?>("total", false); }
        }
        public int? CreditsApplied 
        {
            get { return GetValue<int?>("credits_applied", false); }
        }
        public int? AmountDue 
        {
            get { return GetValue<int?>("amount_due", false); }
        }
        public List<InvoiceEstimateLineItem> LineItems 
        {
            get { return GetResourceList<InvoiceEstimateLineItem>("line_items"); }
        }
        public List<InvoiceEstimateDiscount> Discounts 
        {
            get { return GetResourceList<InvoiceEstimateDiscount>("discounts"); }
        }
        public List<InvoiceEstimateTax> Taxes 
        {
            get { return GetResourceList<InvoiceEstimateTax>("taxes"); }
        }
        
        #endregion
        


        #region Subclasses
        public class InvoiceEstimateLineItem : Resource
        {
            public enum EntityTypeEnum
            {
                UnKnown, /*Indicates unexpected value for this enum. You can get this when there is a
                dotnet-client version incompatibility. We suggest you to upgrade to the latest version */
                [Description("plan_setup")]
                PlanSetup,
                [Description("plan")]
                Plan,
                [Description("addon")]
                Addon,
                [Description("adhoc")]
                Adhoc,
            }

            public DateTime DateFrom() {
                return (DateTime)GetDateTime("date_from", true);
            }

            public DateTime DateTo() {
                return (DateTime)GetDateTime("date_to", true);
            }

            public int UnitAmount() {
                return GetValue<int>("unit_amount", true);
            }

            public int? Quantity() {
                return GetValue<int?>("quantity", false);
            }

            public int? TaxAmount() {
                return GetValue<int?>("tax_amount", false);
            }

            public double? TaxRate() {
                return GetValue<double?>("tax_rate", false);
            }

            public int LineAmount() {
                return GetValue<int>("line_amount", true);
            }

            public int? DiscountAmount() {
                return GetValue<int?>("discount_amount", false);
            }

            public string Description() {
                return GetValue<string>("description", true);
            }

            public EntityTypeEnum EntityType() {
                return GetEnum<EntityTypeEnum>("entity_type", true);
            }

            public string EntityId() {
                return GetValue<string>("entity_id", false);
            }

        }
        public class InvoiceEstimateDiscount : Resource
        {
            public enum TypeEnum
            {
                UnKnown, /*Indicates unexpected value for this enum. You can get this when there is a
                dotnet-client version incompatibility. We suggest you to upgrade to the latest version */
                [Description("coupon")]
                Coupon,
                [Description("credit_adjustment")]
                CreditAdjustment,
                [Description("account_credits")]
                AccountCredits,
            }

            public int Amount() {
                return GetValue<int>("amount", true);
            }

            public string Description() {
                return GetValue<string>("description", false);
            }

            public EntityTypeEnum EntityType() {
                return GetEnum<EntityTypeEnum>("entity_type", true);
            }

            public string EntityId() {
                return GetValue<string>("entity_id", false);
            }

        }
        public class InvoiceEstimateTax : Resource
        {

            public int Amount() {
                return GetValue<int>("amount", true);
            }

            public string Description() {
                return GetValue<string>("description", false);
            }

        }

        #endregion
    }
}
