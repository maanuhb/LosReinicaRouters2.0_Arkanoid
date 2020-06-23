
namespace Arkanoid
{
    public class Player
    {
        public string Nickname { get; set; }
        public int Score { get; set; }
        public int idPlayer { get; set; }
        public Player(string nickname, int score)
        {
            Nickname = nickname;
            Score = score;
        }
    }
}