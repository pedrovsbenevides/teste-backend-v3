using System;

namespace TheatricalPlayersRefactoringKata;

public class ComedyPlay : Play
{
    public ComedyPlay(string name, int lines, string type) : base(name, lines, type)
    {

    }

    public override int CalculateAmount(int audience)
    {
        var amount = BaseAmount;

        if (audience > 20)
        {
            amount += 10000 + 500 * (audience - 20);
        }

        amount += 300 * audience;

        return amount;
    }
}