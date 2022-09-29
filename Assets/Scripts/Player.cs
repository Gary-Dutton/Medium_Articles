using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // create a variable to store a default float value
    public float speed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        // what is my current position, reset it to a new position at start up
        transform.position = new Vector3 (0,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        // move player object left / right
        // move player object up / down

        float horitonalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horitonalInput * Time.deltaTime * speed); // Time.deltaTime normalises the computer, by using realtime
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed); // without T.dT the movement on different computer would be sporadic 

    }
}
