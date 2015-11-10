using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.LinkedList
{
    //Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
    class LinkedList<T>
    {
        public LinkedList(ListItem<T> firstItem)
        {
            this.FirstItem = firstItem;
        }

        public ListItem<T> FirstItem
        {
            get { return this.FirstItem; }
            set { this.FirstItem = value; }
        }
    }
}
