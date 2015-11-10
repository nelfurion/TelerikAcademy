/*
Implement the data structure linked list.

Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
*/

namespace LinkedList.API
{
    using System;
    //using System.Collections.Generic;
    using LinkedList;

    class API
    {
        static void Main(string[] args)
        {
            var firstItem = new ListItem<int>(5, null);
            var linkedList = new LinkedList<int>(firstItem);

            //TODO: IMPLEMENT FUNCTIONS
        }
    }
}
