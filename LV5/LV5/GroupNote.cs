using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    public class GroupNote : Note
    {
        private List<String> names = new List<String>();
        public GroupNote(string message, ITheme theme) : base(message, theme) { }
        public void AddName(string name)
        {
            this.names.Add(name);
        }
        public void RemoveName(string name)
        {
            this.names.Remove(name);
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Group: ");
            foreach(string name in names)
                Console.WriteLine(name);
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
