namespace TestProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite food? ");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == "lasagna")
            {
                Console.WriteLine("Yummy!");
            }
            else
            {
                Console.WriteLine("Disgusting!");
            }
            
        }
    }
}