using System;
using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata;

public class HistoryPlay : Play
{
    private readonly IPlayAmountCalculator _comedyPlay;
    private readonly IPlayAmountCalculator _tragedyPlay;

    public IPlayAmountCalculator ComedyPlay { get => _comedyPlay; }
    public IPlayAmountCalculator TragedyPlay { get => _tragedyPlay; }

    public HistoryPlay(string name, int lines, string type, IPlayAmountCalculator comedyPlay, IPlayAmountCalculator tragedyPlay) : base(name, lines, type)
    {
        _comedyPlay = comedyPlay;
        _tragedyPlay = tragedyPlay;
        BaseAmount *= 2;
    }

    public override int CalculateAmount(int audience)
    {
        var amount = ComedyPlay.CalculateAmount(audience) + TragedyPlay.CalculateAmount(audience);

        return amount;
    }
}
