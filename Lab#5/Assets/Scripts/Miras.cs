using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miras : MonoBehaviour
{
    private Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = posicionInicial + new Vector3(Mathf.Sin(Time.time), 0, 0);
    }
}
