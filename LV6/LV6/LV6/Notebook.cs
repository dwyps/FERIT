using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class Notebook : IAbstractCollection
    {
        private List<Note> notes;
        public Notebook() 
        {
            this.notes = new List<Note>();
        }
        public Notebook(List<Note> notes) 
        {
            this.notes = new List<Note>(notes.ToArray());
        }
        public void AddNote(Note note) 
        {
            notes.Add(note);
        }
        public void RemoveNote(Note note) 
        {
            notes.Remove(note);
        }
        public void Clear() 
        {
            foreach (Note note in notes)
                notes.Remove(note);
        }
        public int Count { get { return this.notes.Count; } }
        public Note this[int index] { get { return this.notes[index]; } }
        public IAbstractIterator GetIterator() { return new Iterator(this); }
    }
}
