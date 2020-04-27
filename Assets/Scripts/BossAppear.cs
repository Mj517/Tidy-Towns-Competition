using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAppear : MonoBehaviour
{
    public float scoreTreshold = 50f;
    public float pScore;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pScore = Player.GetComponent<Scoring>().score;

        if (pScore >= scoreTreshold)
        {
            gameObject.SetActive(true);
        }
    }
}
