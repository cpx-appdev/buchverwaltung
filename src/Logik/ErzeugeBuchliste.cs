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
}