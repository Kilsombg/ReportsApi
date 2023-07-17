using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsDomain.Events
{
    public class ClientEvent : BaseEvent
    {
        public Client client { get; }

        public ClientEvent(Client client)
        {
            this.client = client;
        }
    }
}
