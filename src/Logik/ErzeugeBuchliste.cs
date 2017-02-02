using System;

public class ErzeugeBuchliste : IErzeugeBuchliste
{
    public Buch[] Handle(BuchEvent[] events)
    {
        foreach (var buchEvent in events)
        {
            if ((AngelegtEvent)buchEvent == null)
                continue;

            yield return new Buch
            {
                Id = buchEvent.EventId
            };
        }
    }
/*
    public void ErzeugeBuchliste_aus_Null_Liste()
    {
        var result = Handle(null);

        result.Count == 0;
    }

    public void ErzeugeBuchliste_aus_leerer_Liste()
    {
        var result = Handle(new AngelegtEvent[]);

        result.Count == 0;
    }

    public void ErzeugeBuchliste_aus_leerer_Liste()
    {
        var events = new AngelegtEvent
        
        var result = Handle(new AngelegtEvent[]);

        result.Count == 0;
    }
*/

}