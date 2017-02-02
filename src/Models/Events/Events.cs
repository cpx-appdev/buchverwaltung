using System;

public abstract class BuchEvent
{
    public Guid EventId { get; set; }
    public DateTime Datum { get; set; }
}
public class AngelegtEvent : BuchEvent
{
    public string Titel { get; set; }
}