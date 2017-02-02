using System.Collections.Generic;

public class ErzeugeBuchliste : IErzeugeBuchliste
{
    public Buch[] Handle(BuchEvent[] events)
    {
        if (events == null)
            return new Buch[0];

        var result = new List<Buch>();
        foreach (var buchEvent in events)
        {
            var angelegtEvent = buchEvent as AngelegtEvent;

            if (angelegtEvent != null)
            {
                result.Add(new Buch
                {
                    Titel = angelegtEvent.Titel,
                    Id = angelegtEvent.BuchId
                });
            }
        }
        return result.ToArray();
    }
}