using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public Renderer rend;
    private Rigidbody rb;
    public float force = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo))
            rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
    }

    public void OnMouseOver()
    {
        rend.material.color = Color.magenta;
    }

    public void OnMouseExit()
    {
        rend.material.color = Color.green;
    }
}
