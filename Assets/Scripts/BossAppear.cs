using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAppear : MonoBehaviour
{
    public float scoreTreshold = 50f;
    public float pScore;
    public GameObject Player;
    public GameObject Boss;
    
    // Start is called before the first frame update
    void Start()
    {
        Boss.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pScore = Player.GetComponent<Scoring>().score;

        if (pScore >= scoreTreshold)
        {
            Boss.SetActive(true);
        }
    }
}
