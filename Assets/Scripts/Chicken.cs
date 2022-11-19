using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    private Rigidbody chickenRb;
    private const float jumpForce = 2;

    // Start is called before the first frame update
    void Start()
    {
        chickenRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(chickenRb, jumpForce);
        }
    }

    protected override void Jump(Rigidbody animalRb, float jumpForce)
    {
        base.Jump(animalRb, jumpForce);
        transform.Rotate(Vector3.up * 90);
    }
}
