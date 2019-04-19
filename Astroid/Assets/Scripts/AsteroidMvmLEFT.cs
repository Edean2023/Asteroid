using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMvmLEFT : MonoBehaviour
{

    float Speed = 3f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate( - Speed * Time.deltaTime, 0, 0);
    }
}