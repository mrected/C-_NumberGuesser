using System;

namespace C__NumberGuesser
{
    class Program
    {
        public int Lower = 0;

        static void Main(string[] args)
        {
            var Playing = true;
            var Tries = 0;
            Double Lower = 1;
            Double Higher = 100;
            Double Guess = 50;
            var HL = "h";
            var Correct = "n";
            System.Console.WriteLine("What is your name?");
            var Name = Console.ReadLine();

            System.Console.WriteLine($"Hello {Name}, guess a number between 1 and 100");
            System.Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            while(Playing){
                System.Console.WriteLine($"Is your number {Guess}? y/n");
                Tries++;
                Correct = Console.ReadLine();
                if(Correct == "y"){
                    Playing = false;
                } else if(Correct == "n"){
                    System.Console.WriteLine($"Is your number higher 'h' or lower 'l' than {Guess}?");
                    HL = Console.ReadLine();
                    if(HL == "h"){
                        Lower = Guess;
                        Guess = Math.Round((Higher + Guess) / 2);
                    } else if(HL == "l"){
                        Higher = Guess;
                        Guess = Math.Round((Lower + Guess) / 2);
                    } else{
                        System.Console.WriteLine("please enter a valid entry");
                    }
                } else {
                    System.Console.WriteLine("Please enter a valid entry");
                }
            }
            Playing = false;
            System.Console.WriteLine($"Thanks for playing {Name}, I guessed your number: {Guess} in {Tries} tries.");
            
        }
    }
}
