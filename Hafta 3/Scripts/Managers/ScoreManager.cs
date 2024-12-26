using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float increaseRate;
    
    private float score;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        score += Time.deltaTime * increaseRate;
        ChangeScoreText();
    }
    public void DecreaseScore(int amount)
    {
        score -= amount;
        ChangeScoreText();
    }
    private void ChangeScoreText()
    {
        scoreText.SetText("Score : " + (int)score);
    }

    // Buradaki int geri donus tipidir
    public int GetScore()
    {
       return (int)score; 
    }
}
