namespace BiDictionary
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    class BiDictionary<K, S, V>
    {
        //could be done with just a list
        public BiDictionary()
        {
            this.FirstKeyDictionary = new OrderedMultiDictionary<K, V>(true);
            this.SecondKeyDictionary = new OrderedMultiDictionary<S, V>(true);
        }

        public OrderedMultiDictionary<K, V> FirstKeyDictionary
        {
            get;
            set;
        }

        public OrderedMultiDictionary<S, V> SecondKeyDictionary
        {
            get;
            set;
        }

        public void Add(K key, S secondKey, V value)
        {
            this.FirstKeyDictionary[key].Add(value);
            this.SecondKeyDictionary[secondKey].Add(value);
        }

        public IEnumerable<KeyValuePair<K, ICollection<V>>> FindByKey(K key)
        {
            return this.FirstKeyDictionary.Where(x => x.Key.Equals(key));
        }

        public IEnumerable<KeyValuePair<S, ICollection<V>>> FindBySecondKey(S secondKey)
        {
            return this.SecondKeyDictionary.Where(x => x.Key.Equals(secondKey));
        }
    }
}
