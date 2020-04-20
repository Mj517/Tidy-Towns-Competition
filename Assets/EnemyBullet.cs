using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public GameObject enemyHitEffect;

    private void OnCollisionEnter2D(Collision2D collision)

    {
        GameObject effect = Instantiate(enemyHitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.1f);
        Destroy(gameObject);

    }






}
