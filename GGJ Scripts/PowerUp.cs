using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    
    public PowerUpEffect powerUpEffect;

    void Start(){
      
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player")
        { 
            
            Destroy(gameObject);
            powerUpEffect.Apply(collision.gameObject);
            Debug.Log("PowerUP!");
        }
        
    }
}
