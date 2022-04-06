using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITNVRestAPIPriority.Models
{
    public class CampaignResponseModel
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<CampaignItem> value { get; set; }
    }
    public class CampaignItem
    {
        public string CAMPAIGNCODE { get; set; }
        public string CAMPAIGNDES { get; set; }
        public object ECAMPAIGNDES { get; set; }
        public object SDATE { get; set; }
        public object EDATE { get; set; }
        public object CANCEL { get; set; }
        public object FINAL { get; set; }
        public int CAMPAIGN { get; set; }
    }
}