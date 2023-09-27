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
        }
    }
}