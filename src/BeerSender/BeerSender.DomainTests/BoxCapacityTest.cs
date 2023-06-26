﻿using BeerSender.Domain;

namespace BeerSender.DomainTests;

public class BoxCapacityTest
{
    [Theory]
    [InlineData(6)]
    [InlineData(12)]
    [InlineData(24)]
    public void IfCapacityIsValid_ShouldReturnNewCapacity(int numberOfSpots)
    {
        var capacity = new BoxCapacity(numberOfSpots);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(7)]
    [InlineData(23)]
    public void IfCapacityIsInvalid_ShouldThrowException(int numberOfSpots)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var capacity = new BoxCapacity(numberOfSpots);
        });
    }
};