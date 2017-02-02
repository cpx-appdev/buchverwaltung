using System;
public class ErzeugeAngelegtEvent : IErzeugeAngelegtEvent
{
    public AngelegtEvent Handle(string titel)
    {
        if (string.IsNullOrWhiteSpace(titel))
            throw new NotSupportedException();

        return AngelegtEvent.Create(titel);
    }
}
