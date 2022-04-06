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
    public class PhonebookController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // http://localhost:63327/priority/phonebook
        [Route("phonebook")]
        [ResponseType(typeof(IEnumerable<PhoneItem>))]
        public IEnumerable<PhoneItemFull> Get()
        {
            log.Info("--->");
            PriorityOperations po = new PriorityOperations();

            List<PhoneItemFull> phones = po.GetPhones();
            log.Info($"phones: {JsonConvert.SerializeObject(phones)}");
            return phones.ToArray();
        }

        [Route("phonebook/{phonenum}")]
        [ResponseType(typeof(IEnumerable<PhoneItem>))]
        public PhoneItemFull Get(string phonenum)
        {
            log.Info("--->");
            PriorityOperations po = new PriorityOperations();

            PhoneItemFull phones = po.GetPhones(phonenum);
            log.Info($"phones: {JsonConvert.SerializeObject(phones)}");
            return phones;
        }
    }
}
