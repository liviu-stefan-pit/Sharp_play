using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cs.Delegates
{
    public delegate void EventDelegate(object sender, EventSenderArgs e);

    public class EventSenderArgs : EventArgs
    {
        public int data;

        public EventSenderArgs(int value)
        {
            data = value;
        }
    }

    public class EventSender
    {
        public event EventDelegate Eventvar;

        public void RaiseEvent()
        {
            Eventvar?.Invoke(this, new EventSenderArgs(3));
        }
    }

    public class EventReceiver
    {
        public void EventHandlerReceiver(object sender, EventSenderArgs e)
        {
            Console.WriteLine(e.data);
        }
    }
}
