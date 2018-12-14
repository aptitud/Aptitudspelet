using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HighscoreKeeper
{
    public static void RegisterScore(int score)
    {
        if (score > Highscore)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public static void ResetHighscore()
    {
        PlayerPrefs.SetInt("highscore", 0);
    }

    public static int Highscore
    {
        get { return PlayerPrefs.GetInt("highscore", 0); }
    }
}
