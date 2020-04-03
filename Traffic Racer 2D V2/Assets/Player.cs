using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
public class Player : MonoBehaviour
{

    private Vector2 initialPos;
	private Vector2 targetPos;
	public float Yincrement;
	public float speed;
	public float maxHeight;
	public float minHeight;
    public int health = 1;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = transform.position.Set(-5.5,0,1);
        transform.position = new Vector2(-5.5f, 0f); // STOPPED WORKING
    }


    // Update is called once per frame
    void Update()
    {
        if (health <= 0) {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }


    	transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
        	targetPos = new Vector2(-5.5f, transform.position.y + Yincrement);
        	
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
        	targetPos = new Vector2(-5.5f, transform.position.y - Yincrement);
        	
        } 
    }

    // transform.position.x
    //
}
*/


public class Player : MonoBehaviour
{

    private Vector2 initialPos;
    private Vector2 targetPos = new Vector2(-5.5f, 0f);
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 1;
    public GameObject gameOver;
    // Start is called before the first frame update
    public void Start()
    {
        initialPos = new Vector2(-5.5f, 0f);
        transform.position = Vector2.MoveTowards(transform.position, initialPos, speed * Time.deltaTime);
        //initialPos = new Vector2(-5.5f, 0f); // STOPPED WORKING
    }


    // Update is called once per frame
    public void Update()
    {
        if (health <= 0) {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            targetPos = new Vector2(-5.5f, transform.position.y + Yincrement);   
            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            targetPos = new Vector2(-5.5f, transform.position.y - Yincrement);
            
        } 
    }

    // transform.position.x
    //
}
