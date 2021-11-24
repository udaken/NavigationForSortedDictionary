using System.Linq;
using System.Collections.Generic;

namespace NavigationForSortedDictionary
{

    public static partial class Extention
    {
        public static KeyValuePair<TKey, TValue>? CeilingEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            foreach (var entry in dictionary)
            {
                var result = dictionary.Comparer.Compare(entry.Key, key);
                if (result >= 0)
                {
                    return entry;
                }
            }
            return null;
        }
        public static KeyValuePair<TKey, TValue>? FloorEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            var floor = default(KeyValuePair<TKey, TValue>?);
            foreach (var entry in dictionary)
            {
                var result = dictionary.Comparer.Compare(entry.Key, key);
                if (result < 0)
                {
                    floor = entry;
                }
                else if (result == 0)
                {
                    return entry;
                }
                else
                {
                    break;
                }
            }
            return floor;
        }
        public static IEnumerable<KeyValuePair<TKey, TValue>> Sub<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey from, TKey to)
            where TKey : notnull
        {
            for (var e = dictionary.GetEnumerator(); e.MoveNext();)
            {
                if (dictionary.Comparer.Compare(e.Current.Key, from) >= 0)
                {
                    do
                    {
                        if (dictionary.Comparer.Compare(e.Current.Key, to) <= 0)
                            yield return e.Current;
                        else
                            yield break;
                    } while (e.MoveNext());
                }
            }
        }
        public static KeyValuePair<TKey, TValue>? HigherEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key) where TKey : notnull
        {
            foreach (var entry in dictionary)
            {
                if (dictionary.Comparer.Compare(entry.Key, key) > 0)
                {
                    return entry;
                }
            }
            return null;
        }

        public static KeyValuePair<TKey, TValue>? LowerEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key) where TKey : notnull
        {
            var lowest = default(KeyValuePair<TKey, TValue>?);
            foreach (var entry in dictionary)
            {
                if (dictionary.Comparer.Compare(entry.Key, key) < 0)
                {
                    lowest = entry;
                }
                else
                {
                    break;
                }
            }
            return lowest;
        }

        public static IEnumerable<KeyValuePair<TKey, TValue>> Head<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key, bool inclusive = true)
            where TKey : notnull
        {
            foreach (var entry in dictionary)
            {
                var result = dictionary.Comparer.Compare(entry.Key, key);
                if (result < 0)
                {
                    yield return entry;
                }
                else if (inclusive && result == 0)
                {
                    yield return entry;
                }
                else
                {
                    yield break;
                }
            }
        }
        public static IEnumerable<KeyValuePair<TKey, TValue>> Tail<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key, bool inclusive = true)
            where TKey : notnull
        {
            foreach (var entry in dictionary)
            {
                var result = dictionary.Comparer.Compare(entry.Key, key);
                if (result < 0)
                {
                    continue;
                }
                else if (inclusive && result == 0)
                {
                    yield return entry;
                }
                else
                {
                    yield return entry;
                }
            }
        }

        public static KeyValuePair<TKey, TValue>? PollFirstEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary)
            where TKey : notnull
        {
            var entry = dictionary.FirstOrDefault();
            return dictionary.Remove(entry.Key) ? entry : null;
        }

        public static KeyValuePair<TKey, TValue>? PollLastEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary)
            where TKey : notnull
        {
            var entry = dictionary.LastOrDefault();
            return dictionary.Remove(entry.Key) ? entry : null;
        }
    }
}