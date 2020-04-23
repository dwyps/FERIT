using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ConsoleNotification notification = director.buildAlertNotification("Author");
            NotificationManager manager = new NotificationManager();
            ConsoleNotification clone = (ConsoleNotification)notification.Clone();
            notification.changeNotification();
            manager.Display(notification);
            manager.Display(clone);
        }
    }
}
