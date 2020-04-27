using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public GameObject Player;
   
    public GameObject gameOverObject;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOverObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<PlayerDeath>().lives == 0)
        {
            gameOverObject.SetActive(true);
            Player.SetActive(false);
        }
    }

   

   
}

