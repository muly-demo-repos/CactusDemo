using DotnetService.Brokers.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using TestThePlugin.Brokers.Infrastructure;
using TestThePlugin.Brokers.Kafka;

namespace TestThePlugin.Brokers.Kafka;

public class KafkaConsumerService : KafkaConsumerService<KafkaMessageHandlersController>
{
    public KafkaConsumerService(IServiceScopeFactory serviceScopeFactory, KafkaOptions kafkaOptions)
        : base(serviceScopeFactory, kafkaOptions) { }
}
