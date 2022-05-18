namespace FbConsoleApk.Controller;

public class Validation
{
    public static bool ValidUserInput(int value, int start, int end)
    {
        return value >= start && value <= end;
    }
}