using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

public class ErzeugeAngelegtEventTest
{

    [Fact]
    public void Buch_ohne_Titel_wirft_Exception()
    {
        var erzeugeAngelegtEvent = new ErzeugeAngelegtEvent();
        Should.Throw<NotSupportedException>(
            () =>erzeugeAngelegtEvent.Handle(string.Empty)
        );        
    }
}