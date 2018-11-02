namespace OMP.Model
{
    public class PlayerScore
    {
        public int Score;
        public Team PTeam;
        public bool Pass;

        public PlayerScore(int score, Team team, bool pass)
        {
            this.Score = score;
            this.PTeam = team;
            this.Pass = pass;
        }
    }
}
