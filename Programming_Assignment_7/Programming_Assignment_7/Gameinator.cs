//****************************************************************************
//****************************************************************************
//
// Daniel LaBon
// CSCI 1301C
// Programming Assignment 7
// 4/9/2018
//
// File: Gameinator.cs
//
//***************************************************************************
//***************************************************************************

using System;

namespace Programming_Assignment_7
{
    class Gameinator
    {
        static void Main(string[] args)
        {
            //Initialize or declare all variables needed
            Random Random = new Random();
            int gameNumber = Random.Next(1, 26);
            int counter;
            int number;
            string tries = "";

            //Tell user what code does
            Console.WriteLine("Welcome to Gameinator!");
            Console.WriteLine("");

            Console.WriteLine("Would you like to play a game?");
            Console.WriteLine("I have a number in mind between 1 and 25.");
            Console.WriteLine("");

            Console.WriteLine("Can you guess my number in 5 (or fewer) tries?");
            Console.WriteLine("");

            //Create a loop that loops 5 times
            for (counter = 1; counter <= 5; counter++)
            {
                //Request input from user to guess number
                Console.Write("What is your guess? ");
                number = int.Parse(Console.ReadLine());

                //While the user has not used all of their 5 tries tell them if their guess is too high or too low 
                if (counter < 5)
                {
                    if (number < gameNumber)
                    {
                        Console.WriteLine("Too low. Try again...");
                        Console.WriteLine("");
                    }
                    if (number > gameNumber)
                    {
                        Console.WriteLine("Too high. Try again...");
                        Console.WriteLine("");
                    }
                }
                
                //If the user guesses the number, find out how many tries it took them and congradulate them
                if (number == gameNumber)
                {
                    if (counter == 1)
                    {
                        tries = "first";
                    } else if (counter == 2)
                        {
                            tries = "second";
                        } else if (counter == 3)
                            {
                                tries = "third";
                            }else if (counter == 4)
                                {
                                    tries = "forth";
                                }else if (counter == 5)
                                    {
                                        tries = "fifth";
                                    }

                    Console.WriteLine("Winner!");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you did it!");
                    Console.WriteLine($"You guessed my number on your {tries} try.");
                    Console.WriteLine("");
                    break;
                }
                //If the user does not guess the correct number within 5 tries then tell them the number they needed to guess and end code
                if (counter == 5)
                {
                    Console.WriteLine("Unfortunately, you didn't guess my number.");
                    Console.WriteLine("");
                    Console.WriteLine($"BTW, my number was {gameNumber}");
                    Console.WriteLine("Try again later when you're feeling lucky...");
                    Console.WriteLine("");
                }
            }
        }
    }
}
