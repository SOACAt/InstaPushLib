using Newtonsoft.Json;
using SOACat.InstaPushLib.dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SOACat.InstaPushLib
{
    public class Notifications
    {

        internal static string SEND = "post";


        private string _apiUrl = string.Empty;
        private string _appid = string.Empty;
        private string _appsecret = string.Empty;

        public Notifications(string apiUrl, string appId, string appSecret)
        {
            _apiUrl = apiUrl;
            _appid = appId;
            _appsecret = appSecret;
        }
   
        public async Task<Response> SendAsync(NotificactionRequest request)
        {
            Response ret = null;
            string res = string.Empty;
            string content = JsonConvert.SerializeObject(request);
            res = await net.Http.PostAsync(_apiUrl, SEND, new net.AppIdentity() { Appid = _appid, Appsecret = _appsecret }, content);
            if (!string.IsNullOrEmpty(res))
            {
                ret = JsonConvert.DeserializeObject<Response>(res);
            }
            else{
                ret = Shared.BadRequest()[0];
            }

            return ret;
        }
    }
}
