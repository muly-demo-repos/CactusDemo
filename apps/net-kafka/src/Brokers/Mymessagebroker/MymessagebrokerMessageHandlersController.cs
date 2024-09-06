using System.Threading.Tasks;
using NetKafka.Brokers.Infrastructure;

namespace NetKafka.Brokers.Mymessagebroker;

public class MymessagebrokerMessageHandlersController
{
    [Topic("topicNewName")]
    public Task HandleTopicNewName(string message)
    {
        //set your message handling logic here

        return Task.CompletedTask;
    }
}
