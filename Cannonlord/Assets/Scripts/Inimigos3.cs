using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos3 : MonoBehaviour
{
    private int rand;
    private bool direc;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles += new Vector3(0, 0, 180);
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.1f)
        {
            time = 0;
            transform.localPosition += new Vector3(0, -0.1f, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fim")
        {
            GameOver.vida -= 1;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "tiro")
        {
            Pontuacao.pontos += 10;
            Destroy(this.gameObject);
        }
    }
}
