using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isLeft = true;
    private Rigidbody2D rbody;
    
    void Start() // Use this for initialization
    {
        rbody = GetComponent<Rigidbody2D>(); // makes it able to use Rigidbody2D
        Move(false); // gör så att move är false
    }

    
    void Update() // Update is called once per frame
    {   
        if (Input.GetKeyDown(KeyCode.H)) // if press H
        {
            Move(true);  // gör så att move blir true
        }
    }

    void Move(bool flip) // 
    {
        if (flip == true) // om flip är true
        {
            isLeft = !isLeft; // gör så att isleft blir till !isleft
        }

        if (isLeft == true) // om isleft är true 
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y); // visar vilket håll objectet åker
            transform.localScale = new Vector3(1, 1, 1); // visar vilket håll objectet tittar
        }
        else // om inte
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y); // visar vilket håll objectet åker
            transform.localScale = new Vector3(-1, 1, 1); // visar vilket håll objectet tittar
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // if object enter collider
    {
        if(collision.tag == "InvisibleWall") // if object has tag player
        {
            Move(true); // det gör så att move blir true
        }
    }
}
