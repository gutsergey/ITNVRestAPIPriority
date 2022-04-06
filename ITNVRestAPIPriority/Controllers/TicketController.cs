using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Newtonsoft.Json;
using ITNVRestAPIPriority.Models;
using ITNVRestAPIPriority.Operations;
using ITNVRestAPIPriority.App_Conf;

namespace ITNVRestAPIPriority.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("priority")]
    public class TicketController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // http://localhost:63327/priority/ticket/0522385127/0019
        [Route("ticket/{phonenumber}/{ticket}")]
        [ResponseType(typeof(ITNVRestAPIPriority.Models.PriorityTaskResponseModel))]
        public PriorityTaskResponseModel Get(string phonenumber, string ticket)
        {
            log.Info($"phonenumber: {phonenumber}, ticket: {ticket}");
            string agent = "";
            string rowid = "";
            PriorityTaskResponseModel ptr;
            PriorityOperations po = new PriorityOperations();

            try
            {
                PhoneItemFull phone = po.GetPhones(phonenumber);
                log.Info($"{JsonConvert.SerializeObject(phone)}");
                if (phone != null & ticket != "-1")
                {
                    rowid = phone.CUSTNAME;

                    TicketItem ti = po.GetTicket(rowid, ticket);
                    if (ti != null)
                    {
                        agent = ti.TECHNICIANLOGIN;
                        rowid = ti.DOCNO;
                    }
                }
            }
            catch (Exception exc)
            {
                log.Error(exc.Message);
                log.Error(exc.StackTrace);
            }
            ptr= po.CreateTicketResponse(agent, rowid);
            log.Info($"response: {JsonConvert.SerializeObject(ptr)}");
            return ptr;
        }


    }
}