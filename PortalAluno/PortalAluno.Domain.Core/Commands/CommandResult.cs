using PortalAluno.Domain.Core.Interfaces;

namespace PortalAluno.Domain.Core.Commands
{
    public class CommandResult : ICommand
    {
        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public CommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
