using Newtonsoft.Json;
using SOACat.InstaPushLib.dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SOACat.InstaPushLib
{
    public class Events
    {
        internal static string LIST = "events/list";
        internal static string ADD = "events/add";
        private string _apiUrl = string.Empty;
        private string _appid = string.Empty;
        private string _appsecret = string.Empty;
        public Events(string apiUrl, string appId, string appSecret)
        {
            _apiUrl = apiUrl;
            _appid = appId;
            _appsecret = appSecret;
        }
        public async Task<ResponseEvent[]> ListAsync()
        {
            ResponseEvent[] ret = null;
            string res = await net.Http.GetAsync(_apiUrl, LIST, new net.AppIdentity {  Appid=_appid, Appsecret=_appsecret });


            if (!string.IsNullOrEmpty(res))
            {
                ret = JsonConvert.DeserializeObject<ResponseEvent[]>(res);
            }
            else
            {
                ret = (ResponseEvent[])Shared.BadRequest();
            }

            return ret;
        }

        public async Task<ResponseAppAdd> AddAsync(EventAddRequest request)
        {
            ResponseAppAdd ret = null;
            string content = JsonConvert.SerializeObject(request);
            string res = await net.Http.PostAsync(_apiUrl, ADD, new net.AppIdentity() { Appid=_appid, Appsecret=_appsecret }, content);

            if (!string.IsNullOrEmpty(res))
            {
                ret = JsonConvert.DeserializeObject<ResponseAppAdd>(res);
            }
            else
            {
                ret =(ResponseAppAdd)Shared.BadRequest()[0];
            }

            return ret;
        }

    }
}
