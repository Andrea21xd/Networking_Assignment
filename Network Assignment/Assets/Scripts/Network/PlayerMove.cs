using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private float speed = 0.01f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed;
        }

    }
}
