using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movetest : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    private Rigidbody objectRb;
    private float Zdestroy = 10.0f;
    private void Start()
    {

        objectRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Move the object down along the Z-axis

        objectRb.AddForce(Vector3.forward * speed);

        if (transform.position.z < -Zdestroy)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

}