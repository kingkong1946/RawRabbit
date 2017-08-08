using System;
using System.Collections.Generic;
using RawRabbit.Configuration.Exchange;
using RawRabbit.Configuration.Queue;

namespace RawRabbit.Configuration.Respond
{
	public interface IResponderConfigurationBuilder
	{
		IResponderConfigurationBuilder WithPrefetchCount(ushort count);
		IResponderConfigurationBuilder WithExchange(Action<IExchangeConfigurationBuilder> exchange);
		IResponderConfigurationBuilder WithQueue(Action<IQueueConfigurationBuilder> queue);
		IResponderConfigurationBuilder WithRoutingKey(string routingKey);
		IResponderConfigurationBuilder WithArguments(IDictionary<string, object> arguments);
		IResponderConfigurationBuilder WithNoAck(bool noAck);
	}
}
