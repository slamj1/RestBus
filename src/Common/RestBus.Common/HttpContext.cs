using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBus.Common
{
    public class HttpContext
    {
        public HttpRequestPacket Request { get; set;}
        public string ReplyToQueue { get; set; }
        public string CorrelationId { get; set; }

    }
}