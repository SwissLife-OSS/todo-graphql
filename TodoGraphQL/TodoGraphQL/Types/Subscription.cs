using HotChocolate.Subscriptions;
using TodoGraphQL.Data;

namespace TodoGraphQL.Types
{
    public class Subscription
    {
        public Todo OnTodo(IEventMessage message)
        {
            return (Todo)message.Payload;
        }
    }
}
