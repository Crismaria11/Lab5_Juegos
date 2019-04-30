using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseOver()
    {
        rend.material.color = Color.yellow;
    }

    public void OnMouseExit()
    {
        rend.material.color = Color.blue;
    }
}
