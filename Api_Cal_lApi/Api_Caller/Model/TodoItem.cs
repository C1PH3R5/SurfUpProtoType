    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Caller.Model
{
    public class TodoItem
    {
        private int _Id;

        public int id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;

        public string name
        {
            get { return _Name; }
            set { _Name = value; }
        }


    }
}
