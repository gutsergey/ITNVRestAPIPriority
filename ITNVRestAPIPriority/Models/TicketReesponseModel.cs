using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITNVRestAPIPriority.Models
{
    public class TicketReesponseModel
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<TicketItem> value { get; set; }
    }
    public class TicketItem
    {
        public string CUSTNAME { get; set; }
        public string CDES { get; set; }
        public string DOCNO { get; set; }
        public object DCODE { get; set; }
        public object CODEDES { get; set; }
        public DateTime STARTDATE { get; set; }
        public object BOOKNUM { get; set; }
        public object PDOCNO { get; set; }
        public string AIRWAYBILL { get; set; }
        public object SERNUM { get; set; }
        public object WARDATEFINAL { get; set; }
        public object CONTNUM { get; set; }
        public object CONTSTATDES { get; set; }
        public object EXPIRYDATE { get; set; }
        public object PROJDOCNO { get; set; }
        public object PROJDES { get; set; }
        public string CALLSTATUSCODE { get; set; }
        public DateTime STATUSDATE { get; set; }
        public string ACTIVEFLAG { get; set; }
        public object PARTNAME { get; set; }
        public object PARTDES { get; set; }
        public object ORDNAME { get; set; }
        public object REFERENCE { get; set; }
        public object RMADOCNO { get; set; }
        public object AGENTCODE { get; set; }
        public object AGENTNAME { get; set; }
        public string SERVTCODE { get; set; }
        public string SERVTDES { get; set; }
        public object MAINTDES { get; set; }
        public object CALLTYPECODE { get; set; }
        public object SYMCODE { get; set; }
        public object SYMDES { get; set; }
        public string MALFCODE { get; set; }
        public string MALFDES { get; set; }
        public object SOLUTIONCODE { get; set; }
        public object SOLUTIONDES { get; set; }
        public object REPEATCALL { get; set; }
        public string SUSERLOGIN { get; set; }
        public int METERREADING { get; set; }
        public object NAME { get; set; }
        public object PHONENUM { get; set; }
        public DateTime CUSTSTARTDATE { get; set; }
        public object MMM_PHONENUM { get; set; }
        public object AUTHORIZERNAME { get; set; }
        public object ASTARTDATE { get; set; }
        public object AENDDATE { get; set; }
        public string RESPONSETIME { get; set; }
        public string ARESPONSETIME { get; set; }
        public double BREAKTIME { get; set; }
        public double CUSTBREAKTIME { get; set; }
        public string RESPONSEHOUR { get; set; }
        public object REQEDATE { get; set; }
        public object SLAFLAG { get; set; }
        public double QPRICE { get; set; }
        public double PERCENT { get; set; }
        public double DISPRICE { get; set; }
        public double VAT { get; set; }
        public double TOTPRICE { get; set; }
        public string CODE { get; set; }
        public double PROFPRICE { get; set; }
        public string CODE2 { get; set; }
        public double MAXREPAIRPRICE { get; set; }
        public object REPAIRCODE { get; set; }
        public string TAXCODE { get; set; }
        public object PLNAME { get; set; }
        public object PDATE { get; set; }
        public object DAY { get; set; }
        public string PTIME { get; set; }
        public object EDATE { get; set; }
        public object EDAY { get; set; }
        public string ETIME { get; set; }
        public int PRIORITY { get; set; }
        public string TECHNICIANLOGIN { get; set; }
        public object TECHNICIANLOGIN2 { get; set; }
        public object TECHNICIANLOGIN3 { get; set; }
        public string WARHSNAME { get; set; }
        public string LOCNAME { get; set; }
        public object ZONECODE { get; set; }
        public object ZONEDES { get; set; }
        public object TRACK { get; set; }
        public object LOCATION { get; set; }
        public object BRANCHNAME { get; set; }
        public object BRANCHDES { get; set; }
        public object STCODE { get; set; }
        public object STDES { get; set; }
        public object DETAILS { get; set; }
        public int KM { get; set; }
        public string FLAG { get; set; }
        public string IVALL { get; set; }
        public object EXTFILEFLAGB { get; set; }
        public DateTime BREAKSTART { get; set; }
        public object BREAKEND { get; set; }
        public double PARTSCOST { get; set; }
        public double WORKCOST { get; set; }
        public object INCUSENUM { get; set; }
        public object SYSTEMCODE { get; set; }
        public object SYSTEMDES { get; set; }
        public object FACILITYNAME { get; set; }
        public object FACILITYDES { get; set; }
        public object SITENAME { get; set; }
        public object SITEDES { get; set; }
        public object GPSX { get; set; }
        public object GPSY { get; set; }
        public object CALCVATFLAG { get; set; }
        public object Y_149_0_ESH { get; set; }
        public object Y_23881_0_ESH { get; set; }
        public object Y_12248_5_ESH { get; set; }
        public object Y_12250_5_ESH { get; set; }
        public int DOC { get; set; }
        public string TYPE { get; set; }
    }
}