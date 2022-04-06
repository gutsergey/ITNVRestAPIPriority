using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITNVRestAPIPriority.Models
{
    public class ExistingCustResponseModel
    {
            [JsonProperty("@odata.context")]
            public string OdataContext { get; set; }
            public string SUBJECT { get; set; }
            public string USERLOGIN { get; set; }
            public DateTime CURDATE { get; set; }
            public string DAY { get; set; }
            public string STIME { get; set; }
            public string CUSTNAME { get; set; }
            public string CUSTDES { get; set; }
            public string TOPICCODE { get; set; }
            public string TOPICDES { get; set; }
            public object CUSTNOTETYPEDES { get; set; }
            public string CAMPAIGNCODE { get; set; }
            public string CAMPAIGNDES { get; set; }
            public object CCNUM { get; set; }
            public DateTime TILLDATE { get; set; }
            public string TILLDAY { get; set; }
            public string ETIME { get; set; }
            public string STATDES { get; set; }
            public object CLOSED { get; set; }
            public DateTime STATUSDATE { get; set; }
            public object CLOSEDATE { get; set; }
            public int PRIO { get; set; }
            public int CUSTNOTE { get; set; }
            public string NAME { get; set; }
            public string PLANNEDTIME { get; set; }
            public string PHONENUM { get; set; }
            public string CELLPHONE { get; set; }
            public object EMAIL { get; set; }
            public object LOCATION { get; set; }
            public object CTYPECODE { get; set; }
            public object CTYPENAME { get; set; }
            public object DCODE { get; set; }
            public object CODEDES { get; set; }
            public object PHONE { get; set; }
            public object SUPNAME { get; set; }
            public object SUPDES { get; set; }
            public object SUPPHONE { get; set; }
            public object SNAME { get; set; }
            public object SPHONENUM { get; set; }
            public object SCELLPHONE { get; set; }
            public string OUSERLOGIN { get; set; }
            public string BRANCHNAME { get; set; }
            public string BRANCHDES { get; set; }
            public object IVDES { get; set; }
            public object TODOREFA { get; set; }
            public object PROJDOCNO { get; set; }
            public object PROJDES { get; set; }
            public object WBS { get; set; }
            public int PROJACT { get; set; }
            public object ACTDES { get; set; }
            public object ADDRESS { get; set; }
            public object STATE { get; set; }
            public string AGENTCODE { get; set; }
            public string AGENTNAME { get; set; }
            public DateTime OUDATE { get; set; }
            public object CUDATE { get; set; }
            public object REMINDFLAG { get; set; }
            public string REMINDTIME { get; set; }
            public object USERLOGIN2 { get; set; }
            public object USERLOGIN3 { get; set; }
            public object USERLOGIN4 { get; set; }
            public object USERLOGIN5 { get; set; }
            public object USERLOGIN6 { get; set; }
            public object GROUPNAME { get; set; }
            public object GROUPDES { get; set; }
            public object GROUPNAME2 { get; set; }
            public object GROUPDES2 { get; set; }
            public object GROUPNAME3 { get; set; }
            public object GROUPDES3 { get; set; }
            public object EXTFILEFLAG { get; set; }
            public object RESOURCENAME { get; set; }
            public object RESOURCENAME2 { get; set; }
            public object RESOURCENAME3 { get; set; }
            public object ORIGDATE { get; set; }
            public object REMARK { get; set; }
            public int PREVCUSTNOTE { get; set; }
            public object BILLINGUSERLOGIN { get; set; }
            public object QUESTFCODE { get; set; }
            public object QUESTFDES { get; set; }
            public DateTime UDATE { get; set; }
            public string MUSERNAME { get; set; }
    }
}