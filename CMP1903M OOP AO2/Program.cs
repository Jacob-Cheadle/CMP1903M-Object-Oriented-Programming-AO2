namespace CMP1903M_OOP_AO2
{
    class Program
    {
        public static Pack PACK = new Pack(); //initialises the main pack of cards
        public static Random RANDOM = new Random(); //generates a random number when required
        private static void Main()
        {
            Game GAME = new Game();
            Game.Play();
        }
    }
}