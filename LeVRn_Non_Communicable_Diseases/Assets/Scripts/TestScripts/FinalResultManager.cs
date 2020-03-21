using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalResultManager
{
    public static int CalculateFinalScore(int totalScore)
    {
        //totalScore = ResultManager.newScore + QuizManager.score;
        return Mathf.CeilToInt(((float) totalScore / 34) * 100);
        //return Convert.ToInt32(((float) totalScore / 34) * 100);
    }
}
