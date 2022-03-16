using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 2f;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3 (0.01F, 0.7F, 1.06F);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * velocidad * Time.deltaTime;
    } 
}

