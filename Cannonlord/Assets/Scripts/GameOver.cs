using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text txt;
    public static int vida;
    public GameObject pause;
    public GameObject continuar;
    public GameObject atirar;
    public GameObject over;
    // Start is called before the first frame update
    void Start()
    {
        vida = 10;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "" + vida;
        if (vida <= 0)
        {
            Time.timeScale = 0;
            pause.SetActive(false);
            continuar.SetActive(false);
            atirar.SetActive(false);
            over.SetActive(true);
        }
    }

    
}
