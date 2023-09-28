using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public healthbar healthbar;
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setmaxhealth(maxHealth);
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Takedamage (20);
        }
    }
    private void Takedamage(int damage)
    {
currentHealth -= damage;
        healthbar.setHealth(currentHealth);
    }
     
}
