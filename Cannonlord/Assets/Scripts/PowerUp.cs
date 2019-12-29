using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private int rand;
    private bool direc;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        rand = Random.Range(1, 3);
        if (rand == 1)
        {
            direc = true;
        }
        if (rand == 2)
        {
            direc = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.1f)
        {
            time = 0;
            if (direc == true)
            {
                transform.localPosition += new Vector3(-0.15f, -0.15f, 0);
            }
            if (direc == false)
            {
                transform.localPosition += new Vector3(0.15f, -0.15f, 0);
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "direita")
        {
            direc = true;
        }
        if (collision.gameObject.tag == "esquerda")
        {
            direc = false;
        }
        if (collision.gameObject.tag == "fim")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "tiro")
        {
            Botoes.up = true;
            Destroy(this.gameObject);
        }
    }
}
