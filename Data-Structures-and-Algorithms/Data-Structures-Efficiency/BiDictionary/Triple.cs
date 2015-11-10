namespace BiDictionary
{
    using System;

    class Triple<K, S, V>
    {

        public Triple(K key, S secondKey, V value) 
        {
            this.Key = key;
            this.SecondKey = secondKey;
            this.Value = value;
        }

        public K Key
        {
            get;
            set;
        }

        public S SecondKey
        {
            get;
            set;
        }

        public V Value
        {
            get;
            set;
        }
    }
}
