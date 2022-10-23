using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private int timeLeft = 30;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject score;
    [SerializeField] private Animator darkAnim;
    [SerializeField] private ScoreCounter scoreScript;
    [SerializeField] private TextMeshProUGUI endGameScore;
    private static readonly int Dark = Animator.StringToHash("Dark");

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Start()
    {
        StartCoroutine(DecreaseTimer());
    }

    private IEnumerator DecreaseTimer()
    {
        while (timeLeft > 0) //Change to time <= 0
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            text.text = "Time: " + timeLeft;
        }
        darkAnim.SetTrigger(Dark);
        endGameScore.text = scoreScript.EndGameScore;
        score.SetActive(false);
        text.enabled = false;
        yield return new WaitForSeconds(1);
        gameOverScreen.SetActive(true);
        
        Time.timeScale = 0;
    }
}
