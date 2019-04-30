using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personita : MonoBehaviour
{
    public int puntuacion = 0;
    public Text TxtContador;

    public AudioClip sonidoPistola;
    AudioSource fuenteAudio;

    public AudioClip sonidoGrito;
    public AudioClip sonidoEsperanza;

    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
            if(Physics.Raycast(myRay, out hitInfo))
            {
                fuenteAudio.clip = sonidoPistola;
                fuenteAudio.Play();

                if (hitInfo.collider.gameObject.CompareTag("Blancos"))
                {
                    Destroy(hitInfo.collider.gameObject);
                    puntuacion += 1;
                    TxtContador.text = puntuacion.ToString();
                }
                if (hitInfo.collider.gameObject.CompareTag("Maul"))
                {
                    fuenteAudio.clip = sonidoGrito;
                    fuenteAudio.Play();
                }
                if (hitInfo.collider.gameObject.CompareTag("Qui"))
                {
                    fuenteAudio.clip = sonidoEsperanza;
                    fuenteAudio.Play();
                }
            }
    }
}
