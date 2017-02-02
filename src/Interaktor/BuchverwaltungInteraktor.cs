using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for BuchverwaltungInteraktor
/// </summary>
public class BuchverwaltungInteraktor
{
    private IEventStorage _eventstorage;
    
    private IErzeugeBuchliste _erzeugeBuchliste;

    private IErzeugeAngelegtEvent _erzeugeAngelegtEvent;

    private IErzeugeBuchLog _erzeugeBuchLog;

    public BuchverwaltungInteraktor(
        IEventStorage eventStorage,
        IErzeugeBuchliste erzeugeBuchliste,
        IErzeugeAngelegtEvent erzeugeAngelegtEvent,
        IErzeugeBuchLog erzeugeBuchLog)
    {
        _eventstorage = eventStorage;
        _erzeugeBuchliste = erzeugeBuchliste;
        _erzeugeAngelegtEvent = erzeugeAngelegtEvent;
        _erzeugeBuchLog = erzeugeBuchLog;
    }

    public IList<Buch> Start()
    {
        var buchEvents = _eventstorage.LadeAlleEvents();
        return _erzeugeBuchliste.Handle(buchEvents);
    }

    public void BuchAnlegen(string titel)
    {
        var angelegtEvent = _erzeugeAngelegtEvent.Handle(titel);
        _eventstorage.EventHinzufügen(angelegtEvent);
    }

      public Tuple<string, BuchLog[]> BuchlogAnzeigen(Guid buchId)
    {
        var buchevents= _eventstorage.LadeEventsByBuchId(buchId);
        return _erzeugeBuchLog.Handle(buchevents);
    }
}