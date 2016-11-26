namespace TestApp
{
    using System;
    using Microsoft.ServiceBus.Messaging;

    class Program
    {
        static void Main(string[] args)
        {
            var msg = new BrokeredMessage("x");
            Console.WriteLine(msg.Size);
        }
    }
}
