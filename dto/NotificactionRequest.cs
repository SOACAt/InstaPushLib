using System;
using System.Collections.Generic;
using System.Text;

namespace SOACat.InstaPushLib.dto
{
    public class NotificactionRequest
    {
        public string @event { get; set; }
        public IDictionary<string,string> trackers { get; set; }
    }
}
