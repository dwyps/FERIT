using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON
{
    public class Note
    {
        private string Text;
        private string Author;
        private int ImportanceLevel;
        public Note()
        {
            this.Text = "My note.";
            this.Author = "S.T";
            this.ImportanceLevel = 1;
        }
        public Note(string text, string author, int level)
        {
            this.Text = text;
            this.Author = author;
            this.ImportanceLevel = level;
        }
        public Note(string text, string author)
        {
            this.Text = text;
            this.Author = author;
            this.ImportanceLevel = 1;
        }
  
        public string getText()
        {
            return this.Text;
        }
        public string getAuthor()
        {
            return this.Author;
        }
        public int getImportanceLevel()
        {
            return this.ImportanceLevel;
        }
        public void setText(string text)
        {
            this.Text = text;
        }
        public void setImportanceLevel(int level)
        {
            this.ImportanceLevel = level;
        }

        public string text { get; set; }
        public string author { get; private set; }
        public int importancelevel { get; set; }

        public override string ToString()
        {
            return this.Text + ", " +  this.Author + ", " + this.ImportanceLevel;
        }
    }
}
