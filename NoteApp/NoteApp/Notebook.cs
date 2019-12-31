using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp
{
    public class Notebook : List<Note>
    {
        /// <summary> All tags in this notebook </summary>
        private ISet<string> tags;

        public Notebook(List<Note> notes)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetNotebookSlice(Func<List<Note>, List<Note>> sort, params Func<List<Note>, List<Note>>[] filters)
        {
            throw new NotImplementedException();
        }

        public void CreateNote(string title, HashSet<string> tags)
        {
            throw new NotImplementedException();
        }

        public void DeleteNote(int noteID)
        {
            throw new NotImplementedException();
        }



    }
}
