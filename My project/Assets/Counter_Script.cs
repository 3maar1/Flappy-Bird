using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter_Script : MonoBehaviour
{
    public Logic_Script logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.ScoreCount(1);
        }
    }
}
