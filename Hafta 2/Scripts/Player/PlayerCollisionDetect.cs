using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetect : MonoBehaviour
{
    private PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            print("Take damage");
            ScoreManager.instance.DecreaseScore(15);
            playerHealth.TakeDamage();
            Destroy(other.transform.parent.parent.gameObject);
        }
    }
}