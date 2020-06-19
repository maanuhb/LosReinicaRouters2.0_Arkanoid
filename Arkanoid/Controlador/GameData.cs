namespace Arkanoid
{
    public static class GameData
    {
        public static bool gamestarted = false;
        public static double AmaountTicks;
        public static int dirX = 12, dirY = -dirX, score;
        
        // Inicializacion de variables
        public static void InitializeGame()
        {
            gamestarted = false;
            AmaountTicks = 0;
            score = 0;
        }
    }
}