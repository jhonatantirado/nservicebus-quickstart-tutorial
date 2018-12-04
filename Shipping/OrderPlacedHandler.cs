﻿using System.Threading.Tasks;
using NServiceBus;
using Messages;
using NServiceBus.Logging;

namespace Shipping
{
    public class OrderPlacedHandler:IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger<OrderPlacedHandler>();

        public Task Handle (OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Shipping has received OrderPlaced, OrderId = {message.OrderId}");
            return Task.CompletedTask;
        }

    }
}
