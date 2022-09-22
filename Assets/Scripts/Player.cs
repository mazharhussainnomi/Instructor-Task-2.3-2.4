using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //we will use fixed update as it used for running in fixed timer
    public float horizontalInput;
    public float speed = 15f;
    public float xRange = 15;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);

        //if(transform.position.x < -xRange)
       // {
          //  transform.position = new Vector2(-xRange, transform.position.y);
        //}
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game Over");
        FindObjectOfType<Player>().EndGame();
    }
    public void EndGame()
    {
        Debug.Log("Ending YourGame");
    }
}
