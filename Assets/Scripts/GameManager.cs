using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int currentScore = 0;
    [SerializeField]GameObject startPnl, losePnl;
    [SerializeField]TextMeshProUGUI scoreText,highScoreText;
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Lose()
    {
        
    }
    public void IncreaseScore()
    {
        currentScore++;
    }
    void StartGame()
    {

    }
}
