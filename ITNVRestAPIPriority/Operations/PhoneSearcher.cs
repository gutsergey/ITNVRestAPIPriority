using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using ITNVRestAPIPriority.Models;
using ITNVRestAPIPriority.App_Conf;

namespace ITNVRestAPIPriority.Operations
{
    public class PhoneSearcher
    {
        public List<PhoneItemFull> GetPhones(string phonesstr, string phonenumber)
        {
            phonenumber = phonenumber.Substring(0, 1) == "0" ? phonenumber.Substring(1) : phonenumber;
            phonesstr =phonesstr.Replace("-", "").Replace(".", "").Replace(" ", "");
            PhoneBookResponseModel phonebook =  JsonConvert.DeserializeObject<PhoneBookResponseModel>(phonesstr);
            List<PhoneItemFull> phoneitems = phonebook.value;

            //List<PhoneItem> phoneitems1 = phoneitems.Where(x => x.PHONENUM != null && x.PHONENUM.EndsWith(phonenumber)).ToList();
            List<PhoneItemFull> phoneitems1 = phoneitems.Where(x => ComparePhones(x.PHONENUM, phonenumber)).ToList();
            if (phoneitems1==null || phoneitems1.Count<=0)
                //phoneitems1 = phoneitems.Where(x => x.CELLPHONE!=null && x.CELLPHONE.EndsWith(phonenumber)).ToList();
                phoneitems1 = phoneitems.Where(x => ComparePhones(x.CELLPHONE, phonenumber)).ToList();
            return phoneitems1;
        }
        private bool ComparePhones(string phoneinpri, string phone)
        {
            bool rc = false;
            if (phoneinpri == null) return rc;

            string[] arr = phoneinpri.Split('#');
            phoneinpri = arr[0].Trim();
            if (phone.Length < 7)
            {
                rc = phoneinpri.Equals(phone);
            }
            else
            {
                rc = phoneinpri.EndsWith(phone);
                if (rc)
                    rc = true;
            }
            return rc;        
        }
    }
}