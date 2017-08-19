using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SOACat.InstaPushLib.net
{
    internal static class Http
    {
        internal static async Task<string> PostAsync(string url, string method, AppIdentity idty, string content)
        {
            string res = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add(Shared.Head_AppId, idty.Appid);
                client.DefaultRequestHeaders.Add(Shared.Head_AppSecret, idty.Appsecret);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Shared.Head_ContentType));

                var postBody = new StringContent(content);

                HttpResponseMessage response = await client.PostAsync(method, postBody);

                response.EnsureSuccessStatusCode();
                res = await response.Content.ReadAsStringAsync();

            }

            return res;

        }

        internal static async Task<string> PostAsync(string url, string method, UserIdentity idty, string content)
        {
            string res = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add(Shared.Head_Token, idty.Token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Shared.Head_ContentType));

                var postBody = new StringContent(content);

                HttpResponseMessage response = await client.PostAsync(method, postBody);

                response.EnsureSuccessStatusCode();
                res = await response.Content.ReadAsStringAsync();

            }

            return res;

        }


        internal static async Task<string> GetAsync(string url, string method, UserIdentity idty)
        {
            string res = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add(Shared.Head_Token, idty.Token);

                HttpResponseMessage response = await client.GetAsync(method);

                response.EnsureSuccessStatusCode();
                res = await response.Content.ReadAsStringAsync();

            }

            return res;

        }
        internal static async Task<string> GetAsync(string url, string method, AppIdentity idty)
        {
            string res = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add(Shared.Head_AppId, idty.Appid);
                client.DefaultRequestHeaders.Add(Shared.Head_AppSecret, idty.Appsecret);


                HttpResponseMessage response = await client.GetAsync(method);

                response.EnsureSuccessStatusCode();
                res = await response.Content.ReadAsStringAsync();

            }

            return res;

        }

    }
}
