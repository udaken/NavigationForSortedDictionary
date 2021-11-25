#nullable enable

namespace NavigationForSortedDictionary
{
    using System.Collections.Generic;
#if SUPPORT_IMMUTABLE
    using System.Collections.Immutable;
#endif

    public static partial class Extention
    {
        public static KeyValuePair<TKey, TValue>? CeilingEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return CeilingEntryInternal<SortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.Comparer, key);
        }
#if SUPPORT_IMMUTABLE
        public static KeyValuePair<TKey, TValue>? CeilingEntry<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return CeilingEntryInternal<ImmutableSortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.KeyComparer, key);
        }
#endif

        public static TKey? CeilingKey<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return CeilingEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? CeilingKeyOrDefault<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return CeilingEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? CeilingKeyOrNull<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return CeilingEntry(dictionary, key)?.Key;
        }
#if SUPPORT_IMMUTABLE
        public static TKey? CeilingKey<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return CeilingEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? CeilingKeyOrDefault<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return CeilingEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? CeilingKeyOrNull<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return CeilingEntry(dictionary, key)?.Key;
        }
#endif
        public static KeyValuePair<TKey, TValue>? FloorEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return FloorEntryInternal<SortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.Comparer, key);
        }
#if SUPPORT_IMMUTABLE
        public static KeyValuePair<TKey, TValue>? FloorEntry<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return FloorEntryInternal<ImmutableSortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.KeyComparer, key);
        }
#endif

        public static TKey? FloorKey<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return FloorEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? FloorKeyOrDefault<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return FloorEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? FloorKeyOrNull<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return FloorEntry(dictionary, key)?.Key;
        }
#if SUPPORT_IMMUTABLE
        public static TKey? FloorKey<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return FloorEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? FloorKeyOrDefault<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return FloorEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? FloorKeyOrNull<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return FloorEntry(dictionary, key)?.Key;
        }
#endif
        public static KeyValuePair<TKey, TValue>? HigherEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return HigherEntryInternal<SortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.Comparer, key);
        }
#if SUPPORT_IMMUTABLE
        public static KeyValuePair<TKey, TValue>? HigherEntry<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return HigherEntryInternal<ImmutableSortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.KeyComparer, key);
        }
#endif

        public static TKey? HigherKey<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return HigherEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? HigherKeyOrDefault<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return HigherEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? HigherKeyOrNull<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return HigherEntry(dictionary, key)?.Key;
        }
#if SUPPORT_IMMUTABLE
        public static TKey? HigherKey<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return HigherEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? HigherKeyOrDefault<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return HigherEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? HigherKeyOrNull<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return HigherEntry(dictionary, key)?.Key;
        }
#endif
        public static KeyValuePair<TKey, TValue>? LowerEntry<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return LowerEntryInternal<SortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.Comparer, key);
        }
#if SUPPORT_IMMUTABLE
        public static KeyValuePair<TKey, TValue>? LowerEntry<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : notnull
        {
            return LowerEntryInternal<ImmutableSortedDictionary<TKey, TValue>, TKey, TValue>(dictionary, dictionary.KeyComparer, key);
        }
#endif

        public static TKey? LowerKey<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return LowerEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? LowerKeyOrDefault<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return LowerEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? LowerKeyOrNull<TKey, TValue>(this SortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return LowerEntry(dictionary, key)?.Key;
        }
#if SUPPORT_IMMUTABLE
        public static TKey? LowerKey<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
           where TKey : notnull
        {
            return LowerEntry(dictionary, key) is { } and var entry ? entry.Key : throw new KeyNotFoundException();
        }
        public static TKey? LowerKeyOrDefault<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key, TKey? defaultValue = default)
            where TKey : notnull
        {
            return LowerEntry(dictionary, key) is { } and var entry ? entry.Key : defaultValue;
        }
        public static TKey? LowerKeyOrNull<TKey, TValue>(this ImmutableSortedDictionary<TKey, TValue> dictionary, TKey key)
            where TKey : struct
        {
            return LowerEntry(dictionary, key)?.Key;
        }
#endif
    }
}