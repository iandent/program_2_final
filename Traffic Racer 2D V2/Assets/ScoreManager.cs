using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

	public int score;
	public Text ScoreDisplay;
    //public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        
    	if (other.CompareTag("Obstacle")) {
    		score++;
    		Debug.Log(score);

            }
    	
    }
}

