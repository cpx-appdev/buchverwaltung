using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

public class ErzeugeBuchlisteTests
{
    [Fact]
    public void ErzeugeBuchliste_aus_Null_Liste()
    {
        var result = new ErzeugeBuchliste().Handle(null);

        result.Length.ShouldBe(0);
    }

    [Fact]
    public void ErzeugeBuchliste_aus_leerer_Liste()
    {
        var result = new ErzeugeBuchliste().Handle(new AngelegtEvent[0]);

        result.Length.ShouldBe(0);
    }

    [Fact]
    public void ErzeugeBuchliste_aus_normaler_Liste()
    {
        var events = new[]
        {
            AngelegtEvent.Create("Foo"),
            AngelegtEvent.Create("Bar"),
        };

        var result = new ErzeugeBuchliste().Handle(events);

        result.Length.ShouldBe(2);
    }
}