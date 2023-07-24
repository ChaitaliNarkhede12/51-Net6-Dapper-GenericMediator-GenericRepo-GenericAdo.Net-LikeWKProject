using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands
{
    public interface ICommandHandler<in TCommand, TReturn> where TCommand : ICommand<TReturn>
    {
        Task<TReturn> Execute(TCommand command);
    }

    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task Execute(TCommand command);
    }



    public interface ICommandIntegrationHandler<in TCommand, TReturn> : ICommandHandler<TCommand, TReturn>
        where TCommand : ICommand<TReturn>
    {
        Task SendMessageAsync(TCommand command, TReturn result);
    }

    public interface ICommandIntegrationHandler<in TCommand> : ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Task SendMessageAsync(TCommand command);
    }
}
