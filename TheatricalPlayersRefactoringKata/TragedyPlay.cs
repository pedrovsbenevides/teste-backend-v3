using System;

namespace TheatricalPlayersRefactoringKata;

public class TragedyPlay : Play
{
    public TragedyPlay(string name, int lines, string type) : base(name, lines, type)
    {

    }

    public override int CalculateAmount(int audience)
    {
        var amount = BaseAmount;

        if (audience > 30)
        {
            amount += 1000 * (audience - 30);
        }

        return amount;
    }
}