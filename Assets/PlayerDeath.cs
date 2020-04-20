using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public int playerHealth;
    public int maxHealth = 20;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerHealth = playerHealth - 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(playerHealth);

        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
