using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class ChatMediator : IMediator
    {
        private readonly List<User> users = new List<User>();
        public void RegisterUser(User user)
        {
            if (!users.Contains(user))
            {
                users.Add(user);
                Console.WriteLine($"Пользователь {user.name} добавлен в чат.");
            }
        }

        public void SendMessage(string message, string senderName, string receiverName)
        {
            var receiver = users.Find(user => user.name == receiverName);
            if (receiver != null)
            {
                receiver.ReceiveMessage(message, senderName);
            }
            else
            {
                Console.WriteLine($"User {receiverName} not found in the chat.");
            }
        }

        public void RemoveUser(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);
                Console.WriteLine($"Пользователь {user.name} покинул чат");
            }
        }
    }
}
