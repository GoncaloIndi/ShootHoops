using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopTrigger : MonoBehaviour
{
    //Triggering the score
    private ScoreCounter score;
    private void Awake()
    {
        score = FindObjectOfType<ScoreCounter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            score.AddScore();
        }
    }
}
