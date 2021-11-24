using System.Linq;
using System.Collections.Generic;

namespace NavigationForSortedDictionary
{

    public static partial class Extention
    {
        public static bool TryGetCeiling<T>(this SortedSet<T> set, T key, out T? result)
        {
            foreach (var entry in set)
            {
                if (set.Comparer.Compare(entry, key) >= 0)
                {
                    result = entry;
                    return true;
                }
            }
            result = default;
            return false;
        }
        public static bool TryGetFloor<T>(this SortedSet<T> set, T key, out T? result)
        {
            bool found = false;
            result = default;
            foreach (var entry in set)
            {
                var n = set.Comparer.Compare(entry, key);
                if (n < 0)
                {
                    result = entry;
                    found = true;
                }
                else if (n == 0)
                {
                    result = entry;
                    return true;
                }
                else
                {
                    break;
                }
            }
            return found;
        }
        public static bool TryGetHigher<T>(this SortedSet<T> set, T key, out T? result)
        {
            foreach (var entry in set)
            {
                if (set.Comparer.Compare(entry, key) > 0)
                {
                    result = entry;
                    return true;
                }
            }
            result = default;
            return false;
        }

        public static bool TryGetLower<T>(this SortedSet<T> set, T key, out T? result)
        {
            bool found = false;
            result = default;
            foreach (var entry in set)
            {
                if (set.Comparer.Compare(entry, key) < 0)
                {
                    result = entry;
                    found = true;
                }
                else
                {
                    break;
                }
            }
            return found;
        }

    }
}