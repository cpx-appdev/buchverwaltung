using System;
public class Buch
{
    public Guid Id { get; set; }
    public string Titel { get; set; }
    public string VerliehenAn { get; set; }
    public DateTime VerliehenAm { get; set; }
}

public class BuchLog
{
    public string Ereignis { get; set; }
    public DateTime Datum { get; set; }
    public string Daten { get; set; }
}