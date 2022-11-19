using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal // Inheritance
{
    private Rigidbody dogRb;
    private const float jumpForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        dogRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk(); // Abstraction

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(dogRb, jumpForce); // Abstraction
        }
    }
}
