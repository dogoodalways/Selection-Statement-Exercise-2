namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var userAnswer = Console.ReadLine();

            switch(userAnswer.ToLower())
            {
                case "math":
                    Console.WriteLine("You like logic.");
                        break;
                case "literature":
                    Console.WriteLine("You like stories.");
                    break;
                case "science":
                    Console.WriteLine("You like facts");
                    break;
                case "hisotry":
                    Console.WriteLine("You like events");
                    break;
                case "anatomy":
                    Console.WriteLine("You like to know yourself");
                    break;

                default: 
                    Console.WriteLine("You wish you liked something");
                    break;


            }
        }
    }
}