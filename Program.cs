using System;

namespace Tech_Project_4___Team_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool Repeat = true;
            while (Repeat)
            {
                Console.WriteLine("Please enter the number of hands and the first letter of the suit of the drawn card to determine the dominant suit! For example 4S for  four of Spades");
                try
                {
                    string input = Console.ReadLine().ToLower();
                    if (String.Equals("q", input.ToLower()))
                    {
                        System.Environment.Exit(0);
                    }
                    int Hands = Int32.Parse(input.Substring(0, input.Length - 1));
                    char Suit = input[input.Length - 1];
                    
                    if (Suit.Equals('s') || Suit.Equals('c') || Suit.Equals('h') || Suit.Equals('d'))
                    {
                        int Score = 0;
                        for (int I = 0; I<4*Hands; I++)
                        {
                            Console.WriteLine("Enter the card suit combo of your hand");
                            input = Console.ReadLine().ToLower();

                            if (input[1].Equals(Suit)) //Dominant
                            {
                                if (input[0].Equals('a'))
                                {
                                    Score += 11;
                                }
                                else if (input[0].Equals('k'))
                                {
                                    Score += 4;
                                }
                                else if (input[0].Equals('q'))
                                {
                                    Score += 3;
                                }
                                else if (input[0].Equals('j'))
                                {
                                    Score += 20;
                                }
                                else if (input[0].Equals('t'))
                                {
                                    Score += 10;
                                }
                                else if (input[0].Equals('9'))
                                {
                                    Score += 14;
                                }
                                else if (input[0].Equals('8'))
                                {
                                    Score += 0;
                                }
                                else if (input[0].Equals('7'))
                                {
                                    Score += 0;
                                }
                                else
                                {
                                    I--;
                                    Console.WriteLine("Invalid Card Please Try Again");
                                }
                            }
                            else
                            { //Not Dominant
                                if (input[0].Equals('a'))
                                {
                                    Score += 11;
                                }
                                else if (input[0].Equals('k'))
                                {
                                    Score += 4;
                                }
                                else if (input[0].Equals('q'))
                                {
                                    Score += 3;
                                }
                                else if (input[0].Equals('j'))
                                {
                                    Score += 2;
                                }
                                else if (input[0].Equals('t'))
                                {
                                    Score += 10;
                                }
                                else if (input[0].Equals('9'))
                                {
                                    Score += 0;
                                }
                                else if (input[0].Equals('8'))
                                {
                                    Score += 0;
                                }
                                else if (input[0].Equals('7'))
                                {
                                    Score += 0;
                                }
                                else
                                {
                                    I--;
                                    Console.WriteLine("Invalid Card Please Try Again");
                                }
                            }
                            
                        }
                        Console.WriteLine(Score);
                        
                    }

                }
                catch
                {
                    Console.WriteLine("Enter a valid number letter combo please!");
                }


            }
            
            
        }
    }
}
