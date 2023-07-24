using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands
{
    public interface IMediator : IQueryMediator
    {
        Task Execute(ICommand command);

        Task<TResult> Execute<TResult>(ICommand<TResult> command);

        Task Execute(ICommandMessageSender command);

        Task<TResult> Execute<TResult>(ICommandMessageSender<TResult> command);
    }


    public interface IQueryMediator
    {
        Task<TResult> ExecuteQuery<TResult>(IQuery<TResult> query);
    }
}
