using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    private Vector3 spawnPos;

    private float xRange = 4.6f;
    private float zRange = 4.6f;
    private float yPos = 0;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject animalPrefab in animalPrefabs)
        {
            spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, Random.Range(-zRange, zRange));

            Instantiate(animalPrefab, spawnPos, transform.rotation);
        }
    }

    protected void Walk() // Abstraction
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    protected virtual void Jump(Rigidbody animalRb, float jumpForce) // Abstraction // Polymorphism
    {
        animalRb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }
}
