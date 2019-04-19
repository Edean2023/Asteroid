using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMvmDWN : MonoBehaviour
{

     float Speed = 3f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, - Speed * Time.deltaTime, 0);
    }
}