using System;
using TODO.Domain.Commands.Contracts;

namespace TODO.Domain.Commands;

public class GenericCommandResult : ICommandResult
{
    public GenericCommandResult()
    {}

    public GenericCommandResult(bool success, string message, object data)
    {
        Success = success;
        Message = message;
        Data = data;
    }

    public bool Success { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }
}
