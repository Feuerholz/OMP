namespace OMP.Model
{
    public class PlayerScore
    {
        public string PlayerID;
        public int Score;
        public Team PTeam;
        public bool Pass;

        public PlayerScore(string playerID, int score, Team team, bool pass)
        {
            this.PlayerID = playerID;
            this.Score = score;
            this.PTeam = team;
            this.Pass = pass;
        }
    }
}
