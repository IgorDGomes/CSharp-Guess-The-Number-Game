/* Thanks to Brakeys for the free lessons (https://www.youtube.com/@Brackeys) */

/* -------------------------------------- BASICS -------------------------------------- */


// // Change the appearence

// Console.Title = "Simple Game";
// Console.ForegroundColor = ConsoleColor.Green;
// Console.WindowHeight = 40;

// // Start of the conversation

// Console.WriteLine("What's your name?");

// string userName = Console.ReadLine();

// Console.WriteLine("Hi " + userName + ", my name is R2D2-52x46, nice to meet you.\nI'm an AI made to help you.");
// Console.WriteLine("What is your favorite color?");

// string favoriteColor = Console.ReadLine();

// Console.WriteLine(favoriteColor + "? That's a really nice color!");

// Console.ReadKey();



// // Variables


// double num01;
// double num02;
// double num03;

// Console.Write("Input the first number: ");
// num01 = Convert.ToDouble( Console.ReadLine() );

// Console.Write("Input the second number: ");
// num02 = Convert.ToDouble( Console.ReadLine() );

// Console.Write("Input the third number: ");
// num03 = Convert.ToDouble( Console.ReadLine() );

// double result = (num01 + num02 + num03) / 3;

// Console.WriteLine("The average is " + result);

// Console.ReadKey();



// // If Statement


// Console.WriteLine("Welcome to the Park.");

// int age;
// int height;

// Console.Write("Please input your age: ");
// age = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please input height (cm): ");
// height = Convert.ToInt32(Console.ReadLine());

// if (age >= 18 && height >= 160)
// {
//     Console.WriteLine("You can buy the Tickets!");

//     Console.WriteLine("Tickets are 5$. Please insert cash.");
//     int cash = Convert.ToInt32(Console.ReadLine());

//     if (cash < 5)
//     {
//         Console.WriteLine("That's not enough money.");
//     }
//     else if (cash == 5)
//     {
//         Console.WriteLine("Here is your ticket.");
//     }
//     else
//     {
//         int change = cash - 5;

//         Console.WriteLine("Here is your ticket and " + change + " dollars in change.");
//     }
// }
// else
// {
//     Console.WriteLine("You don't meet the requirements.");
// }

// // switch (num)
// // {
// //     case 1:
// //         Console.WriteLine("One");
// //         break;
// //     case 2:
// //         Console.WriteLine("One");
// //         break;
// //     case 3:
// //         Console.WriteLine("One");
// //         break;
// //     case 4:
// //         Console.WriteLine("One");
// //         break;
// //     case 5:
// //         Console.WriteLine("One");
// //         break;
// //     default:
// //         Console.WriteLine("Default");
// //         break;
// // }

// Console.ReadKey();



// // Loops


// Console.Write("How many numbers do you want?");

// int count = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= count; i++)
// {
//     double result = Math.Pow(2, i);
//     Console.WriteLine(result);
// }

// Console.WriteLine("While Loop: ");

// Random numberGen = new Random();

// int roll = 0;
// int attempts = 0;

// Console.WriteLine("Press enter to roll the dice.");

// while (roll != 6)
// {
//     Console.ReadKey();

//     roll = numberGen.Next(1, 7);
//     Console.WriteLine("You rolled: " + roll);
//     attempts++;
// }

// Console.WriteLine("It took you " + attempts + " attempts to roll a six.");

// Console.ReadKey();



// // Arrays


// string[] movies = {"Lord of the Rings", "Fight Club", "Interstellar", "Suicide Squad"};

// for (int i = 0; i < movies.Length; i++)
// {
//     int rank = i + 1;
//     Console.WriteLine(rank + ". " + movies[i]);
// }

// string[] userMovies = new string[4];

// Console.WriteLine("Write down 4 movies: ");

// for (int i = 0; i < userMovies.Length; i++)
// {
//     userMovies[i] = Console.ReadLine();
    
// }

// Array.Sort(userMovies);

// for (int i = 0; i < userMovies.Length; i++)
// {
//     Console.WriteLine(userMovies[i]);
// }

// // List

// using System.Collections.Generic;

// List<string> movieList = new List<string>();

// movieList.Add("Wonderland");
// movieList.Add("Shrek");
// movieList.Add("Karate kid");
// movieList.Add("Avatar");

// for (int i = 0; i < movieList.Count; i++)
// {
//     Console.WriteLine(movieList[i]);
// }

// movieList.Remove("Wonderland");
// movieList.RemoveAt(2);

// Console.WriteLine("----------------------");

// for (int i = 0; i < movieList.Count; i++)
// {
//     Console.WriteLine(movieList[i]);
// }

// Console.ReadKey();



// // Methods // Functions


// FakeMain();



// static void FakeMain(/* string[] args */)
// {
//     MeetAlien();

//     Console.WriteLine("---------------------");

//     MeetAlien();

//     Console.WriteLine("---------------------");
    
//     MeetAlien();

//     Console.WriteLine("---------------------");

//     int result = Multiply(3, 3);

//     Console.WriteLine("The result is: " + result);

//     if (result % 2 == 0)
//     {
//         Console.WriteLine(result + " is an even number!");
//     }
//     else
//     {
//         Console.WriteLine(result + " is an odd number!");
//     }

//     // Challenge

//     string example = "I Love Programming";

//     Console.WriteLine(example.Split(' ').Length);

//     Console.ReadKey();
// }

// static void MeetAlien()
// {
//     Random numberGen = new Random();

//     string name = "X-" + numberGen.Next(10, 9999);
//     int age = numberGen.Next(10, 500);

//     Console.WriteLine("Hi I'm " + name);
//     Console.WriteLine("I'm " + age + " years old.\nOh, and I'm an alien.");
// }

// static int Multiply(int num01, int num02)
// {
//     int result = num01 * num02;
//     return result;
// }



// // Classes


// class Cat
// {
//     public string name;
//     public int age;

//     public void Meow()
//     {
//         Console.WriteLine(name + " says meow");
//     }
// }

// class Wizard
// {
//     public string name;
//     public string favoriteSpell;
//     private int spellSlots;
//     private float experience;

//     public static int Count;

//     /*
//         int spellSlots;
//         float experience;
//     */

//     public Wizard(string _name, string _favoriteSpell)
//     {
//         name = _name;
//         favoriteSpell = _favoriteSpell;
//         spellSlots = 2;
//         experience = 0f;

//         Count++;
//     }

//     public void CastSpell()
//     {
//         if (spellSlots > 0)
//         {
//             Console.WriteLine(name + " casts " + favoriteSpell);
//             spellSlots--;
//             experience += 0.3f;
//         } else
//         {
//             Console.WriteLine(name + " is out of spell slots.");
//         }
//     }

//     public void Meditate()
//     {
//         Console.WriteLine(name + " meditates to regain spell slots");
//         spellSlots = 2;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Cat cat01 = new Cat();

//         cat01.name = "Cat Stevens";
//         cat01.age = 1;

//         cat01.Meow();

//         Cat cat02 = new Cat();

//         cat02.name = "Meowly Cyrus";
//         cat02.age = 6;

//         cat02.Meow();

//         Console.WriteLine("------------------------------");

//         Wizard wizard01 = new Wizard("Parry Hopper", "Unexpectro Patronum");

//         wizard01.CastSpell();

//         Wizard wizard02 = new Wizard("Glindalf Merlison", "Abracadabra");

//         wizard02.CastSpell();

//         Console.WriteLine(Wizard.Count);

//         Console.ReadKey();
//     }
// }

/* ------------------------------------------------------------------------------------------------------------------ */

Console.Write("Do you want to play? Type y or yes to start.");
string start = Console.ReadLine();

if (start.ToLower() == "y" || start.ToLower() == "yes")
{
    Play();
} else
{
    Console.WriteLine("Exiting the game.");
}

// Play Again

static void Play()
{
    do
    {
        Guess();
        Console.Write("Type 'yes' to play again or any other key to exit.");
    } while(Console.ReadLine().ToLower() == "yes");

    Console.WriteLine("Exiting the game.");
}

// Guess Game

static void Guess()
{
    Console.WriteLine("Guess the number between 1 and 1000 in 10 tries.");

    Random numberGen = new Random();
    int number = numberGen.Next(1, 1001);
    Console.WriteLine(number);

    for (int i = 1; i <= 10; i++)
    {
        int answer;

        if (!int.TryParse(Console.ReadLine(), out answer))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            i--;
            continue;
        } 

        if (answer > 1000)
        {
            Console.WriteLine("The value is higher than 1000, please put a lower number.");
            i--;
            continue;
        }

        if (answer != number)
        {
            if (answer < number)
            {
                Console.WriteLine("The number is Higher.");
            } else 
            {
                Console.WriteLine("The number is lower.");
            }
            Console.WriteLine("You have " + (10 - i) + " tries left. Try again.");
        } else
        {
            Console.WriteLine("Congratulations you guessed right!");
            return;
        }
    }
    Console.WriteLine("You lost...\nThe answer was " + number);
}