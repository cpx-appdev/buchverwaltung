using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for BuchverwaltungInteraktor
/// </summary>
public class BuchverwaltungInteraktor
{
    private IEventStorage _eventstorage;
    private IErzeugeBuchliste _erzeugeBuchliste;

    public BuchverwaltungInteraktor(
        IEventStorage eventStorage,
        IErzeugeBuchliste erzeugeBuchliste)
    {
        _eventstorage = eventStorage;
        _erzeugeBuchliste = erzeugeBuchliste;
    }

    public IList<Buch> Start()
    {
        var buchEvents = _eventstorage.LadeAlleEvents();
        return _erzeugeBuchliste.Handle(buchEvents);
    }
}