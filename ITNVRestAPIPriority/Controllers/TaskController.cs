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
    public class TaskController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        // http://localhost:63327/priority/task/0522385127
        [Route("task/{phonenumber}")]
        [ResponseType(typeof(ITNVRestAPIPriority.Models.PriorityTaskResponseModel))]
        public PriorityTaskResponseModel Get(string phonenumber)
        {
            log.Info($"phonenumber: {phonenumber}");
            PriorityTaskResponseModel ptr;
            PriorityOperations po = new PriorityOperations();

            try
            {
                PhoneItemFull phone = po.GetPhones(phonenumber);

                if (phone == null)
                    ptr = po.CreateLead(phonenumber);
                else
                    ptr = po.CreateTaskExistingCust(phone, phonenumber);
            }
            catch (Exception exc)
            {
                log.Error(exc.Message);
                log.Error(exc.StackTrace);
                ptr = new PriorityTaskResponseModel();
            }
            log.Info($"response: {JsonConvert.SerializeObject(ptr)}");
            return ptr;
        }


    }
}