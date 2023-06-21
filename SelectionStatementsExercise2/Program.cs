namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, what's your favorite school subject?");
            var response = Console.ReadLine();
            switch(response.ToLower())
            {
                case "math":
                    Console.WriteLine("Math Magic, huh?");
                    break;
                case "english":
                    Console.WriteLine("I'm sure we can still be friends, but I'm gonna keep my distance");
                    break;
                case "history":
                    Console.WriteLine("I like my terrifying tales every once in a while");
                    break;
                case "science":
                    Console.WriteLine("Indium Tellurium Rhenium Sulfur Titanium Nitrogen, those elements will never fofrm a compound! isnt that In Te Re S Ti N");
                    break;
                case "art":
                    Console.WriteLine("Personally, I prefer a more grounded subject, but there is a one of a kind beauty in art");
                    break;
                default:
                    Console.WriteLine("Oh, trying to be different? Ok buddy");
                    break;

            }
        }
    }
}