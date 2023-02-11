using Newtonsoft.Json;
using RabbitMQ.Client;
using ServiceBasedRabbit.Core.Interfaces.MessageBroker;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ServiceBasedRabbit.Infrastructure.MessageBroker
{
    public class RabbitMQPublisher : IRabbitMQPublisher
    {

        public void Publish<T>(T message)
        {

            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "UserItemQueue",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

            channel.BasicPublish(exchange: string.Empty,
                                 routingKey: "UserItemQueue",
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine($" [x] Sent {message}");


        }

        
    }
}
