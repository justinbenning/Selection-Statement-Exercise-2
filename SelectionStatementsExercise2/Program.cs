namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string userInput = Console.ReadLine();
            string favSubject = userInput.ToLower();
            switch (favSubject)
            {
                case "english":
                    Console.WriteLine("You like books.");
                    break;
                case "science":
                    Console.WriteLine("I think we have chemistry");
                    break;
                case "history":
                    Console.WriteLine("Four score and seven years ago");
                    break;
                case "math":
                    Console.WriteLine("Nerd");
                    break;
                default:
                    Console.WriteLine("Slacker");
                    break;
            }   
        }
    }
}