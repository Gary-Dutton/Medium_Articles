using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //private, serialised, variable set to 8.0f
    [SerializeField]
    private float _speed = 8.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fire projectile forwards, at the rate of 8m/ps
        //destroy projectile after it's y position >= 8

        transform.Translate(Vector3.up * Time.deltaTime * _speed);
        
        if (transform.position.y >=8)
        {
            Destroy(this.gameObject);
        }
    }
}
