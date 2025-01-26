using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float mSpeed;
    public float speedX, speedY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * mSpeed;
        speedY = Input.GetAxisRaw("Vertical") * mSpeed;
        rb.velocity = new Vector2(speedX,speedY);
    }
}
