﻿namespace WeekTenChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = [4, 5, 6, 5];
            int[] ages = [2, 1, 2, 1];

            Console.WriteLine(HighScore(scores, ages));
            Console.ReadKey();

        }

        static int HighScore(int[] scores, int[] ages)
        {
            List<(int scores, int dp)> players = new();

            for (int i = 0; i < scores.Length; i++)
            {
                players.Add((scores[i], ages[i]));
            }

            players = players.OrderBy(player => player.dp)
                .ThenBy(player => player.scores)
                .Select(player => (player.scores, player.scores))
                .ToList<(int scores, int dp)>();

            for (int i = 0; i < players.Count; i++)
            {
                foreach ((int score, int dp) player in players[..i])
                {
                    if (player.score <= players[i].scores)
                    {
                        players[i] = (players[i].scores, Math.Max(player.dp + players[i].scores, players[i].dp));
                    }
                }
            }
            return players.Max(x => x.dp);
        }
    }
}
