using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] spawnBlock;
    //public int blockIndex;

    private void Start()
    {
       InvokeRepeating("spawnRandomBlocks", 2,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
      //if(Input.GetKeyDown(KeyCode.S))
       //{
        //  spawnRandomBlocks();
       // }
       
    }
    void spawnRandomBlocks()
    {
        int blockIndex = Random.Range(0, spawnBlock.Length);
        Vector2 spawnPos = new Vector2(Random.Range(-5, 5), 10);
        Instantiate(spawnBlock[blockIndex], spawnPos, Quaternion.identity); //we are not rotating our object

        if (transform.position.y < -1)
        {
            Destroy(gameObject);
            Debug.Log("Collision Detected");
            // Destroy(gameObject.this);
        }
    }
}
