using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public GameObject obs;
    public Transform[] points = new Transform[5];
    private int num1;
    private int num2;
    private int num3;
    private int cont;
    private int rand;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
        num3 = 0;
        while (num3 == 0)
        {
            rand = Random.Range(1, 6);
            if (cont == 0)
            {
                num1 = rand;
                cont++;
            }
            if (cont == 1 && rand != num1)
            {
                num2 = rand;
                cont++;
            }
            if (cont == 2 && rand != num1 && rand != num2)
            {
                num3 = rand;
                cont++;
            }
        }
        Obstaculos(num1);
        Obstaculos(num2);
        Obstaculos(num3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Obstaculos(int ob)
    {
        if (ob == 1)
        {
            GameObject obst = (GameObject)Instantiate(obs, points[0].position, points[0].rotation);
        }
        if (ob == 2)
        {
            GameObject obst = (GameObject)Instantiate(obs, points[1].position, points[1].rotation);
        }
        if (ob == 3)
        {
            GameObject obst = (GameObject)Instantiate(obs, points[2].position, points[2].rotation);
        }
        if (ob == 4)
        {
            GameObject obst = (GameObject)Instantiate(obs, points[3].position, points[3].rotation);
        }
        if (ob == 5)
        {
            GameObject obst = (GameObject)Instantiate(obs, points[4].position, points[4].rotation);
        }
    }
}
