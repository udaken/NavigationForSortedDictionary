using System;
using Xunit;
using NavigationForSortedDictionary;

namespace NavigationForSortedDictionaryTest;

public class NavigationForSortedDictionaryTest
{
    SortedDictionary<int, string> _dictionary = new()
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
        Assert.Equal(5, _dictionary.CeilingEntry(3).Value.Key);
        Assert.Equal(5, _dictionary.CeilingEntry(5).Value.Key);
        Assert.Equal(10, _dictionary.CeilingEntry(10).Value.Key);
        Assert.False(_dictionary.CeilingEntry(11).HasValue);
    }
    [Fact]
    public void FloorEntry()
    {
        Assert.False(_dictionary.FloorEntry(0).HasValue);
        Assert.Equal(1, _dictionary.FloorEntry(1).Value.Key);
        Assert.Equal(10, _dictionary.FloorEntry(10).Value.Key);
        Assert.Equal(10, _dictionary.FloorEntry(11).Value.Key);
    }
    [Fact]
    public void HigherEntry()
    {
        Assert.Equal(1, _dictionary.HigherEntry(0).Value.Key);
        Assert.Equal(5, _dictionary.HigherEntry(3).Value.Key);
        Assert.Equal(6, _dictionary.HigherEntry(5).Value.Key);
        Assert.False(_dictionary.HigherEntry(10).HasValue);
    }
    [Fact]
    public void LowerEntry()
    {
        Assert.False(_dictionary.LowerEntry(1).HasValue);
        Assert.Equal(1, _dictionary.LowerEntry(2).Value.Key);
        Assert.Equal(2, _dictionary.LowerEntry(5).Value.Key);
        Assert.Equal(10, _dictionary.LowerEntry(11).Value.Key);
    }
    [Fact]
    public void Sub()
    {
        Assert.Equal(Enumerable.Empty<int>(), _dictionary.Sub(-2, -1).Select(pair => pair.Key));
        Assert.Equal(new[] { 1, 2, 5, 6 }, _dictionary.Sub(0, 6).Select(pair => pair.Key));
        Assert.Equal(new[] { 5, 6 }, _dictionary.Sub(3, 6).Select(pair => pair.Key));
        Assert.Equal(new[] { 6, 10 }, _dictionary.Sub(6, 11).Select(pair => pair.Key));
        Assert.Equal(Enumerable.Empty<int>(), _dictionary.Sub(11, 100).Select(pair => pair.Key));
    }
}
