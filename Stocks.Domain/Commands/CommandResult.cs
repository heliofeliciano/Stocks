using Stocks.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult()
        {
        }

        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
    }
}
