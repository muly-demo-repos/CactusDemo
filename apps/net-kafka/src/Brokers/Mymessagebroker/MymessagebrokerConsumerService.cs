using Microsoft.Extensions.DependencyInjection;
using NetKafka.Brokers.Infrastructure;
using NetKafka.Brokers.Mymessagebroker;

namespace NetKafka.Brokers.Mymessagebroker;

public class MymessagebrokerConsumerService
    : KafkaConsumerService<MymessagebrokerMessageHandlersController>
{
    public MymessagebrokerConsumerService(
        IServiceScopeFactory serviceScopeFactory,
        KafkaOptions kafkaOptions
    )
        : base(serviceScopeFactory, kafkaOptions) { }
}
