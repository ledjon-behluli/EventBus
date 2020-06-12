using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusTestTopic.IntegrationEvents
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
