using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITNVRestAPIPriority.Models
{
    public class PriorityTaskResponseModel
    {
        public string FormId { get; set; }
        public string RowId { get; set; }
        public string URL { get; set; }
        public string Agent { get; set; }
    }
}