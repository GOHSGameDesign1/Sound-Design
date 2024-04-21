using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpSpeed;
    private bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            canJump = false;
            rb.velocity = Vector2.up * jumpSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}
