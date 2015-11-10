using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.LinkedList
{
    //Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    class ListItem<T>
    {
        T value;
        T? nextItem;

        public ListItem(T value, T? nextItem)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public T? NextItem
        {
            get { return this.nextItem; }
            set { this.nextItem = value; }
        }
    }
}
