public class ErzeugeBuchliste
{
    public void ErzeugeBuchliste_aus_Null_Liste()
    {
        var result = Handle(null);

        result.Count == 0;
    }

    public void ErzeugeBuchliste_aus_leerer_Liste()
    {
        var result = Handle(new AngelegtEvent[]);

        result.Count == 0;
    }

    public void ErzeugeBuchliste_aus_leerer_Liste()
    {
        var events = new[]
        {
            AngelegtEvent.Create("Foo"),
            AngelegtEvent.Create("Bar"),
        };

        var result = Handle(events);

        result.Count == 2;
    }
}