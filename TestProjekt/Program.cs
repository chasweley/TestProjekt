namespace TestProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej World!");
            Console.WriteLine("Vad heter du?");
            string nameString = Console.ReadLine();
            if (nameString = "Charlotte" || "Hjalmar" || "Huan") 
            {
                Console.WriteLine("Hej {0}", nameString);
            }
            Console.WriteLine("hmm")
        }
    }
}