using System;
using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests;

public class StatementPrinterTests
{
    [Fact]
    [UseReporter(typeof(DiffReporter))]
    public void TestStatementExampleLegacy()
    {
        var plays = new Dictionary<string, Play>
        {
            { "hamlet", new TragedyPlay("Hamlet", 4024, "tragedy") },
            { "as-like", new ComedyPlay("As You Like It", 2670, "comedy") },
            { "othello", new TragedyPlay("Othello", 3560, "tragedy") }
        };

        Invoice invoice = new Invoice(
            "BigCo",
            new List<Performance>
            {
                new Performance("hamlet", 55),
                new Performance("as-like", 35),
                new Performance("othello", 40),
            }
        );

        StatementPrinter statementPrinter = new StatementPrinter();
        var result = statementPrinter.Print(invoice, plays);

        Approvals.Verify(result);
    }

    [Fact]
    [UseReporter(typeof(DiffReporter))]
    public void TestTextStatementExample()
    {
        var plays = new Dictionary<string, Play>
        {
            { "hamlet", new TragedyPlay("Hamlet", 4024, "tragedy") },
            { "as-like", new ComedyPlay("As You Like It", 2670, "comedy") },
            { "othello", new TragedyPlay("Othello", 3560, "tragedy") },
            { "henry-v", new HistoryPlay("Henry V", 3227, "history", new ComedyPlay("Henry V", 3227, "history"), new TragedyPlay("Henry V", 3227, "history")) },
            { "john", new HistoryPlay("King John", 2648, "history", new ComedyPlay("King John", 2648, "history"), new TragedyPlay("King John", 2648, "history")) },
            { "richard-iii", new HistoryPlay("Richard III", 3718, "history", new ComedyPlay("Richard III", 3718, "history"), new TragedyPlay("Richard III", 3718, "history")) }
        };

        Invoice invoice = new Invoice(
            "BigCo",
            new List<Performance>
            {
                new Performance("hamlet", 55),
                new Performance("as-like", 35),
                new Performance("othello", 40),
                new Performance("henry-v", 20),
                new Performance("john", 39),
                new Performance("henry-v", 20)
            }
        );

        StatementPrinter statementPrinter = new StatementPrinter();
        var result = statementPrinter.Print(invoice, plays);

        Approvals.Verify(result);
    }
}
