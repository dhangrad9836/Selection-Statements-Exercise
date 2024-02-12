namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialize an integer to represent a favorite number and assign a value with
            //a number of your choosing or you can assign a random number to this variable:

            //create a random number
            var r = new Random();

            //generate a random number between 1 and 1000
            var favNumber = r.Next(1, 1000);

            Console.WriteLine($"The random num is: {favNumber}");
            //ask user toguess your favorite number is
            Console.WriteLine("Can you guess my favorite number? ");

            //get user input and store in userInput variable
            var userInput = int.Parse(Console.ReadLine());

            //validate if user input is too low, too high, or if it's a correct guess
            if(userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("You guesst it!!!");
            }


            Console.WriteLine(favNumber);

            

            Console.ReadLine();

        }
    }
}
