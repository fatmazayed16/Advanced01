using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Pair<TValue, TKey>
    {
        public TValue Value { get; set; } = default!;
        public TKey Key { get; set; } = default!;
        public Pair(TValue value, TKey key)
        {
            Value = value;
            Key = key;
        }

    }
}
