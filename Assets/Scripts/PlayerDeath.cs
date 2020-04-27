using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public int playerHealth;
    public int maxHealth = 20;
    public HealthBar healthBar;
    public float lives = 3;
    public Transform spawnPoint;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        transform.position = spawnPoint.position;
        gameObject.SetActive(true);

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
            lives = lives - 1;
            transform.position = spawnPoint.position;
            playerHealth = maxHealth;
        }

        if (lives == 0)
        {
            gameOver = true;
        }
    }
}
