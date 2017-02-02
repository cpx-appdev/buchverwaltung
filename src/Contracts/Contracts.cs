using System;
interface IEventStorage 
{
    BuchEvent[] LadeAlleEvents();
    void EventHinzufügen(BuchEvent @event);
    BuchEvent[] LadeEventsByBuchId(Guid buchId);
}

interface IErzeugeBuchliste
{
    Buch[] Handle(BuchEvent[] events);
}

interface IErzeugeAngelegtEvent
{
    AngelegtEvent Handle(string titel);
}

interface IErzeugeBuchLog
{
    Tuple<string, BuchLog[]> Handle(BuchEvent[] events);
}