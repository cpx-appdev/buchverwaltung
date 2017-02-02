using System;
class ErzeugeAngelegtEvent : IErzeugeAngelegtEvent
{
    AngelegtEvent IErzeugeAngelegtEvent.Handle(string titel)
    {
        return new AngelegtEvent()
        {
            Titel = titel,
            Datum = DateTime.Now,
            EventId = Guid.NewGuid()
        };
}
}
