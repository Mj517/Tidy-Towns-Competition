using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth;
    public int enemyMaxHealth = 5;
    public HealthBar enemyHealthBar;
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = enemyMaxHealth;
        enemyHealthBar.SetMaxHealth(enemyMaxHealth);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            enemyHealth = enemyHealth - 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        enemyHealthBar.SetHealth(enemyHealth);

      if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
