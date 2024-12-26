using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private TMP_Text healthText;

    private void Awake()
    {
        ChangeHealthText();
    }
    public void TakeDamage()
    {
        health--; // health = health -1;
        ChangeHealthText();

        if (health <= 0)
        {
            healthText.SetText("You are died");
            Time.timeScale = 0;
        }
    }
    private void ChangeHealthText()
    {
        healthText.SetText("Health : " + health);
    }
}