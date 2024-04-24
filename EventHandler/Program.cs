namespace EventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                EventPublisher publisher = new EventPublisher();
                EventHandlerClass handler = new EventHandlerClass(publisher);

                publisher.RaiseEvent();
            }
        }
    }
}
