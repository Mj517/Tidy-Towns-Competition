using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyPathfinding : MonoBehaviour
{
    public Transform Player;
    public float speed = 2f;
    Path path;
    int currentWaypoint = 0;
    bool reachedEndofPath = false;
    Seeker seeker;
    Rigidbody2D rb;
    public float nextWaypointDistance = 3f;
    public float distanceFromPlayer;
    public float enemyH;
    public GameObject enemy;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, 0f);





    }

    void UpdatePath()
    {
        if (seeker.IsDone())
        seeker.StartPath(rb.position, Player.position, OnPathComplete);
    }
       

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
        
            return;
        

        if(currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndofPath = true;
            return;
        }else
        {
            reachedEndofPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;
        if (distanceFromPlayer <= 10)
        {
            UpdatePath();
            rb.AddForce(force);
            
        }




        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }

    
    }

    private void Update()
    {
        
        distanceFromPlayer = Vector2.Distance(rb.position, Player.position);
        enemyH = (enemy.GetComponent<EnemyDeath>().enemyHealth);

        if (enemyH == 0)
        {
            Destroy(gameObject);
        }







    }


}
        
    
        
    

