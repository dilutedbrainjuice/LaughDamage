using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float slowedSpeed;
    public GameObject player;
    public bool canMove = true;
    public float stunTime = 0f;

    public float step;

    public bool slowed = false;
    public float slowTime = 0f;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (slowed)
        {
            if (slowTime > 0f)
            {
                slowTime -= Time.deltaTime;
            }

            if (slowTime <= 0)
            {
                slowed = false;

            }
        }

        if (canMove)
        {
            step = speed * Time.deltaTime;
            if (slowed)
            {
                step = slowedSpeed * Time.deltaTime;
            }

            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }

        else if (!canMove)
        {
            if (stunTime > 0f)
            {
                stunTime -= Time.deltaTime;
            }

            if (stunTime <= 0)
            {
                canMove = true;

            }
        }




        
    }

    
}
