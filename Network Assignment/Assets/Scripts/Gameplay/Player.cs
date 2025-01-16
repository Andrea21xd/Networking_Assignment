using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float movespeed;

    Rigidbody rb;

    float xInput;
    float zInput;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void FixedUpdate()
    {
        float xVelocity = xInput * movespeed;
        float zVelocity = zInput * movespeed;

         rb.linearVelocity = new Vector3(xVelocity, rb.linearVelocity.y, zVelocity);
    }
}
