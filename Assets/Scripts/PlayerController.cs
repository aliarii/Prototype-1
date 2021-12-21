using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] float speed = 20.0f;
    [SerializeField] private float horsePower;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMasss;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMasss.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
