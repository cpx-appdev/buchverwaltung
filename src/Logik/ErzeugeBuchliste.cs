using System;
using System.Collections.Generic;
public class ErzeugeBuchliste : IErzeugeBuchliste
{
    public Buch[] Handle(BuchEvent[] events)
    {
        var result = new List<Buch>();
        foreach (var buchEvent in events)
        {
            if ((AngelegtEvent)buchEvent == null)
                continue;
            result.Add(new Buch
            {
                Id = buchEvent.EventId
            });
        }
        return result.ToArray();
    }
}