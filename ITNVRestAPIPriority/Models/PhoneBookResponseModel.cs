using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITNVRestAPIPriority.Models
{
    public class PhoneBookResponseModel
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<PhoneItemFull> value { get; set; }
    }
    public class PhoneItem
    {
        public long PHONE { get; set; }
        public string PHONENUM { get; set; }
        public string CELLPHONE { get; set; }
        public string CUSTNAME { get; set; }
    }
    public class PhoneItemFull
    {
        public int PHONE { get; set; }
        public string NAME { get; set; }
        public string ENAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string GENDER { get; set; }
        public string PHONENUM { get; set; }
        public string OFFICEPHONE { get; set; }
        public string HOMEPHONE { get; set; }
        public string FIRMPHONE { get; set; }
        public string CELLPHONE { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string MAILAPP { get; set; }
        public string FIRM { get; set; }
        public string POSITIONDES { get; set; }
        public string TITLEDES { get; set; }
        public string CUSTNAME { get; set; }
        public string CUSTDES { get; set; }
        public string BUSINESSTYPE { get; set; }
        public double NUMWORKERS { get; set; }
        public object ESTABLISHED { get; set; }
        public double YEARINCOME { get; set; }
        public string AGENTCODE { get; set; }
        public object AGENTNAME { get; set; }
        public object CODE { get; set; }
        public object DCODE { get; set; }
        public object CODEDES { get; set; }
        public string SUPNAME { get; set; }
        public string SUPDES { get; set; }
        public string POSITIONCODE { get; set; }
        public string POSITIONDES2 { get; set; }
        public string CURDATE { get; set; }
        public string DEPARTMENT { get; set; }
        public string PROFESSION { get; set; }
        public string MANAGERNAME { get; set; }
        public string ASSISTANTNAME { get; set; }
        public string ASSISTANTPHONE { get; set; }
        public string BIRTHDATE10 { get; set; }
        public string MAINPHONE { get; set; }
        public string DEALFLAG { get; set; }
        public object CPROFFLAG { get; set; }
        public object ORDFLAG { get; set; }
        public object DOCFLAG { get; set; }
        public object CIVFLAG { get; set; }
        public object TIVFLAG { get; set; }
        public object FNCFLAG { get; set; }
        public object SERVCALLFLAG { get; set; }
        public object CONSINGEEFLAG { get; set; }
        public object GWREGISTERED { get; set; }
        public object NOTIFYFLAG { get; set; }
        public string EXTFILENAME { get; set; }
        public string STATDES { get; set; }
        public string OWNERLOGIN { get; set; }
        public object CTYPECODE { get; set; }
        public string CTYPENAME { get; set; }
        public object CTYPE2CODE { get; set; }
        public string CTYPE2NAME { get; set; }
        public object INACTIVEFLAG { get; set; }
        public int LANG { get; set; }
        public string LANGNAME { get; set; }
        public string FIRMA { get; set; }
        public string NAMEA { get; set; }
    }
}