using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class FileLogger
    {
        private static FileLogger instance;
        public string filePath { private get; set; }
        private FileLogger() {
            filePath = "default.txt";
        }
        public static FileLogger getInstance(){
            if(instance==null)
                instance=new FileLogger();
            return instance;
        }
        public void log(string message){
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
 }
    }
}
