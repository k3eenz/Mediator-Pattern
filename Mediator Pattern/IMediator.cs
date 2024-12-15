using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public interface IMediator
    {
        void RegisterUser(User user);
        void SendMessage(string message, string senderName, string receiverName);
        void RemoveUser(User user);
    }
}
