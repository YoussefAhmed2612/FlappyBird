using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using Unity.Mathematics;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 5; 
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
         timer += Time.deltaTime;  
        }else 
        {
           spawn();
           timer = 0;
        }
    }
    void spawn()
    {   float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe,new Vector3(transform.position.x,UnityEngine.Random.Range(lowestPoint,highestPoint),0),transform.rotation);
    }
}

