using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    //pretty much done, may add inviciblity to the power up on here.
    public Rigidbody2D shield;
    public float currentHP {get; private set;}
    public float maxHP = 3;
    public Transform shieldSpawn;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int amount){
        currentHP -= Mathf.Clamp(currentHP - amount, 0 , maxHP);
        if (currentHP > 0)
        {
            //Animation
        }
        else{
            //Animation
            Debug.Log("Dead");
        }
    }

    //create a empty gameobject for shield and place inside bubble(if it looks good)
    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Enemy")
        {
            TakeDamage(1);
            Instantiate(shield, shieldSpawn.position, shieldSpawn.rotation);
            Debug.Log("Damaged");
        }
        
    }
}
