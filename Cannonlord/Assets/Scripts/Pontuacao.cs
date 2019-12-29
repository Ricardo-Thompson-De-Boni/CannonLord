using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Text txt;
    public static int pontos;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "" + pontos;
    }
}
