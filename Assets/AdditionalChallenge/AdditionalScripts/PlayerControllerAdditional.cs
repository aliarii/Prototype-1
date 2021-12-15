using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerAdditional : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public GameObject player;
    public GameObject playerTwo;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertical input

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            playerTwo.transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        }
        // Rotates the car based on horizontal input

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            playerTwo.transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
        }


        // Rotates the car based on horizontal input
        //transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
