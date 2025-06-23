using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    public Logic_Script logic;
    public Rigidbody2D MyBird;
    public float FlapStrength;




    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            MyBird.velocity = Vector2.up * FlapStrength;
        }
    
}

private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GOS();
    }

}
