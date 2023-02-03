namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string retry;
            do
            {
                retry = "no";
                Console.WriteLine("What is your favorite school subject?");
                var favSubject = Console.ReadLine();

                switch (favSubject)
                {
                    case "math":
                    case "Math":
                        Console.WriteLine("Math is Great!");
                        break;
                    case "english":
                    case "English":
                        Console.WriteLine("English is fun!");
                        break;
                    case "history":
                    case "History":
                        Console.WriteLine("Some history is fun.");
                        break;
                    case "science":
                    case "Science":
                        Console.WriteLine("Sience is awful.");
                        break;
                    case "biomimicry":
                    case "Biomimicry":
                        Console.WriteLine("I don't know what that is.");
                        break;
                    default:
                        Console.WriteLine("Don't break my code! Do you want to enter a real subject?");
                        retry = Console.ReadLine();
                        break;
                }
            }
            while (retry != "no");
        }
    }
}