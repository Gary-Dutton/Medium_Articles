using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;

    //need to merge player object with projectile
    //need to control rate of fire
    //need to control time between key presses
    [SerializeField]
    private GameObject _laserShot;
    [SerializeField]
    private float _fireRate = 0.3f;

    private float _nextFire = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (0,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();

        //get key input, space
        //is the time now greater than _nextFire
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
        {
            laserShot();
        }
        
    }

    void playerMovement()
    {
        float horitonalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horitonalInput * Time.deltaTime * _speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * _speed);

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0,0);
        } else if (transform.position.y <= -3.8)
        {
            transform.position = new Vector3(transform.position.x, -3.8f,0);
        }

        if (transform.position.x >= 11.3)
        {
            transform.position = new Vector3(-11.3f,transform.position.y,0);
        } else if (transform.position.x <= -11.3)
        {
            transform.position = new Vector3(11.3f, transform.position.y,0);
        }
    }

    void laserShot()
    {
        //take the current time, add the rate of fire, give it a new variable
        //spawn laser object from the player object start position y=0.6f
        _nextFire = Time.time + _fireRate;
        Instantiate(_laserShot, transform.position + new Vector3(0,0.6f,0), Quaternion.identity);
    }
}
