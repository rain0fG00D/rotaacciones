using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiodecolor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
