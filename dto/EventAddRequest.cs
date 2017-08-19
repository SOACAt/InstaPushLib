using System;
using System.Collections.Generic;
using System.Text;

namespace SOACat.InstaPushLib.dto
{
    public class EventAddRequest
    {
        public string title { get; set; }
        public string[] trackers { get; set; }

        public string message { get; set; }
    }
}

