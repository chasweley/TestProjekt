namespace TestProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en siffra: ");
            int number = int.Parse(Console.ReadLine());

            if (number != 5)
            {
                Console.WriteLine("Du har skrivit fel siffra.");
            }
            else
            {
                Console.WriteLine("Bra gjort.");
            }
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