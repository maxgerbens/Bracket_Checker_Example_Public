namespace Bracket_Checker_Example_Public;

public static class BracketChecker
{
    public static bool Check(string input)
    {
        int openCount = 0;
        int closedCount = 0;
        foreach (char c in input)
        {
            switch (c)
            {
                case '(':
                    openCount++;
                    break;
                case ')':
                    closedCount++;
                    break;
            }
        }
        return openCount == closedCount;
    }
}