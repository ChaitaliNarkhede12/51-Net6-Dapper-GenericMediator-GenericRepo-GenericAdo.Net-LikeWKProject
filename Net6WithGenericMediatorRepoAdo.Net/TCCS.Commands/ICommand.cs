using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands
{
    public interface ICommand<TReturn> : ICommand
    {
    }

    public interface ICommandMessageSender<TReturn> : ICommand<TReturn>
    {
    }




    public interface ICommand
    {
    }

    public interface ICommandMessageSender : ICommand
    {
    }
}
