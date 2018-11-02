using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OMP.Model
{
    public class MatchMap
    {


        public List<PlayerScore> scores;
        public string mapID;
        public string mapName;
        public string mapLink;
        public string setID;
        public int BlueScore;
        public int RedScore;
        public Mod Mod;
        

        public MatchMap(string mapID, string setID, string mapName, Mod mod)
        {
            this.mapID = mapID;
            this.setID = setID;
            this.BlueScore = 0;
            this.RedScore = 0;
            this.mapName = mapName;
            scores = new List<PlayerScore>();
            this.mapLink = "http://osu.ppy.sh/b/" + mapID;
            this.Mod = mod;
        }

        public void AddScore(PlayerScore score)
        {
            scores.Add(score);
        }

        public void ComputeTeamScores()
        {
            foreach (PlayerScore score in scores)
            {
                if (score.Pass == true)
                {
                    if (score.PTeam == Team.Blue)
                    {
                        BlueScore += score.Score;
                    }
                    else
                    {
                        RedScore += score.Score;
                    }
                }
            }
        }

        
    }
}
