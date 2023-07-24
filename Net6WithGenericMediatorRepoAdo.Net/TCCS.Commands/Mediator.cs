using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands
{
    public class Mediator : IMediator
    {
        private readonly IServiceProvider service;

        public Mediator(IServiceProvider service)
        {
            this.service = service;
        }

        public async Task Execute(ICommand command)
        {
            var type = typeof(ICommandHandler<>);
            Type[] args = {command.GetType()};  
            var handlerType = type.MakeGenericType(args);

            dynamic handler = service.GetService(handlerType);

            await handler.Execute((dynamic)command).ConfigureAwait(false);
        }

        public async Task Execute(ICommandMessageSender command)
        {
            var type = typeof(ICommandIntegrationHandler<>);
            Type[] args = { command.GetType() };
            var handlerType = type.MakeGenericType(args);

            dynamic handler = service.GetService(handlerType);

            await handler.Execute((dynamic)command).ConfigureAwait(false);
            _ = Task.Run(async () => await handler.SendMessageAsync((dynamic)command));
        }


        public async Task<TResult> Execute<TResult>(ICommand<TResult> command)
        {
            var type = typeof(ICommandHandler<>);
            Type[] args = { command.GetType() };
            var handlerType = type.MakeGenericType(args);

            dynamic handler = service.GetService(handlerType);

            TResult result = await handler.Execute((dynamic)command).ConfigureAwait(false);
            return result;
        }

       
        public async Task<TResult> Execute<TResult>(ICommandMessageSender<TResult> command)
        {
            var type = typeof(ICommandIntegrationHandler<>);
            Type[] args = { command.GetType() };
            var handlerType = type.MakeGenericType(args);

            dynamic handler = service.GetService(handlerType);

            var result = await handler.Execute((dynamic)command).ConfigureAwait(false);
            _ = Task.Run(async () => await handler.SendMessageAsync((dynamic)command,result));
            return result;
        }

        public async Task<TResult> ExecuteQuery<TResult>(IQuery<TResult> query)
        {
            var type = typeof(IQueryHandler<,>);
            Type[] args = { query.GetType(), typeof(TResult) };
            var handlerType = type.MakeGenericType(args);

            dynamic handler = service.GetService(handlerType);

            TResult result = await handler.ExecuteQuery((dynamic)query).ConfigureAwait(false);
            return result;
        }
    }
}
