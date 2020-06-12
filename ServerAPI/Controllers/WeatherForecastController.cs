using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using ServerAPI.IntegrationEvents.Events;

namespace ServerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IEventBus _eventBus;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEventBus eventBus)
        {
            _logger = logger;
            _eventBus = eventBus;
        }

        [HttpGet]
        public string Get()
        {
            try
            {
                _eventBus.Publish(new OnMessageIntegrationEvent("test"));
                return "Sent";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ERROR Publishing integration event");

                throw;
            }
        }
    }
}
