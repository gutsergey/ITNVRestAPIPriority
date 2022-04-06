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
    public class CampaignController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // http://localhost:63327/priority/campaigns
        [Route("campaigns")]
        [ResponseType(typeof(IEnumerable<CampaignItem>))]
        public IEnumerable<CampaignItem> Get()
        {
            log.Info("--->");
            PriorityOperations po = new PriorityOperations();

            List<CampaignItem> campaigns = po.GetCampaigns();
            log.Info($"campaigns: {JsonConvert.SerializeObject(campaigns)}");

            return campaigns.ToArray();
        }
    }
}