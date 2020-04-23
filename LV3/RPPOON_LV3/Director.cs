using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class Director
    {
        public NotificationBuilder builder{get;set;}
        public Director(){
            builder=new NotificationBuilder();
        }
        public ConsoleNotification buildAlertNotification(string author)
        {
            return builder.SetAuthor(author).SetTitle("Alert notification").SetText("Alert!").SetLevel(Category.ALERT).SetColor(ConsoleColor.Magenta).Build();
        }
        public ConsoleNotification buildErrorNotification(string author)
        {
            return builder.SetAuthor(author).SetTitle("Error notification").SetText("Error!").SetLevel(Category.ERROR).SetColor(ConsoleColor.Red).Build();
        }
        public ConsoleNotification buildInfoNotification(string author)
        {
            return builder.SetAuthor(author).SetTitle("Info notification").SetText("Info").SetLevel(Category.INFO).SetColor(ConsoleColor.White).Build();
        }
    }
}
