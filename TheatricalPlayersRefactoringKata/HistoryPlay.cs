using System;

namespace TheatricalPlayersRefactoringKata;

public class HistoryPlay : Play
{
    private readonly ComedyPlay _comedyPlay;
    private readonly TragedyPlay _tragedyPlay;

    public ComedyPlay ComedyPlay { get => _comedyPlay; }
    public TragedyPlay TragedyPlay { get => _tragedyPlay; }

    public HistoryPlay(string name, int lines, string type) : base(name, lines, type)
    {
        _comedyPlay = new ComedyPlay(name, lines, type);
        _tragedyPlay = new TragedyPlay(name, lines, type);
        BaseAmount *= 2;
    }

    public override int CalculateAmount(int audience)
    {
        var amount = ComedyPlay.CalculateAmount(audience) + TragedyPlay.CalculateAmount(audience);

        return amount;
    }
}
