using System;
using Xunit;

namespace NavigationForSortedDictionaryTest;

using NavigationForSortedDictionary;

public class NavigationForSortedDictionaryTest_Mutable
{
    SortedDictionary<int, string> _mutableDictionary = new()
    {
        { 1, "" },
        { 2, "" },
        { 5, "" },
        { 6, "" },
        { 10, "" },
    };

    [Fact]
    public void CeilingEntry()
    {
        Assert.Equal(5, _mutableDictionary.CeilingEntry(3).Value.Key);
        Assert.Equal(5, _mutableDictionary.CeilingEntry(5).Value.Key);
        Assert.Equal(10, _mutableDictionary.CeilingEntry(10).Value.Key);
        Assert.False(_mutableDictionary.CeilingEntry(11).HasValue);
    }
    [Fact]
    public void FloorEntry()
    {
        Assert.False(_mutableDictionary.FloorEntry(0).HasValue);
        Assert.Equal(1, _mutableDictionary.FloorEntry(1).Value.Key);
        Assert.Equal(10, _mutableDictionary.FloorEntry(10).Value.Key);
        Assert.Equal(10, _mutableDictionary.FloorEntry(11).Value.Key);
    }
    [Fact]
    public void HigherEntry()
    {
        Assert.Equal(1, _mutableDictionary.HigherEntry(0).Value.Key);
        Assert.Equal(5, _mutableDictionary.HigherEntry(3).Value.Key);
        Assert.Equal(6, _mutableDictionary.HigherEntry(5).Value.Key);
        Assert.False(_mutableDictionary.HigherEntry(10).HasValue);
    }
    [Fact]
    public void LowerEntry()
    {
        Assert.False(_mutableDictionary.LowerEntry(1).HasValue);
        Assert.Equal(1, _mutableDictionary.LowerEntry(2).Value.Key);
        Assert.Equal(2, _mutableDictionary.LowerEntry(5).Value.Key);
        Assert.Equal(10, _mutableDictionary.LowerEntry(11).Value.Key);
    }
    [Fact]
    public void Sub()
    {
        Assert.Equal(Enumerable.Empty<int>(), _mutableDictionary.Sub(-2, -1).Select(pair => pair.Key));
        Assert.Equal(new[] { 1, 2, 5, 6 }, _mutableDictionary.Sub(0, 6).Select(pair => pair.Key));
        Assert.Equal(new[] { 5, 6 }, _mutableDictionary.Sub(3, 6).Select(pair => pair.Key));
        Assert.Equal(new[] { 6, 10 }, _mutableDictionary.Sub(6, 11).Select(pair => pair.Key));
        Assert.Equal(Enumerable.Empty<int>(), _mutableDictionary.Sub(11, 100).Select(pair => pair.Key));
    }

    [Fact]
    public void Many()
    {
        SortedDictionary<int, string> dictionary = new();
        const int Count = 100000;
        foreach (var i in Enumerable.Range(1, Count))
            dictionary[i] = i.ToString();

        dictionary.CeilingKeyOrDefault(Count + 1);
        dictionary.FloorKeyOrDefault(Count + 1);
        Assert.False(dictionary.HigherKeyOrNull(Count + 1).HasValue);
        dictionary.LowerKeyOrDefault(Count + 1);
    }
}
