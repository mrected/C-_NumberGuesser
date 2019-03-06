using System;

namespace C__NumberGuesser
{
    class Program
    {
        public int Lower = 0;

        static void Main(string[] args)
        {
            var Playing = true;
            int Lower = 1;
            int Higher = 100;
            int Guess = 50;
            var HL = "h";
            var Correct = "n";
            System.Console.WriteLine("What is your name?");
            var Name = Console.ReadLine();

            System.Console.WriteLine($"Hello {Name}, guess a number between 1 and 100");
            while(Playing){
                System.Console.WriteLine($"Is your number {Guess}? y/n");
                Correct = Console.ReadLine();
                if(Correct == "y"){
                    Playing = false;
                } else if(Correct == "n"){
                    System.Console.WriteLine($"Is your number higher 'h' or lower 'l' than {Guess}?");
                    HL = Console.ReadLine();
                    if(HL == "h"){
                        Higher = Guess;
                        Guess = (Lower + Guess) / 2;
                    } else if(HL == "l"){
                        Lower = Guess;
                        Guess = (Higher + Guess) / 2;
                    } else{
                        System.Console.WriteLine("please enter a valid entry");
                    }
                    System.Console.WriteLine($"Is your number {Guess}? y/n");
                    Correct = Console.ReadLine();
                } else {
                    System.Console.WriteLine("Please enter a valid entry");
                }
            }
            
        }
    }
}
