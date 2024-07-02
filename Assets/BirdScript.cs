using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody ; 
    public float flapStrength;
    public LogicMangerScript logic;

    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
         logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicMangerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity =  Vector2.up * flapStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
