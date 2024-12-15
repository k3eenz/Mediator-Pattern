using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class User
    {
        public string name { get; }
        private readonly IMediator mediator;
        private readonly List<string> messageHistory = new List<string>();
        public User(string Name, IMediator Mediator)
        {
            name = Name;
            mediator = Mediator;
        }

        public void SendMessage(string message, string receiverName)
        {
            Console.WriteLine($" Отправлено сообщение для {receiverName}: {message}");
            mediator.SendMessage(message, name, receiverName);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            string fullMessage = $"[{senderName} -> {name}]: {message}";
            messageHistory.Add(fullMessage);
            Console.WriteLine(fullMessage);
        }

        public void ShowMessageHistory()
        {
            Console.WriteLine($"История сообщений {name}:\n");
            foreach (var message in messageHistory)
            {
                Console.WriteLine(message);
            }
        }
        public void LeaveChat() => mediator.RemoveUser(this);
    }
}
