using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableExample
{
    public class HashDictionary<K, V> : IDictionary<K, V>, IEnumerable<KeyValuePair<K,V>> 
    {
        private const int DEFAULT_CAPACTY = 16;
        private const float DEFAULT_LOAD_FACTOR = 0.75f;
    }
}
