namespace Event_handling;

class server
{
    public static event EventHandler<EventArgs> VirusAlerter;
    public static void  AddData(Input input)
    {
        if (IsSafe(input))
        {
            DaoConnector(input);
        }
        else
        {
            AllertEveryone();
        }
    }

    private static bool IsSafe(Input input)
    {
        if (input.data.Contains("virus"))
            return false;
        else
        {
            return true;
        }
    }

    private static void DaoConnector(Input input)
    {
        Console.WriteLine($"{input.data}  data added to data base ");
    }
    public static void AllertEveryone()
    {
        if(VirusAlerter!=null)
        server.VirusAlerter(new server(), EventArgs.Empty);
    }
}