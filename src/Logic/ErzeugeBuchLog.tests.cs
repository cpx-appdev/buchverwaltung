using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

public class ErzeugeBuchLogTest
{

    [Fact]
    public void Validiere_Mapping_AngelegtEvent()
    {
        // Arange
        var buchLogHandler = new ErzeugeBuchLog();
        var buchEvents = new List<AngelegtEvent>();

        buchEvents.Add(new AngelegtEvent() {
            Titel = "VB6",
            Datum = DateTime.Parse("2017-02-01"),
            BuchId =  new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7")  } );

        // Act
        var result = buchLogHandler.Handle(buchEvents.ToArray());

        // Assert
        result.Item1.ShouldBe("VB6");
        result.Item2.ShouldContain(new BuchLog() { Daten = "VB6", Datum = DateTime.Parse("2017-02-01"), Ereignis = "Angelegt" });
        result.Item2.Length.ShouldBe(1);
    }


}