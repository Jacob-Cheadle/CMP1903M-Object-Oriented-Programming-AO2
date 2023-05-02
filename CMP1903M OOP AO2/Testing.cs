namespace CMP1903M_OOP_AO2
{
    internal class Testing
    {
        public static void Test()
        {
            string Choice = "";

            Start();
            while ((Choice != "1") & (Choice != "2") & (Choice != "3"))
            {
                DisplayMenu();
                Choice = Console.ReadLine();
                if (Choice == "1")
                { }
                else if (Choice == "2")
                { }
                else if (Choice == "3")
                { }
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

            Console.Write("Choice: ");
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("Instructions: ");
            Console.WriteLine("-Select the 'Deal 3 Cards' Option From the Menu");
            Console.WriteLine("-A Mathematical Equation Will Be Displayed, Guess The Correct Answer");
            Console.WriteLine("-If Your Answer Is Correct You Will Be Told, Else You Will Be Corrected");
        }

    }
}
