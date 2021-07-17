using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusRabbitMQ.Events.Abstract
{
    public abstract class IEvent
    {
        public Guid RequestId { get; private init; }
        public DateTime CreaationDate { get; private init; }
        public IEvent()
        {
            RequestId = Guid.NewGuid();
            CreaationDate = DateTime.Now;
        }
    }
}
