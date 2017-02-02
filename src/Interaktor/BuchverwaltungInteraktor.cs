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

    public BuchverwaltungInteraktor(
        IEventStorage eventStorage,
        IErzeugeBuchliste erzeugeBuchliste,
        IErzeugeAngelegtEvent erzeugeAngelegtEvent)
    {
        _eventstorage = eventStorage;
        _erzeugeBuchliste = erzeugeBuchliste;
        _erzeugeAngelegtEvent = erzeugeAngelegtEvent;
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
}