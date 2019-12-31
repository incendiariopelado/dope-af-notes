using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp
{
    public class FilterLib
    {

        /// <summary>
        /// NOTE: date is a closed interval.
        /// </summary>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        public void FilterByDateCreated(DateTime intervalStart, DateTime intervalEnd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// NOTE: date is a closed interval.
        /// </summary>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        public void FilterByLastEdited(DateTime intervalStart, DateTime intervalEnd)
        {
            throw new NotImplementedException();
        }

        public void FilterByTags(params string[] tags)
        {
            throw new NotImplementedException();
        }

        public void FilterByTitle(string regex)
        {
            throw new NotImplementedException();
        }





        


    }
}
