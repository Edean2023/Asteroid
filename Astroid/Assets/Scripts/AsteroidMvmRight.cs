using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMvmRight : MonoBehaviour
{

    public float maxSpeed = 5f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(maxSpeed * Time.deltaTime, 0, 0);
    }
}