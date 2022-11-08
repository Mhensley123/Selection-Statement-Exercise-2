using System.Reflection.Metadata.Ecma335;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            
            var subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is not my cup of tea!");
                    break;
                case "science":
                    Console.WriteLine("Science is very interesting but it's not my fav.");
                    break ;
                case "home economics":
                    Console.WriteLine("Yes! Cooking is so much fun!");
                    break ;
                    default: Console.WriteLine("Sounds like a really fun class but I've never taken it before.");
                    break;





            }
        }
    }
}