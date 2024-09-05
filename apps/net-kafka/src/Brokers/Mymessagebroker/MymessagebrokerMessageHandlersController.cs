using NetKafka.Brokers.Infrastructure;
using System.Threading.Tasks;

namespace NetKafka.Brokers.Mymessagebroker;

public class MymessagebrokerMessageHandlersController
{
    [Topic("t.1")]
    public Task Handlet.1(string message) {
        //set your message handling logic here 
        
      return Task.CompletedTask;}

}
