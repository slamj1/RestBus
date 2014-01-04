using System;
namespace RestBus.Common
{
    public interface IRestBusSubscriber : IDisposable
    {
        string Id { get; }
        HttpContext Dequeue();
        void Start();

        //TODO: This interface shouldn't be aware of the HttpContext type which is a RabbitMQ type
        void SendResponse(HttpContext context, HttpResponsePacket response);
    }
}