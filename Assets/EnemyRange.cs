using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    public bool playerInThrowingRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInThrowingRange = true;
        } else
        {
            playerInThrowingRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
