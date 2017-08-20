using Newtonsoft.Json;
using SOACat.InstaPushLib.dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SOACat.InstaPushLib
{
    public class Apps
    {
        internal static string LIST = "apps/list";
        internal static string ADD = "apps/add";

        private string _apiUrl = string.Empty;
        private string _token = string.Empty;
        public Apps(string apiUrl,string token)
        {
            _apiUrl = apiUrl;
            _token = token;
        }

        public async Task<Response[]> ListAsync()
        {
            ResponseApp[] ret = null;
            string res = await net.Http.GetAsync(_apiUrl, LIST , new net.UserIdentity() { Token = _token });
            

            if (!string.IsNullOrEmpty(res))
            {
                ret= JsonConvert.DeserializeObject<ResponseApp[]>(res);
            }
            else
            {
                ret= (ResponseApp[]) Shared.BadRequest();
            }

            return ret;
        }

        public async Task<Response> AddAsync(AppAddRequest request)
        {
            ResponseAppAdd ret = null;
            string content = JsonConvert.SerializeObject(request);
            string res = await net.Http.PostAsync(_apiUrl, ADD, new net.UserIdentity() { Token = _token }, content );

            if (!string.IsNullOrEmpty(res))
            {
                ret = JsonConvert.DeserializeObject<ResponseAppAdd>(res);
            }
            else
            {
                ret = (ResponseAppAdd) Shared.BadRequest()[0];
            }

            return ret;
        }
    }
}
