using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   [SerializeField] private int health;

   public void TakeDamage()
   {
      health--; // health = health -1;

      if (health <= 0)
      {
         print("Yandin");
      }
   }
}
