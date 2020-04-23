using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class NotificationBuilder:IBuilder
    {
        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public NotificationBuilder() 
        {
            Author = String.Empty;
            Title = String.Empty;
            Text = String.Empty;
            Timestamp = DateTime.Now;
            Level = Category.ALERT;
            Color = ConsoleColor.White;
        }
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(Author, Title, Text, Timestamp, Level, Color);
        }
        public IBuilder SetAuthor(String author)
        {
            this.Author = author;
            return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.Title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.Timestamp = time;
            return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.Level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.Color = color;
            return this;
        }
        public IBuilder SetText(String text)
        {
            this.Text = text;
            return this;
        }
    }
}
