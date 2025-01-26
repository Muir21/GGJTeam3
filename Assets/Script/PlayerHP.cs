using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public Rigidbody2D player;
    public float currentHP;
    public float maxHP = 3;
    public Transform playerMiniSpawn;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int amount){
        currentHP -= amount;
        if(currentHP <= 0){
            Debug.Log("Taken damage");
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Enemy")
        {
            Instantiate(player, playerMiniSpawn.position, playerMiniSpawn.rotation);
            Debug.Log("Collided");
        }
        
    }
}
