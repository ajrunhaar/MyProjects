using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManager.Models
{
    class MainEntryModel
    {
        private string _name = "default name";
        private string _home = "default home";
        private int _id = 0;
        public IList<int> Fixtures;

        public string EntryName
        {
            get { return _name; }
            set { _name = value; }
        }
        public string EntryHome
        {
            get { return _home; }
            set { _home = value; }
        }
        public int EntryID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
