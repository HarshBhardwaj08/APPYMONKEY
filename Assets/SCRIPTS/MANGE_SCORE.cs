using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MANGE_SCORE : MonoBehaviour
{
    public TextMeshProUGUI Myscore;
    private int score = 0;

    public void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreText();
        Debug.Log(score);
    }

    void UpdateScoreText()
    {
        Myscore.text = "Score: " + score;
    }
}
