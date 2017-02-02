using System;
public class ErzeugeAngelegtEvent : IErzeugeAngelegtEvent
{
    public AngelegtEvent Handle(string titel)
    {
        return AngelegtEvent.Create(titel);
    }
}
