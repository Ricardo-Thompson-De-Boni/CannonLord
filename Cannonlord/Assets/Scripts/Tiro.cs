using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 3)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "inimigo")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "direita")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "esquerda")
        {
            Destroy(this.gameObject);
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "obs")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "up")
        {
            Destroy(this.gameObject);
        }
    }
}
