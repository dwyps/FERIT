using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON
{
    public class NoteWithTime : Note
    {
        public DateTime Time { get; set; }
        public NoteWithTime() : base()
        {
            this.Time = DateTime.Now;
        }
   
        public NoteWithTime(string text, string author, int level) : base()
        {
            this.Time = DateTime.Now;
        }
        public NoteWithTime(string text, string author) : base()
        {
            this.Time = DateTime.Now;
        }
    
        public override string ToString()
        {
            return base.ToString() + ", " + Time;
        }
    }
}
