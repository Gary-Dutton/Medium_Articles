using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField]
    private int _powerUpID;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speed);

        if (transform.position.y < -5.75f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();

            if (player != null)
            {
                switch(_powerUpID)
                {
                    case 0:
                        player.TripleShotPowerUp();
                        break;
                    case 1:
                        player.SpeedBoostPowerUp();
                        break;
                    case 2:
                        //placeholder for shields
                        Debug.Log("This is a placeholder for the Shield Power Up");
                        break;
                    default:
                        //placeholder for testing and future eventbus
                        Debug.Log("This is a placeholder for capturing _powerUpID's that do not match!");
                        break;
                }
                
            }
            Destroy(this.gameObject);
        }

    }
}
