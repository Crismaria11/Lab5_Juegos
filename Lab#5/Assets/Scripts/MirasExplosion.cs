using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MirasExplosion : MonoBehaviour
{
    public AudioClip sonidoGrito;
    public AudioClip sonidoEsperanza;
    AudioSource fuenteAudio2;

    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("Maul"))
                {
                    fuenteAudio2.clip = sonidoGrito;
                    fuenteAudio2.Play();
                }
                if (hitInfo.collider.gameObject.CompareTag("Qui"))
                {
                    fuenteAudio2.clip = sonidoEsperanza;
                    fuenteAudio2.Play();
                }
            }
    }
}