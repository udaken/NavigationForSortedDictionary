#nullable enable

namespace NavigationForSortedDictionary
{
    using System.Collections.Generic;

    public static partial class Extention
    {
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
             return CeilingEntry(dictionary, key) is { } and var entry ? entry.Key : null;
         }
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
             return FloorEntry(dictionary, key) is { } and var entry ? entry.Key : null;
         }
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
             return HigherEntry(dictionary, key) is { } and var entry ? entry.Key : null;
         }
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
             return LowerEntry(dictionary, key) is { } and var entry ? entry.Key : null;
         }
    }
}