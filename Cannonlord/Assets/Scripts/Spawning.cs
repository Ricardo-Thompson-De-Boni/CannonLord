using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public Transform[] inicio = new Transform[5];
    public GameObject[] inimigo = new GameObject[3];
    public GameObject powerUp;
    private float time;
    private float time2;
    private int rand;
    private int rand2;
    private int rand3;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        time2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time2 += Time.deltaTime;
        time += Time.deltaTime;
        if (time >= 4)
        {
            rand = Random.Range(1, 6);
            rand2 = Random.Range(0, 3);
            if (rand == 1)
            {
                GameObject ini = (GameObject)Instantiate(inimigo[rand2], inicio[0].position, inicio[0].rotation);
            }
            else if (rand == 2)
            {
                GameObject ini = (GameObject)Instantiate(inimigo[rand2], inicio[1].position, inicio[1].rotation);
            }
            else if (rand == 3)
            {
                GameObject ini = (GameObject)Instantiate(inimigo[rand2], inicio[2].position, inicio[2].rotation);
            }
            else if (rand == 4)
            {
                GameObject ini = (GameObject)Instantiate(inimigo[rand2], inicio[3].position, inicio[3].rotation);
            }
            else if (rand == 5)
            {
                GameObject ini = (GameObject)Instantiate(inimigo[rand2], inicio[4].position, inicio[4].rotation);
            }
            time = 0;
        }
        if(time2 >= 15)
        {
            rand3 = Random.Range(1, 6);
            if (rand == 1)
            {
                GameObject pow = (GameObject)Instantiate(powerUp, inicio[0].position, inicio[0].rotation);
            }
            else if (rand == 2)
            {
                GameObject pow = (GameObject)Instantiate(powerUp, inicio[1].position, inicio[1].rotation);
            }
            else if (rand == 3)
            {
                GameObject pow = (GameObject)Instantiate(powerUp, inicio[2].position, inicio[2].rotation);
            }
            else if (rand == 4)
            {
                GameObject pow = (GameObject)Instantiate(powerUp, inicio[3].position, inicio[3].rotation);
            }
            else if (rand == 5)
            {
                GameObject pow = (GameObject)Instantiate(powerUp, inicio[4].position, inicio[4].rotation);
            }
            time2 = 0;
        }
    }
}
