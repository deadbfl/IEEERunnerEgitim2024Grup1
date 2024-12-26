using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour
{
    public static FinishManager instance;
    
    [SerializeField] private GameObject finishPanel;
    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    public void FinishGame()
    {
        finishPanel.SetActive(true);
        scoreText.SetText("Score : " + ScoreManager.instance.GetScore());
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
