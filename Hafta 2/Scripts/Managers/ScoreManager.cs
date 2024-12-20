using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    
    [SerializeField] private float increaseRate;
    
    private float score;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        score += Time.deltaTime * increaseRate;
        print(score);
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
    }
}
