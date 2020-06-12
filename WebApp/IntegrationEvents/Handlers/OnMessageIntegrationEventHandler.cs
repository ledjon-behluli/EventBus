using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.IntegrationEvents.Events;

namespace WebApp.IntegrationEvents.Handlers
{
    public class OnMessageIntegrationEventHandler : IIntegrationEventHandler<OnMessageIntegrationEvent>
    {
        private readonly ILogger<OnMessageIntegrationEventHandler> _logger;

        public OnMessageIntegrationEventHandler(ILogger<OnMessageIntegrationEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Handle(OnMessageIntegrationEvent @event)
        {
            _logger.LogInformation("----- Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})", @event.Id, "WebApp", @event);

            if (@event.Id != Guid.Empty)
            {
                string a = @event.Message;
            }
            else
            {
                _logger.LogWarning("Invalid IntegrationEvent - RequestId is missing - {@IntegrationEvent}", @event);
            }
            
        }
    }
}

