using System;
using Flunt.Notifications;
using Flunt.Validations;
using TODO.Domain.Commands.Contracts;

namespace TODO.Domain.Commands;

public class MarkTodoItemAsUndoneCommand : Notifiable, ICommand
{
    public MarkTodoItemAsUndoneCommand()
    {}
    public MarkTodoItemAsUndoneCommand(Guid id, string user)
    {
        Id = id;
        User = user;
    }

    public Guid Id { get; set; }
    public string User { get; set; }
    public void Validate()
    {
        AddNotifications(
            new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Inválido!")
        );
    }
}
