using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    private Rigidbody2D rbody;
    public GroundCheck groundCheck;

    
    void Start() // Use this for initialization
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    
    void Update() // Update is called once per frame
    {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y); //make able to move
        
        if(Input.GetKeyDown(KeyCode.Space)) // if press space
        {
            if (groundCheck.touches > 0) // if touches is more than 0
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight); // make able to jump
            }
        }
    }
}
