﻿using System.Threading.Tasks;
using Serilog;

namespace Kmd.Logic.Gateway.Automation.Tool
{
    internal class PublishCommandHandler : CommandHandlerBase
    {
#pragma warning disable CA1801 // Remove unused parameter
        public Task<int> Handle(PublishCommand cmd)
#pragma warning restore CA1801 // Remove unused parameter
        {
            this.Initialize(cmd);

            Log.Information("Published");
            return Task.FromResult(0);
        }
    }
}
