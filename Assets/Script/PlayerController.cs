using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10.0f;
    private Rigidbody playerRb;
    private float Zbound = 7;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * horizontalInput * Speed);
        playerRb.AddForce(Vector3.forward * VerticalInput * Speed);

        if (transform.position.z < -Zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -Zbound);
        }
        else if  (transform.position.z > Zbound)
         {
            transform.position = new Vector3(transform.position.x, transform.position.y, Zbound);
        }

    }
}
