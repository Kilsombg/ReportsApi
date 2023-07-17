using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsDomain.Events
{
    public class ClientConfigEvent : BaseEvent
    {
        public ClientConfig client { get; }

        public ClientConfigEvent(ClientConfig client)
        {
            this.client = client;
        }
    }
}
