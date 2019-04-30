using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMunu : MonoBehaviour
{

    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (isPause) Continue();
            else Pause();
    }

    public void Pause()
    {
        transform.Find("PauseMunu").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPause = true;
    }

    public void Continue()
    {
        transform.Find("PauseMunu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPause = false;
    }

    public void CambiarEscena(string _newScene)
    {
        SceneManager.LoadScene(_newScene);
    }


}
