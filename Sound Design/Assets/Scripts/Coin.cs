using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject particles;
    private Rigidbody2D rb;
    public float speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.left * speed;

        if(rb.position.x < -13f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
