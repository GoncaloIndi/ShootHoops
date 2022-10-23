using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int score;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private HoopUpdater hoop;
    public string EndGameScore;



    public void AddScore()
    {
        score += 2;
        
        EndGameScore = "Score: " + score;
        text.text = EndGameScore;
        hoop.UpdateHoopAnimation(score);
    }

}
