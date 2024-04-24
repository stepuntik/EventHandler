namespace EventHandler
{
    public class EventHandlerClass
    {
        public EventHandlerClass(EventPublisher publisher)
        {
            publisher.MyEvent += HandleEvent;
        }

        private void HandleEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine($"Received message: {e.Message}");
        }
    }
}
