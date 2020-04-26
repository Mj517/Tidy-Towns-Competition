using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public float eHealth;
    public Text scoreText;
    public GameObject Enemy;
    public float score;
    public bool willScore;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
        score = 0;
        eHealth = 5;
        willScore = false; 
    }


    public void IncreaseScore(int increment)
    {
        score += increment;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
