using SOACat.InstaPushLib.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOACat.InstaPushLib
{
    internal static class Shared
    {
        internal static string Head_AppId = "x-instapush-appid";
        internal static string Head_AppSecret = "x-instapush-appsecret";
        internal static string Head_Token = "x-instapush-token";
        internal static string Head_ContentType = "application/json";

        internal static Response[] BadRequest()
        {
            return new[] {
                new Response()
                    {
                        error = true,
                        msg = "Opps!! Something is wrong!!",
                        status = 404
                    }
            };
        }
    }
}
