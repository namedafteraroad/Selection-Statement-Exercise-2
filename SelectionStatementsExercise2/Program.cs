namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Ah a mathematicain, hello");
                    break;
                case "science":
                    Console.WriteLine("science the key to the universe, hello");
                    break;
                case "history":
                    Console.WriteLine("the study of the past, key to the future, hello");
                    break;
                case "language":
                    Console.WriteLine("the art of letter and word to form much more, hello");
                    break;
                case "geography":
                    Console.WriteLine("the study of the ground we inhabit, hello");
                    break;
                default:
                    Console.WriteLine("Please pick another subjecti!");
                    break;
            }
        }
    }
}