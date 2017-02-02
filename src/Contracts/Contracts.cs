using System;
public interface IEventStorage 
{
    BuchEvent[] LadeAlleEvents();
    void EventHinzufügen(BuchEvent @event);
    BuchEvent[] LadeEventsByBuchId(Guid buchId);
}

public interface IErzeugeBuchliste
{
    Buch[] Handle(BuchEvent[] events);
}

public interface IErzeugeAngelegtEvent
{
    AngelegtEvent Handle(string titel);
}

public interface IErzeugeBuchLog
{
    Tuple<string, BuchLog[]> Handle(BuchEvent[] events);
}