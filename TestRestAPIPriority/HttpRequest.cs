using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Security;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace TestRestAPIPriority
{
    public class HttpRequest
    {
        private string user;
        private string pwd;
        private string url;
        public HttpRequest(string user, string pwd, string url)
        {
            this.user = user;
            this.pwd = pwd;
            this.url = url;
        }
        public string GetRequest(string service) => PostRequest(service, "", false);
        public string PostRequest(string service, string contents) => PostRequest(service, contents, false);
        public string PatchRequest(string service, string contents) => PostRequest(service, contents, true);
        public string PostRequest(string service, string contents, bool ifPatchMethod)
        {
            Task<string> t = Task.Run(() => Request(service, contents, ifPatchMethod));
            t.Wait();
            return t.Result;
        }
        private async Task<string> Request(string service, string contents, bool ifPatchMethod)
        {
            string res = "";

            try
            {
                using (HttpClient httpclient = GetHttpClient(ifPatchMethod))
                {
                    Uri uri = new Uri(url + service);
                    HttpResponseMessage result;
                    if (contents.Length > 0)
                    {
                        HttpContent hcont = new StringContent(contents, Encoding.UTF8, "application/json");
                        result = await httpclient.PostAsync(uri, hcont);
                    }
                    else
                    {
                        result = await httpclient.GetAsync(uri);
                    }
                    res = result.Content.ReadAsStringAsync().Result;
                    if (!result.IsSuccessStatusCode)
                    {
                        throw new Exception("StatusCode of HTTP Request is not success");
                    }
                }
            }
            catch (Exception exc)
            {
                //log.Error($"ifPatchMethod: {ifPatchMethod} ");
                //log.Error($"url: {url} ");
                //log.Error($"contents: {contents} ");
                //log.Error($"service: {service} ");
                //log.Error(exc.Message);
                //log.Error(exc.StackTrace);
            }
            return res;
        }
        private HttpClient GetHttpClient(bool ifPatchMethod)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors policyErrors) => true);

            HttpClient httpclient = new HttpClient();

            httpclient.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
            httpclient.DefaultRequestHeaders.Add("X-Requested-With", "rest");
            httpclient.DefaultRequestHeaders.Add("OSvC-CREST-Application-Context", "This is a valid request for account.");
            if (ifPatchMethod)
            {
                httpclient.DefaultRequestHeaders.Add("X-HTTP-Method-Override", "PATCH");
            }
            var byteArray = Encoding.ASCII.GetBytes($"{user}:{pwd}");
            httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            return httpclient;
        }
    }
}