using SF1841.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF1841
{
    internal class UserAction
    {
        ICommonCommand command;
        public void SetCommand(ICommonCommand com)
        {
            command = com;
        }
        public void SendCommand()
        {
            command.Execute();
        } 
    }
}
