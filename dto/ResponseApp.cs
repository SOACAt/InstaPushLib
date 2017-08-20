using System;
using System.Collections.Generic;
using System.Text;

namespace SOACat.InstaPushLib.dto
{
    public class ResponseApp:Response
    {
        public string title { get; set; }
        public string appID { get; set; }
        public string appSecret { get; set; }

    }
}
