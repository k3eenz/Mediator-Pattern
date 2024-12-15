using Mediator_Pattern;

IChatMediator mediator = new ChatMediator();

User user1 = new User("user1", mediator);
User user2 = new User("user2", mediator);

mediator.RegisterUser(user1);
mediator.RegisterUser(user2);

user1.SendMessage("Hello!", "user2");
user2.SendMessage("Hello", "user1");

user1.ShowMessageHistory();
user2.ShowMessageHistory();

user2.LeaveChat();
