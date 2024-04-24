using static EventHandler.MyEventArgs;

namespace EventHandler
{
    public class EventPublisher
    {
        public event MyEventHandler MyEvent;

        public void RaiseEvent()
        {
            OnMyEvent("Event triggered from EventPublisher");
        }

        protected virtual void OnMyEvent(string message)
        {
            MyEvent?.Invoke(this, new MyEventArgs(message));
        }
    }
}
