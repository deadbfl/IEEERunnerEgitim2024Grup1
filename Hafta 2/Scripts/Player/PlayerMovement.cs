using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool smoothIncrease;
    public float speed;
    public float horizontalSpeed;
    public float minX;
    public float maxX;
    public float increaseTime;
    private float timer = 0;
    private float horizontal;
    void Update()
    {
        if (smoothIncrease)
        {
            speed += Time.deltaTime / increaseTime;
        }
        else
        {
            timer += Time.deltaTime;
            if (timer >= increaseTime)
            {
                speed += 1;
                timer = 0;
            }
        }

        


        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        horizontal = Input.GetAxis("Horizontal");
        //print(horizontal);

        if(horizontal != 0)
        {
            transform.Translate(Vector3.right * horizontal * horizontalSpeed * Time.deltaTime);

            Vector3 playerPosition = transform.position;

            playerPosition.x = Mathf.Clamp(playerPosition.x, minX, maxX);

            transform.position = playerPosition;
        }

        

    }
}
