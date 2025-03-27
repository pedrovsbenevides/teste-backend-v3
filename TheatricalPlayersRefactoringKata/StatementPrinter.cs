using System.Collections.Generic;
using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata;

public class StatementPrinter

{
    private IStatementFormatter _formatter;

    public IStatementFormatter Formatter { get => _formatter; set => _formatter = value; }

    public StatementPrinter(IStatementFormatter formatter)
    {
        Formatter = formatter;
    }

    public string Print(Invoice invoice, Dictionary<string, Play> plays)
    {
        return Formatter.Format(invoice, plays);
    }
}
