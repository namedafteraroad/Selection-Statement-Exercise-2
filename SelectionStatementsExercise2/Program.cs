namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var subject and takes userinput 
            Console.WriteLine("What is your favorite subject in school");
            var subject = Console.ReadLine();
            //switch adds to lower, makes all letters lowercase
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
                //anything not stated as a case will default to the default
                default:
                    Console.WriteLine("Please pick another subject!");
                    break;
            }
        }
    }
}