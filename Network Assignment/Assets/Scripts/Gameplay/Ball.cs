using UnityEngine;

public class Ball : MonoBehaviour
{
    public Transform ball;

    Rigidbody rb;
    
    // public Transform Spawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision collision)
    {
        
        if (collision.gameObject.tag == "Wall")
        {
            print("touching wall");

            rb.AddForce(Vector3.back * 50);
       
        }

        if (collision.gameObject.tag == "Wall 2")
        {
            print("touching wall");

            rb.AddForce(Vector3.forward * 50);

        }

        if (collision.gameObject.tag == "Wall 3")
        {
            print("touching wall");

            rb.AddForce(Vector3.left * 50);

        }

        if (collision.gameObject.tag == "Wall 4")
        {
            print("touching wall");

            rb.AddForce(Vector3.right * 50);

        }

    }
    private void OnCollisionEnter(Collision collision)
    {     
        
        if (collision.gameObject.tag == "Goal")
        {

        transform.position = new Vector3(2.34f, 3.5f, -10f);

       // Destroy(gameObject);

       // Vector3 SpawnPoint = new Vector3(2.34f, 5f, -10.38f);

       // Instantiate(ball, SpawnPoint, Quaternion.identity);


        }
        
    }
}
