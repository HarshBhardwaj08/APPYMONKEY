using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MANGE_SCORE : MonoBehaviour
{
    public static MANGE_SCORE instance;
    public TextMeshProUGUI Myscore;
    private int score = 0;
     void Awake()
    {
        instance = this;
    }
     void Start()
    {
        Myscore.text =  "Score : " + score.ToString();
    }
    void Update()
    {
       
       
    }

    public void IncreaseScore(int points)
    {
        score += points;
        Myscore.text = "Score : " + score.ToString();
    }

   
}
