using System;

namespace C__NumberGuesser
{
    class Program
    {

        static void Main(string[] args)
        {
            var Playing = true;
            var NumberOfGuesses = 1;
            var Lower = 0;
            var Higher = 100;
            var Guess = 50;
            var HL = "H";
            System.Console.WriteLine("What is your name?");
            var Name = Console.ReadLine();
            // game asks player to think of a number between 1 and 100
            System.Console.WriteLine($"Hello {Name}, guess a number between 1 and 100");
            // game makes an initial guess of 50 and asks player if this is the correct number, higher or lower
            // asks player if their number is "H" or "L"
            System.Console.WriteLine($"Is your number higher 'H' or lower 'L' than {Guess}?");
            HL = Console.ReadLine();
            if(HL == "H"){
                System.Console.WriteLine("it was higher");
            } else if(HL == "L"){
                System.Console.WriteLine("it was lower");
            } else{
                System.Console.WriteLine("please enter a valid entry");
            }
            // if number is "L"
            // run "lower" function
            // else if number is "H"
            //  run "higher" function
            // if lower - lower = guess, next guess is higher + guess / 2, rounded
            // if higher - higher = guess, guess = lower + guess / 2, rounded
            // asks if the new guess is the correct number, if not, repeats higher/lower
        }
    }
}
