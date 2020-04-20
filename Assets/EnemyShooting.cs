using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject Range;
    public GameObject enemyBulletPrefab;
    public float enemyBulletForce = 20f;
    public Transform enemyFirePoint;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Range.GetComponent<EnemyRange>().playerInThrowingRange == true)
        {
           EnemyShoot();
        }
    }

    void EnemyShoot()
    {
        GameObject enemyBullet = Instantiate(enemyBulletPrefab, enemyFirePoint.position, enemyFirePoint.rotation);
        Rigidbody2D rb = enemyBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(enemyFirePoint.up * enemyBulletForce, ForceMode2D.Impulse);
    }
}

