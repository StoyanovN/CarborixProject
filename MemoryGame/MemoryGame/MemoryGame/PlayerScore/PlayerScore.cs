using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MemoryGame.PlayerScore
{
    
    public class PlayerScore
    {
        private int points;
        private List<PlayerScore> scores = new List<PlayerScore>();

        public PlayerScore()
        {
        }

        public PlayerScore(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; }
        public int Points {
            get { return this.points; } 
            private set
            {
                if (value < 0)
                {
                    this.points = 0;
                }
                else
                {
                    this.points = value;
                }
            }
        }

        public void ReadScore()
        {
            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int index = directory.LastIndexOf("\\");
            string path = directory.Substring(0, index);
            index = path.LastIndexOf("\\");
            path = path.Substring(0, index);
            path = path + @"\data.dat";

            string[] info = File.ReadAllLines(path);
            AddPlayerScores(info);
            ArrangeScores();
            WriteOnFile(path);
        }

        private void AddPlayerScores(string[] playerInfo)
        {
            string pattern = @"\s(.+?)\s([0-9]+)";
            foreach (var player in playerInfo)
            {
                Match m = Regex.Match(player, pattern);

                PlayerScore plScore = new PlayerScore(m.Groups[1].Value, int.Parse(m.Groups[2].Value));
                this.scores.Add(plScore);
            }
        }

        private void ArrangeScores()
        {
           this.scores = this.scores.OrderByDescending(p => p.Points).Take(10).ToList();
        }


        public string GiveScores()
        {
            StringBuilder str = new StringBuilder();
            int counter = 0;
            foreach (var score in scores)
            {
                counter++;
                str.AppendLine($"{counter}. {score.Name} {score.Points}");
            }
            return str.ToString();
        }

        public void ReceivePlayer(PlayerScore player)
        {
            this.scores.Add(player);
            ReadScore();
        }

        private void WriteOnFile(string path)
        {
            string forWriting = GiveScores();
            File.WriteAllText(path, forWriting);
        }
    }
}
