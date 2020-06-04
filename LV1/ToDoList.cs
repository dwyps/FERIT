using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON
{
    class ToDoList
    {
        private List<Note> notes;

        public ToDoList()
        {
            notes = new List<Note>();
        }
        public void AddNote(Note note)
        {
            notes.Add(note);
        }
        public void RemoveNote(int index)
        {
            notes.RemoveAt(index);
        }
        public Note getNote(int index)
        {
            return notes[index];
        }

        public string getStringRepresentation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Note note in notes)
            {
                stringBuilder.Append(note).Append(", ");
            }
            return stringBuilder.ToString();
        }

        public int getHighestImportance()
        {
            int highestImportance = notes[0].getImportanceLevel();
            foreach (Note note in notes)
            {
                if (note.importancelevel > highestImportance)
                    highestImportance = note.importancelevel;
            }
            return highestImportance;
        }

        public void RemoveNotesWithHighestImportance()
        {
            int highestImportance = getHighestImportance();
            for (int i = notes.Count - 1; i >= 0; i--)
                if (notes[i].importancelevel == highestImportance)
                    RemoveNote(i);
        }
    }
}
