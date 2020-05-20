using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class FileLogger : AbstractLogger 
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath)
            : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using(System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath)) 
            {
                writer.WriteLine(type + ": " + DateTime.Now);
                writer.WriteLine(message);
            }
        }
    }
}
