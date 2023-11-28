using System;

namespace LPS_Test_Soal_1_7
{
    public class EventPublisher
    {
        public event EventHandler MyEvent;

        public void RaiseEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    public class EventSubscriber
    {
        public EventSubscriber(EventPublisher publisher)
        {
            publisher.MyEvent += OnMyEvent;
        }

        private void OnMyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent raised");
        }
    }

    public class Soal5Class
    {
        public void RunEventExample()
        {
            var publisher = new EventPublisher();

            while (true)
            {
                var subscriber = new EventSubscriber(publisher);

                // Do something with the publisher and subscriber objects
                // For example, you can raise the event periodically
                publisher.RaiseEvent();
            }
        }
    }
}
