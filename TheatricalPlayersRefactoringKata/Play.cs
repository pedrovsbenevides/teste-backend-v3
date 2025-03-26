using TheatricalPlayersRefactoringKata.Interfaces;

namespace TheatricalPlayersRefactoringKata;

public abstract class Play : IPlayAmountCalculator
{
    private string _name;
    private int _lines;
    private string _type;

    private int _baseAmount;

    public string Name { get => _name; set => _name = value; }
    public int Lines { get => _lines; set => _lines = value; }
    public string Type { get => _type; set => _type = value; }
    public int BaseAmount { get => _baseAmount; set => _baseAmount = value; }

    public Play(string name, int lines, string type)
    {
        _name = name;
        _lines = lines;
        _type = type;

        if (lines < 1000)
        {
            lines = 1000;

        }
        else if (lines > 4000)
        {
            lines = 4000;
        }

        _baseAmount = lines * 10;
    }

    public abstract int CalculateAmount(int audience);
}
