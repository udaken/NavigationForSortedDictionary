namespace NavigationForSortedSet
{
    using System.Linq;
    using System.Collections.Generic;
#if SUPPORT_IMMUTABLE
    using System.Collections.Immutable;
#endif

    public static partial class Extention
    {
        public static bool TryGetCeiling<T>(this SortedSet<T> set, T key, out T? result)
        {
            return TryGetCeilingInternal(set, set.Comparer, key, out result);
        }

#if SUPPORT_IMMUTABLE
        public static bool TryGetCeiling<T>(this ImmutableSortedSet<T> set, T key, out T? result)
        {
            return TryGetCeilingInternal(set, set.KeyComparer, key, out result);
        }
#endif

        private static bool TryGetCeilingInternal<TSet, T>(TSet set, IComparer<T> comparer, T key, out T? result)
            where TSet : ISet<T>
        {
            foreach (var entry in set)
            {
                if (comparer.Compare(entry, key) >= 0)
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
            return TryGetFloorInternal(set, set.Comparer, key, out result);
        }

#if SUPPORT_IMMUTABLE
        public static bool TryGetFloor<T>(this ImmutableSortedSet<T> set, T key, out T? result)
        {
            return TryGetFloorInternal(set, set.KeyComparer, key, out result);
        }
#endif

        private static bool TryGetFloorInternal<TSet, T>(TSet set, IComparer<T> comparer, T key, out T? result)
            where TSet : ISet<T>
        {
            bool found = false;
            result = default;
            foreach (var entry in set)
            {
                var n = comparer.Compare(entry, key);
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
            return TryGetHigherInternal(set, set.Comparer, key, out result);
        }
#if SUPPORT_IMMUTABLE
        public static bool TryGetHigher<T>(this ImmutableSortedSet<T> set, T key, out T? result)
        {
            return TryGetHigherInternal(set, set.KeyComparer, key, out result);
        }
#endif

        private static bool TryGetHigherInternal<TSet, T>(TSet set, IComparer<T> comparer, T key, out T? result)
            where TSet : ISet<T>
        {
            foreach (var entry in set)
            {
                if (comparer.Compare(entry, key) > 0)
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
            return TryGetLowerInternal(set, set.Comparer, key, out result);
        }
#if SUPPORT_IMMUTABLE
        public static bool TryGetLower<T>(this ImmutableSortedSet<T> set, T key, out T? result)
        {
            return TryGetLowerInternal(set, set.KeyComparer, key, out result);
        }
#endif

        private static bool TryGetLowerInternal<TSet, T>(TSet set, IComparer<T> comparer, T key, out T? result)
            where TSet : ISet<T>
        {
            bool found = false;
            result = default;
            foreach (var entry in set)
            {
                if (comparer.Compare(entry, key) < 0)
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