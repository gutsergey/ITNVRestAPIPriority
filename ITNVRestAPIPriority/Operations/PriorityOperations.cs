using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using ITNVRestAPIPriority.Models;
using ITNVRestAPIPriority.App_Conf;
namespace ITNVRestAPIPriority.Operations
{
    public class PriorityOperations
    {
        HttpRequest http;

        public PriorityOperations()
        {
            this.http = new HttpRequest(ItnvConfiguration.Instance.PriorityUser, ItnvConfiguration.Instance.PriorityPwd, ItnvConfiguration.Instance.PriorityURL);
        }
        public List<PhoneItemFull> GetPhones()
        {
            //string s = http.GetRequest("PHONEBOOK?$select=PHONE,PHONENUM,CELLPHONE,CUSTNAME");
            string s = http.GetRequest("PHONEBOOK");

            PhoneBookResponseModel phonebook = JsonConvert.DeserializeObject<PhoneBookResponseModel>(s);
            List<PhoneItemFull> phoneitems = phonebook.value;
            return phoneitems;
        }

        public PhoneItemFull GetPhones(string phonenumber)
        {
            //string s = http.GetRequest("PHONEBOOK?$select=PHONE,PHONENUM,CELLPHONE,CUSTNAME");
            string s = http.GetRequest("PHONEBOOK");
            PhoneSearcher phonesearcher = new PhoneSearcher();

            PhoneItemFull phoneitems = phonesearcher.GetPhones(s, phonenumber).FirstOrDefault();

            return phoneitems;
        }

        public TicketItem GetTicket(string custname, string ticketnum)
        {
            //https://www.eshbelsaas.com/demo1/odata/Priority/tabdem1.ini,3/comp/DOCUMENTS_Q?$filter=AIRWAYBILL eq '0019' and CUSTNAME eq '1001' and ACTIVEFLAG eq 'Y'
            TicketItem ti = null;

            string service = $"DOCUMENTS_Q?$filter=AIRWAYBILL eq '{ticketnum}' and CUSTNAME eq '{custname}' and ACTIVEFLAG eq 'Y'";

            string s = http.GetRequest(service);
            TicketReesponseModel ticketresp = JsonConvert.DeserializeObject<TicketReesponseModel>(s);

            if (ticketresp.value.Count==1)
                ti = ticketresp.value.FirstOrDefault();

            return ti;
        }

        public PriorityTaskResponseModel CreateTaskExistingCust(PhoneItemFull phoneitem, string phonenumber)
        {
            ExistingCustomerModel ecm = new ExistingCustomerModel
            {
                CAMPAIGNCODE = ItnvConfiguration.Instance.Campaigncodeexist,
                CUSTNAME = phoneitem.CUSTNAME,
                SUBJECT = $"PHONE CALL FROM {phonenumber}"
            };
            string contents = JsonConvert.SerializeObject(ecm);
            string response = http.PostRequest("CUSTNOTESA", JsonConvert.SerializeObject(ecm));

            ExistingCustResponseModel ecresp = JsonConvert.DeserializeObject<ExistingCustResponseModel>(response);
            string rowid = ecresp == null ? "" : $"{ecresp.CUSTNOTE}";
            PriorityTaskResponseModel tr = new PriorityTaskResponseModel
            {
                FormId = "CUSTNOTESA",
                RowId = rowid,
                URL = ItnvConfiguration.Instance.Popupurl,
                Agent = ""
            };
            tr.URL = tr.URL.Replace("FORMID", tr.FormId).Replace("ROWID", tr.RowId);
            return tr;

        }

        public PriorityTaskResponseModel CreateLead(string phonenumber)
        {
            LeadModel leadmodel = new LeadModel
            {
                CELLPHONE = phonenumber,
                FIRM = DateTime.Now.ToString("yyyyMMddHHmmss"),
                CAMPAIGNCODE = ItnvConfiguration.Instance.Campaigncodenew,
                NAME = "Please define"
            };
            string response =http.PostRequest("LEADS", JsonConvert.SerializeObject(leadmodel));
            LeadResponseModel lrm = JsonConvert.DeserializeObject<LeadResponseModel>(response);
            PriorityTaskResponseModel tr = new PriorityTaskResponseModel
            {
                FormId = "LEADS",
                RowId = $"{lrm.PHONE}",
                URL = ItnvConfiguration.Instance.Popupurl,
                Agent = ""
            };
            tr.URL = tr.URL.Replace("FORMID", tr.FormId).Replace("ROWID", tr.RowId);
            return tr;
        }

        public PriorityTaskResponseModel CreateTicketResponse(string agent, string custname)
        {
            PriorityTaskResponseModel tr = new PriorityTaskResponseModel
            {
                RowId = $"{custname}",
                URL = ItnvConfiguration.Instance.Popupurl,
                Agent = ""
            };
            if (agent.Length<=0)
            {
                tr.FormId = "CUSTOMERS";
            }
            else
            {
                tr.FormId = "DOCUMENTS_Q";
                tr.Agent = agent + ItnvConfiguration.Instance.Emailsuffix;
            }
            tr.URL = tr.URL.Replace("FORMID", tr.FormId).Replace("ROWID", tr.RowId);
            return tr;
        }
        public List<CampaignItem> GetCampaigns()
        {
            string s = http.GetRequest("CAMPAIGNS");

            CampaignResponseModel campaignresp = JsonConvert.DeserializeObject<CampaignResponseModel>(s);
            List<CampaignItem> campaigns = campaignresp.value;
            return campaigns;
        }


    }
}