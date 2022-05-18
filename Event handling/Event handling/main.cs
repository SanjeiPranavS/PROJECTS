namespace Event_handling
{
    internal class Entry
    {
        public static void Main(string[] args)
        {
            server.VirusAlerter += new Security().AllertPoilce;
            server.VirusAlerter += new Security().EnageAntiVirus;
            var data = new Input();
            data.data = Console.ReadLine();
            server.AddData(data);
            

            Console.ReadKey();


        }












    }
}
