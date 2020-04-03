
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public int damage = 1;
    public float speed;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}


/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public int damage = 1;
    //public float speed;

    float currentSpeed = 5f;
    float maxSpeed = 5000f;
    public float movementSpeed = 5.0f;
    //public GameObject obstacle;
    // New variables :
    public float accelerationTime = 60;    
    private float minSpeed ;
    private float time ;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject); 
        }
    }

    void Start()
    {
        minSpeed = currentSpeed; 
        time = 0 ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);

        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime );
        //transform.position -= transform.forward * currentSpeed * Time.deltaTime;
        time += Time.deltaTime ;
    }
}

*/





