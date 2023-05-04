﻿namespace CMP1903M_OOP_AO2
{
    internal class Testing
    {
        public static Pack PACK = new Pack(); //initialises the main pack of cards
        public static Random RANDOM = new Random(); //generates a random number when required
        public static void Test()
        {
            string Choice = "";

            Start();
            while (Choice != "3")
            {
                DisplayMenu();
                Choice = Console.ReadLine();
                if (Choice == "1")
                { DisplayInstructions(); }
                else if (Choice == "2")
                { Deal3Cards(); }
                else if (Choice == "3")
                { Quit(); }
                else if (Choice == "4")
                { Deal5Cards(); }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input - Please Try Again!");
                }
            }
        }

        public static void Start()
        {
            Console.WriteLine("Welcome to MathsTutor!");
        }

        public static void Quit()
        {
            Console.WriteLine("Thanks For Using MathsTutor!");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Options: ");
            Console.WriteLine("1) Instructions");
            Console.WriteLine("2) Deal 3 Cards");
            Console.WriteLine("3) Quit");
            Console.WriteLine("4) Deal 5 Cards");

            Console.Write("Choice: ");
        }

        public static void DisplayInstructions()
        {
            Console.Clear();
            Console.WriteLine("Instructions: ");
            Console.WriteLine("-Select the 'Deal 3 Cards' Option From the Menu");
            Console.WriteLine("-A Mathematical Equation Will Be Displayed, Guess The Correct Answer");
            Console.WriteLine("-If Your Answer Is Correct You Will Be Told, Else You Will Be Corrected");
        }

        public static void Deal3Cards()
        {
            Console.Clear();
            Card Card1, Card2, Card3;
            PACK.fisherShatesShuffle();
            Card1 = PACK.deal();
            Card2 = PACK.deal();
            Card3 = PACK.deal();

            int Val1 = Card1.Value;
            int Operator1 = Card2.Suit;
            int Val2 = Card3.Value;
            int CorrectAns;

            if (Operator1 == 1) 
            { Console.WriteLine($"{Val1} + {Val2}");
                CorrectAns = Val1 + Val2;}
            else if (Operator1 == 2)
            {Console.WriteLine($"{Val1} - {Val2}");
                CorrectAns = Val1 - Val2;}
            else if (Operator1 == 3)
            {Console.WriteLine($"{Val1} * {Val2}");
                CorrectAns = Val1 * Val2;}
            else
            {Console.WriteLine($"{Val1} / {Val2}");
                CorrectAns = Val1 / Val2;}

            Console.Write("Answer: ");
            float.TryParse(Console.ReadLine(), out float Answer);
            if (Answer == CorrectAns)
            {Console.WriteLine("Correct!");}
            else
            { Console.WriteLine("Incorrect - The Correct Answer is " + CorrectAns + "!");}
        }

        public static void Deal5Cards()
        {
            Console.Clear();
            Card Card1, Card2, Card3, Card4, Card5;
            PACK.fisherShatesShuffle();
            Card1 = PACK.deal();
            Card2 = PACK.deal();
            Card3 = PACK.deal();
            Card4 = PACK.deal();
            Card5 = PACK.deal();

            int Val1 = Card1.Value;
            int Operator1 = Card2.Suit;
            int Val2 = Card3.Value;
            int Operator2 = Card4.Suit;
            int Val3 = Card5.Value;
            int CorrectAns;

            if (Operator1 == 1)
            {
                if (Operator2 == 1)
                {
                    Console.WriteLine($"{Val1} + {Val2} + {Val3}");
                    CorrectAns = Val1 + Val2 + Val3;
                }
                else if (Operator2 == 2)
                {
                    Console.WriteLine($"{Val1} + {Val2} - {Val3}");
                    CorrectAns = Val1 + Val2 - Val3;
                }
                else if (Operator2 == 3)
                {
                    Console.WriteLine($"{Val1} + {Val2} * {Val3}");
                    CorrectAns = Val1 + (Val2 * Val3);
                }
                else
                {
                    Console.WriteLine($"{Val1} + {Val2} / {Val3}");
                    CorrectAns = Val1 + (Val2 / Val3);
                }
            }
            else if (Operator1 == 2)
            {
                if (Operator2 == 1)
                {
                    Console.WriteLine($"{Val1} - {Val2} + {Val3}");
                    CorrectAns = Val1 - Val2 + Val3;
                }
                else if (Operator2 == 2)
                {
                    Console.WriteLine($"{Val1} - {Val2} - {Val3}");
                    CorrectAns = Val1 - Val2 - Val3;
                }
                else if (Operator2 == 3)
                {
                    Console.WriteLine($"{Val1} - {Val2} * {Val3}");
                    CorrectAns = Val1 - (Val2 * Val3);
                }
                else
                {
                    Console.WriteLine($"{Val1} - {Val2} / {Val3}");
                    CorrectAns = Val1 - (Val2 / Val3);
                }
            }
            else if (Operator1 == 3)
            {
                if (Operator2 == 1)
                {
                    Console.WriteLine($"{Val1} * {Val2} + {Val3}");
                    CorrectAns = (Val1 * Val2) + Val3;
                }
                else if (Operator2 == 2)
                {
                    Console.WriteLine($"{Val1} * {Val2} - {Val3}");
                    CorrectAns = (Val1 * Val2) - Val3;
                }
                else if (Operator2 == 3)
                {
                    Console.WriteLine($"{Val1} * {Val2} * {Val3}");
                    CorrectAns = Val1 * Val2 * Val3;
                }
                else
                {
                    Console.WriteLine($"{Val1} * {Val2} / {Val3}");
                    CorrectAns = Val1 * Val2 / Val3;
                }
            }
            else
            {
                if (Operator2 == 1)
                {
                    Console.WriteLine($"{Val1} / {Val2} + {Val3}");
                    CorrectAns = (Val1 / Val2) + Val3;
                }
                else if (Operator2 == 2)
                {
                    Console.WriteLine($"{Val1} / {Val2} - {Val3}");
                    CorrectAns = (Val1 / Val2) - Val3;
                }
                else if (Operator2 == 3)
                {
                    Console.WriteLine($"{Val1} / {Val2} * {Val3}");
                    CorrectAns = Val1 / Val2 * Val3;
                }
                else
                {
                    Console.WriteLine($"{Val1} / {Val2} / {Val3}");
                    CorrectAns = Val1 / Val2 / Val3;
                }
            }

            Console.Write("Answer: ");
            float.TryParse(Console.ReadLine(), out float Answer);
            if (Answer == CorrectAns)
            { Console.WriteLine("Correct!"); }
            else
            { Console.WriteLine("Incorrect - The Correct Answer is " + CorrectAns + "!"); }
        }
    }
}
