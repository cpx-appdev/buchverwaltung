using System;

public class ErzeugeBuchlisteTests
{
 
    public void ErzeugeBuchliste_aus_Null_Liste()
    {
        //var result = Handle(null);

        //result.Length == 0;
    }

    public void ErzeugeBuchliste_aus_leerer_Liste()
    {
        //var result = Handle(new AngelegtEvent[0]);

        //result.Length == 0;
    }

    public void ErzeugeBuchliste_aus_normaler_Liste()
    {
        var events = new[]
        {
            AngelegtEvent.Create("Foo"),
            AngelegtEvent.Create("Bar"),
        };

        //var result = Handle(events);

        //result.Length == 2;
    }
}