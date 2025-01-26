using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/ElectricPower")]
public class ElectricPower : PowerUpEffect
{
    public float speedAmount;
    public float jumpPowerHeight;
    public override void Apply(GameObject Player)
    {
        Player.GetComponent<BubbleMovement>().mSpeed += speedAmount;
        Player.GetComponent<BubbleMovement>().jumpPower += jumpPowerHeight;
        Player.GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
