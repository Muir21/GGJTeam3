using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Powerups/MagePower")]
public class MagePower : PowerUpEffect
{
    public Rigidbody2D rb;
    private bool doubleJump;
    public override void Apply(GameObject Player)
    {

        if (Player.GetComponent<BubbleMovement>().IsGrounded() && !Input.GetButton("Jump"))
        {
            
            doubleJump = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("jump");
            if(Player.GetComponent<BubbleMovement>().IsGrounded() || doubleJump)
            {
                rb.velocity = new Vector2(rb.velocity.x, Player.GetComponent<BubbleMovement>().jumpPower);
                doubleJump = !doubleJump;
            }
        }
      
        Player.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
