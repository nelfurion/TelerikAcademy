using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_HashTable.HashTable
{
    class HashTable<K, T>
    {
        private LinkedList<KeyValuePair<K, T>>[] data;
        private int currentCapacity = 16;
        private int top = 0;

        public HashTable()
        {
            this.data = new LinkedList<KeyValuePair<K, T>>[this.currentCapacity];
        }

        private void ExtendCapacity()
        {
            if (this.data.Length > this.currentCapacity - this.currentCapacity / 4)
            {
                this.currentCapacity *= 2;
                LinkedList<KeyValuePair<K, T>>[] newList = new LinkedList<KeyValuePair<K, T>>[currentCapacity];
                this.data.CopyTo(newList, 0);
                this.data = newList;
            }
        }

        public void Add(K key, T value)
        {
            this.data[this.top].AddLast(new KeyValuePair<K, T>(key, value));
        }

        public T? Find(K key)
        {
            foreach (var list in this.data)
            {
                foreach (var listItem in list)
	            {
		            if (listItem.Key.Equals(key))
	                {
		                return listItem.Value;
	                }
	            }
            }

            return null;
        }
    }
}
