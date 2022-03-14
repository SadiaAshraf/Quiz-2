using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float verticalInput;
    public float horizontalInput;
    public float playerRotation = 60;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * playerSpeed * Time.deltaTime);
        horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.left * horizontalInput * playerRotation * Time.deltaTime);
    }
}
