using System;
class ErzeugeBuchLog : IErzeugeBuchLog
{
    Tuple<string, BuchLog[]> IErzeugeBuchLog.Handle(BuchEvent[] events)
    {
        throw new NotImplementedException();
    }
}