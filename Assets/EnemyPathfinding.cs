using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    float distance;
    public Transform Player;
    public float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(Player.transform.position, transform.position);


    }

    private void FixedUpdate()
    {
        if (distance <= 10)
        {
            transform.rotation = Player.transform.rotation;
            transform.position = (new Vector3(0, 2, 0) * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
