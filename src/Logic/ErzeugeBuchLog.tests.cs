using System;
using System.Collections.Generic;

public class ErzeugeBuchLogTest
{


    public void Validiere_Mapping_AngelegtEvent()
    {
        // Arange
        var buchLogHandler = new ErzeugeBuchLog();
        var buchEvents = new List<AngelegtEvent>();

        buchEvents.Add(new AngelegtEvent() { Titel = "VB6", Datum = DateTime.Parse("2017-02-01"), EventId =  new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7")  } );

        // Act
        var result = buchLogHandler.Handle(buchEvents.ToArray());

        // Assert

        //result.



    }

}