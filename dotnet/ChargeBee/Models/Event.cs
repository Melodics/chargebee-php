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

    public class Event : Resource 
    {
    
        public Event() { }

        public Event(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                JObj = JToken.Parse(reader.ReadToEnd());
                apiVersionCheck (JObj);
            }
        }

        public Event(TextReader reader)
        {
            JObj = JToken.Parse(reader.ReadToEnd());
            apiVersionCheck (JObj);    
        }

        public Event(String jsonString)
        {
            JObj = JToken.Parse(jsonString);
            apiVersionCheck (JObj);
        }

        #region Methods
        public static EventListRequest List()
        {
            string url = ApiUtil.BuildUrl("events");
            return new EventListRequest(url);
        }
        public static EntityRequest<Type> Retrieve(string id)
        {
            string url = ApiUtil.BuildUrl("events", CheckNull(id));
            return new EntityRequest<Type>(url, HttpMethod.GET);
        }
        #endregion
        
        #region Properties
        public string Id 
        {
            get { return GetValue<string>("id", true); }
        }
        public DateTime OccurredAt 
        {
            get { return (DateTime)GetDateTime("occurred_at", true); }
        }
        public SourceEnum Source 
        {
            get { return GetEnum<SourceEnum>("source", true); }
        }
        public string User 
        {
            get { return GetValue<string>("user", false); }
        }
        [Obsolete]
        public WebhookStatusEnum WebhookStatus 
        {
            get { return GetEnum<WebhookStatusEnum>("webhook_status", true); }
        }
        [Obsolete]
        public string WebhookFailureReason 
        {
            get { return GetValue<string>("webhook_failure_reason", false); }
        }
        public List<EventWebhook> Webhooks 
        {
            get { return GetResourceList<EventWebhook>("webhooks"); }
        }
        public EventTypeEnum? EventType 
        {
            get { return GetEnum<EventTypeEnum>("event_type", false); }
        }
        public ApiVersionEnum? ApiVersion 
        {
            get { return GetEnum<ApiVersionEnum>("api_version", false); }
        }
        public EventContent Content
        {
            get { return new EventContent(GetValue<JToken>("content")); }
        }
        #endregion
        
        #region Requests
        public class EventListRequest : ListRequest 
        {
            public EventListRequest(string url) 
                    : base(url)
            {
            }

            public EventListRequest Limit(int limit) 
            {
                m_params.AddOpt("limit", limit);
                return this;
            }
            public EventListRequest Offset(string offset) 
            {
                m_params.AddOpt("offset", offset);
                return this;
            }
            public EventListRequest StartTime(long startTime) 
            {
                m_params.AddOpt("start_time", startTime);
                return this;
            }
            public EventListRequest EndTime(long endTime) 
            {
                m_params.AddOpt("end_time", endTime);
                return this;
            }
            public EventListRequest WebhookStatus(WebhookStatusEnum webhookStatus) 
            {
                m_params.AddOpt("webhook_status", webhookStatus);
                return this;
            }
            public EventListRequest EventType(EventTypeEnum eventType) 
            {
                m_params.AddOpt("event_type", eventType);
                return this;
            }
        }
        #endregion

        [Obsolete]
        public enum WebhookStatusEnum
        {

            UnKnown, /*Indicates unexpected value for this enum. You can get this when there is a
            dotnet-client version incompatibility. We suggest you to upgrade to the latest version */
            [Description("not_configured")]
            NotConfigured,
            [Description("scheduled")]
            Scheduled,
            [Description("succeeded")]
            Succeeded,
            [Description("re_scheduled")]
            ReScheduled,
            [Description("failed")]
            Failed,
            [Description("skipped")]
            Skipped,
            [Description("not_applicable")]
            NotApplicable,

        }

        #region Subclasses
        public class EventWebhook : Resource
        {
            public enum WebhookStatusEnum
            {
                UnKnown, /*Indicates unexpected value for this enum. You can get this when there is a
                dotnet-client version incompatibility. We suggest you to upgrade to the latest version */
                [Description("not_configured")]
                NotConfigured,
                [Description("scheduled")]
                Scheduled,
                [Description("succeeded")]
                Succeeded,
                [Description("re_scheduled")]
                ReScheduled,
                [Description("failed")]
                Failed,
                [Description("skipped")]
                Skipped,
                [Description("not_applicable")]
                NotApplicable,
            }

            public string Id() {
                return GetValue<string>("id", true);
            }

            public WebhookStatusEnum WebhookStatus() {
                return GetEnum<WebhookStatusEnum>("webhook_status", true);
            }

        }

        public class EventContent : ResultBase
        {

            public EventContent () { }

            internal EventContent(JToken jobj)
            {
                m_jobj = jobj;
            }
        }
        #endregion
    }
}
