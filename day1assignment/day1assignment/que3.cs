using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1assignment
{
     class Notification
    {
        public virtual void Notifiy()
        {
            Console.WriteLine("You will be notified by:");

        }
    
    }
    class SMS:Notification
    {
        public override void Notifiy()
        {
            Console.WriteLine("Notification by SMS");
        }
    }
    class Email : Notification
    {
        public override void Notifiy()
        {
            Console.WriteLine("Notification by Email");
        }
    }
}
