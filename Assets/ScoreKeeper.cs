using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreKeeper
{
    private static int score = 0;

    public static void IncrementScore()
    {
        score++;
    }

    public static void End()
    {
        HighscoreKeeper.RegisterScore(score);
        score = 0;
    }

    public static int Score
    {
        get { return score; }
    }
}
