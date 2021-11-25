using System;
using Xunit;
using System.Collections.Immutable;

namespace NavigationForSortedDictionaryTest;

using NavigationForSortedDictionary;

public class NavigationForSortedDictionaryTest_Immutable
{
    ImmutableSortedDictionary<int, string> _mutableDictionary = new Dictionary<int, string>()
    {
        { 1, "" },
        { 2, "" },
        { 5, "" },
        { 6, "" },
        { 10, "" },
    }.ToImmutableSortedDictionary();

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
}
