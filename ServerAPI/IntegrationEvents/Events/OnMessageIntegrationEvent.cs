using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerAPI.IntegrationEvents.Events
{
    public class OnMessageIntegrationEvent : IntegrationEvent
    {
        public string Message { get; }

        public OnMessageIntegrationEvent(string message)
        {
            Message = message;
        }
    }
}
