using System;
using System.Collections.Generic;
using System.Linq;

class ErzeugeBuchLog : IErzeugeBuchLog
{
    public Tuple<string, BuchLog[]> Handle(BuchEvent[] events)
    {
        var angelegtEvent = events.FirstOrDefault(x => x is AngelegtEvent) as AngelegtEvent;
        var buchtitel = angelegtEvent != null ? angelegtEvent.Titel : "";

        var log = new List<BuchLog>();

        foreach (var e in events.OrderBy(x => x.Datum))
        {
            log.Add(Map(e));
        }

        return new Tuple<string, BuchLog[]>(buchtitel, log.ToArray());
    }

    private BuchLog Map(BuchEvent @event)
    {
        // use DI later here, MappingLogic for poor coders...

        switch (@event.GetType().Name)
        {
            case nameof(AngelegtEvent):
                return MapAngelegtEventToLog(@event as AngelegtEvent);
        }
        return null;
    }

    private BuchLog MapAngelegtEventToLog(AngelegtEvent @event)
    {
        return new BuchLog { Ereignis = "Angelegt", Datum = @event.Datum, Daten = @event.Titel };
    }
}